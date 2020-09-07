Public Class Edit
    Private SQL As New SQLControl
    Dim edt As New EditForm

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim idJemaat As String
        If dgvData.SelectedRows.Count > 0 Then
            idJemaat = dgvData.SelectedRows(0).Cells(0).Value

            SQL.AddParam("@idJemaat", idJemaat)
            If SQL.HasConnection = True Then
                SQL.ExecQuery("DELETE FROM JEMAAT WHERE ID_JEMAAT = @idJemaat")
                MsgBox("Successfully Deleted")
                showData()
            End If
        Else
            MsgBox("Select a data first")
        End If
    End Sub

    Private Sub showData()
        If SQL.HasConnection = True Then
            SQL.ExecQuery("SELECT ID_JEMAAT,NAMA_LGKP,GOL_DRH,TMPT_LHR,TGL_LHR,STAT_KWN,ALAMAT,NO_TELP,PDDK_AKHR,NAMA_PKRJN,NAMA_GRJA " &
                          "FROM JEMAAT, PENDIDIKAN, PEKERJAAN, GEREJA " &
                          "WHERE PENDIDIKAN.ID_PDDK = JEMAAT.ID_PDDK and PEKERJAAN.ID_PEKERJAAN = JEMAAT.ID_PEKERJAAN and GEREJA.ID_GEREJA = JEMAAT.ID_GEREJA")
            If SQL.SQLDataset.Tables.Count > 0 Then
                dgvData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String
        If Not IsNumeric(txtSearch.Text) Then
            name = txtSearch.Text
            If SQL.HasConnection = True Then
                SQL.AddParam("@name", "%" & name & "%")
                SQL.ExecQuery("SELECT ID_JEMAAT,NAMA_LGKP,GOL_DRH,TMPT_LHR,TGL_LHR,STAT_KWN,ALAMAT,NO_TELP,PDDK_AKHR,NAMA_PKRJN,NAMA_GRJA " &
                          "FROM JEMAAT, PENDIDIKAN, PEKERJAAN, GEREJA " &
                          "WHERE PENDIDIKAN.ID_PDDK = JEMAAT.ID_PDDK and PEKERJAAN.ID_PEKERJAAN = JEMAAT.ID_PEKERJAAN and GEREJA.ID_GEREJA = JEMAAT.ID_GEREJA and NAMA_LGKP like @name ")
                If SQL.SQLDataset.Tables.Count > 0 Then
                    dgvData.DataSource = SQL.SQLDataset.Tables(0)
                End If
            End If
        Else
            MsgBox("Wrong Input")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvData.SelectedRows.Count > 0 Then
            edt.idJemaat = dgvData.SelectedRows(0).Cells(0).Value
            edt.nama = dgvData.SelectedRows(0).Cells(1).Value
            edt.goldar = dgvData.SelectedRows(0).Cells(2).Value
            edt.tempat = dgvData.SelectedRows(0).Cells(3).Value
            edt.stat = dgvData.SelectedRows(0).Cells(5).Value
            edt.alamat = dgvData.SelectedRows(0).Cells(6).Value
            edt.notelp = dgvData.SelectedRows(0).Cells(7).Value
            edt.pddk = dgvData.SelectedRows(0).Cells(8).Value
            edt.Show()
            edt = Nothing
            edt = New EditForm
        Else
            MsgBox("Select a data first")
        End If
    End Sub
End Class