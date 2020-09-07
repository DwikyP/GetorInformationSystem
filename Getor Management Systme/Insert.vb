Public Class Insert
    Private SQL As New SQLControl
    Dim golDarah As Boolean = False
    Dim golDar As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim nama, tempatLhr, tglLhr, statKwn, alamat, pddk, pekerjaan, gerejaAsal As String
        Dim telp As String

        If txtNama.Text <> Nothing And golDarah And txtTmptLhr.Text <> Nothing And cmbStatus.SelectedItem <> Nothing And txtAlamat.Text <> Nothing Then
            nama = txtNama.Text
            tempatLhr = txtTmptLhr.Text
            tglLhr = Format(dtpTglLahir.Value, "yyyy-MM-dd")
            statKwn = cmbStatus.SelectedItem
            alamat = txtAlamat.Text
            telp = mtxtTelp.Text
            pddk = cmbPddk.SelectedValue
            pekerjaan = cmbPkrjaan.SelectedValue
            gerejaAsal = cmbGereja.SelectedValue

            SQL.AddParam("@nama", nama)
            SQL.AddParam("@tempatLhr", tempatLhr)
            SQL.AddParam("@golDar", golDar)
            SQL.AddParam("@tglLhr", tglLhr)
            SQL.AddParam("@statKwn", statKwn)
            SQL.AddParam("@alamat", alamat)
            SQL.AddParam("@telp", telp)
            SQL.AddParam("@pddk", pddk)
            SQL.AddParam("@pekerjaan", pekerjaan)
            SQL.AddParam("@gerejaAsal", gerejaAsal)

            If SQL.HasConnection = True Then
                SQL.ExecQuery("INSERT INTO JEMAAT(NAMA_LGKP,GOL_DRH,TMPT_LHR,TGL_LHR,STAT_KWN,ALAMAT,NO_TELP,ID_PDDK,ID_PEKERJAAN,ID_GEREJA) " &
                         "VALUES(@nama,@golDar,@tempatLhr,@tglLhr,@statKwn,@alamat,@telp,@pddk,@pekerjaan,@gerejaAsal)")
            End If

            If Not String.IsNullOrEmpty(SQL.Exception) Then
                MsgBox(SQL.Exception)
                Exit Sub
            End If

            MsgBox("Data Inserted")
            showData()
        Else
            MsgBox("All Form must be filled")
        End If
    End Sub

    Private Sub Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            showData()
        End If

    End Sub

    Function isLetter(ByVal x As Char)
        Return UCase(x) >= "A" And UCase(x) <= "Z"
    End Function

    Private Sub rbA_CheckedChanged(sender As Object, e As EventArgs) Handles rbA.CheckedChanged
        golDar = "A"
        golDarah = True
    End Sub

    Private Sub rbB_CheckedChanged(sender As Object, e As EventArgs) Handles rbB.CheckedChanged
        golDar = "B"
        golDarah = True
    End Sub

    Private Sub rbAB_CheckedChanged(sender As Object, e As EventArgs) Handles rbAB.CheckedChanged
        golDar = "AB"
        golDarah = True
    End Sub

    Private Sub rbO_CheckedChanged(sender As Object, e As EventArgs) Handles rbO.CheckedChanged
        golDar = "O"
        golDarah = True
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub showData()
        If SQL.HasConnection = True Then
            SQL.ExecQuery("SELECT * FROM JEMAAT")
            If SQL.SQLDataset.Tables.Count > 0 Then
                dgvData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

End Class