Public Class Search
    Private SQL As New SQLControl
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    ''' <summary>
    ''' dictionary to hold printed page details, with index key
    ''' </summary>
    ''' <remarks></remarks>
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()

    End Sub

    Dim jemaat As String

    Private Sub showData()
        If SQL.HasConnection = True Then
            SQL.ExecQuery("SELECT ID_JEMAAT,NAMA_LGKP,GOL_DRH,TMPT_LHR,TGL_LHR,STAT_KWN,ALAMAT,NO_TELP,PDDK_AKHR,NAMA_PKRJN,NAMA_GRJA " &
                          "FROM JEMAAT, PENDIDIKAN, PEKERJAAN, GEREJA " &
                          "WHERE PENDIDIKAN.ID_PDDK = JEMAAT.ID_PDDK and PEKERJAAN.ID_PEKERJAAN = JEMAAT.ID_PEKERJAAN and GEREJA.ID_GEREJA = JEMAAT.ID_GEREJA")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DataGridView1.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ppd As New PrintPreviewDialog
        ppd.Document = PrintDocument1
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height)
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40 + Label1.Height

        ' Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40
        'Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40 + Label1.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = DataGridView1.RowHeadersWidth

        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            If columnSum + DataGridView1.Columns(c).Width < maxWidth Then
                columnSum += DataGridView1.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = DataGridView1.RowHeadersWidth + DataGridView1.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = DataGridView1.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = DataGridView1.ColumnHeadersHeight

        For r As Integer = 0 To DataGridView1.Rows.Count - 2
            If rowSum + DataGridView1.Rows(r).Height < maxHeight Then
                rowSum += DataGridView1.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows(r).Height
                rowCounter = 1
            End If
            If r = DataGridView1.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height), Label1.Height)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 10
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(r + 1.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                startY += DataGridView1.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(DataGridView1.Columns(c).HeaderCell.Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                startX += DataGridView1.Columns(c).Width
            Next

            startY = rect.Bottom + DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 10 + DataGridView1.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(DataGridView1(c, r).Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                    startX += DataGridView1.Columns(c).Width
                Next
                startY += DataGridView1.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String
        If Not IsNumeric(txtSearch.Text) Then
            name = txtSearch.Text
            If SQL.HasConnection = True Then
                SQL.AddParam("@name", "%" & name & "%")
                SQL.AddParam("@jemaat", "%" & jemaat & "%")
                SQL.ExecQuery("SELECT ID_JEMAAT,NAMA_LGKP,GOL_DRH,TMPT_LHR,TGL_LHR,STAT_KWN,ALAMAT,NO_TELP,PDDK_AKHR,NAMA_PKRJN,NAMA_GRJA " &
                          "FROM JEMAAT, PENDIDIKAN, PEKERJAAN, GEREJA " &
                          "WHERE PENDIDIKAN.ID_PDDK = JEMAAT.ID_PDDK and PEKERJAAN.ID_PEKERJAAN = JEMAAT.ID_PEKERJAAN and GEREJA.ID_GEREJA = JEMAAT.ID_GEREJA and NAMA_LGKP like @name and NAMA_GRJA like @jemaat")
                If SQL.SQLDataset.Tables.Count > 0 Then
                    DataGridView1.DataSource = SQL.SQLDataset.Tables(0)
                End If
            End If
        Else
            MsgBox("Wrong Input")
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub rbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged
        jemaat = ""
    End Sub

    Private Sub rbImanuel_CheckedChanged(sender As Object, e As EventArgs) Handles rbImanuel.CheckedChanged
        jemaat = rbImanuel.Text
    End Sub

    Private Sub rbBukit_CheckedChanged(sender As Object, e As EventArgs) Handles rbBukit.CheckedChanged
        jemaat = rbBukit.Text
    End Sub

    Private Sub rbEfrata_CheckedChanged(sender As Object, e As EventArgs) Handles rbEfrata.CheckedChanged
        jemaat = rbEfrata.Text
    End Sub

    Private Sub rbKanaan_CheckedChanged(sender As Object, e As EventArgs) Handles rbKanaan.CheckedChanged
        jemaat = rbKanaan.Text
    End Sub

    Private Sub rbSion_CheckedChanged(sender As Object, e As EventArgs) Handles rbSion.CheckedChanged
        jemaat = rbSion.Text
    End Sub

    Private Sub rbEbenhaezer_CheckedChanged(sender As Object, e As EventArgs) Handles rbEbenhaezer.CheckedChanged
        jemaat = rbEbenhaezer.Text
    End Sub

    Private Sub rbArarat_CheckedChanged(sender As Object, e As EventArgs) Handles rbArarat.CheckedChanged
        jemaat = rbArarat.Text
    End Sub
End Class