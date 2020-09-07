Public Class EditForm
    Private SQL As New SQLControl
    Public Property idJemaat As Integer
    Public Property nama As String
    Public Property goldar As String
    Public Property tempat As String
    Public Property stat As String
    Public Property alamat As String
    Public Property notelp As String
    Public Property pddk As String
    Public Property pkrjn As String
    Public Property gereja As String


    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnection = True Then
            SQL.ExecQuery("SELECT * FROM PENDIDIKAN")
            If SQL.SQLDataset.Tables.Count > 0 Then
                cmbPddk.DataSource = SQL.SQLDataset.Tables(0)
                cmbPddk.DisplayMember = "PDDK_AKHR"
                cmbPddk.ValueMember = "ID_PDDK"
            End If
            SQL.ExecQuery("SELECT * FROM PEKERJAAN")
            If SQL.SQLDataset.Tables.Count > 0 Then
                cmbPkrjaan.DataSource = SQL.SQLDataset.Tables(0)
                cmbPkrjaan.DisplayMember = "NAMA_PKRJN"
                cmbPkrjaan.ValueMember = "ID_PEKERJAAN"
            End If
            SQL.ExecQuery("SELECT * FROM GEREJA")
            If SQL.SQLDataset.Tables.Count > 0 Then
                cmbGereja.DataSource = SQL.SQLDataset.Tables(0)
                cmbGereja.DisplayMember = "NAMA_GRJA"
                cmbGereja.ValueMember = "ID_GEREJA"
            End If
        End If

        txtNama.Text = nama
        If goldar = "A" Then
            rbA.Checked = True
        ElseIf goldar = "AB" Then
            rbAB.Checked = True
        ElseIf goldar = "B" Then
            rbB.Checked = True
        ElseIf goldar = "O" Then
            rbO.Checked = True
        End If
        txtTmptLhr.Text = tempat
        cmbStatus.SelectedItem = stat
        txtAlamat.Text = alamat
        mtxtTelp.Text = notelp
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim nama, tempatLhr, tglLhr, statKwn, alamat, pddk, pekerjaan, gerejaAsal As String
        Dim telp As String

        If txtNama.Text <> Nothing And txtTmptLhr.Text <> Nothing And cmbStatus.SelectedItem <> Nothing And txtAlamat.Text <> Nothing Then
            nama = txtNama.Text
            tempatLhr = txtTmptLhr.Text
            tglLhr = Format(dtpTglLahir.Value, "yyyy-MM-dd")
            statKwn = cmbStatus.SelectedItem
            alamat = txtAlamat.Text
            telp = mtxtTelp.Text
            pddk = cmbPddk.SelectedValue
            pekerjaan = cmbPkrjaan.SelectedValue
            gerejaAsal = cmbGereja.SelectedValue

            SQL.AddParam("@idjemaat", idJemaat)
            SQL.AddParam("@nama", nama)
            SQL.AddParam("@tempatLhr", tempatLhr)
            SQL.AddParam("@golDar", goldar)
            SQL.AddParam("@tglLhr", tglLhr)
            SQL.AddParam("@statKwn", statKwn)
            SQL.AddParam("@alamat", alamat)
            SQL.AddParam("@telp", telp)
            SQL.AddParam("@pddk", pddk)
            SQL.AddParam("@pekerjaan", pekerjaan)
            SQL.AddParam("@gerejaAsal", gerejaAsal)

            If SQL.HasConnection = True Then
                'SQL.ExecQuery("INSERT INTO JEMAAT(NAMA_LGKP,GOL_DRH,TMPT_LHR,TGL_LHR,STAT_KWN,ALAMAT,NO_TELP,ID_PDDK,ID_PEKERJAAN,ID_GEREJA) " &
                '         "VALUES(@nama,@golDar,@tempatLhr,@tglLhr,@statKwn,@alamat,@telp,@pddk,@pekerjaan,@gerejaAsal)")
                SQL.ExecQuery("UPDATE JEMAAT " &
                              "SET NAMA_LGKP = @nama, GOL_DRH = @goldar, TMPT_LHR = @tempatLhr, TGL_LHR = @tglLhr, STAT_KWN = @statKwn, ALAMAT = @alamat, NO_TELP = @telp, ID_PDDK = @pddk, ID_PEKERJAAN = @pekerjaan, ID_GEREJA = @gerejaAsal " &
                              "WHERE ID_JEMAAT = @idjemaat")
            End If

            If Not String.IsNullOrEmpty(SQL.Exception) Then
                MsgBox(SQL.Exception)
                Exit Sub
            End If

            MsgBox("Data Updated")
            Me.Close()
            Edit.Refresh()

        Else
            MsgBox("All Form must be filled")
        End If
    End Sub
End Class