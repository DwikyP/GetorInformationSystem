<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Insert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTmptLhr = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbAB = New System.Windows.Forms.RadioButton()
        Me.rbO = New System.Windows.Forms.RadioButton()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.mtxtTelp = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPddk = New System.Windows.Forms.ComboBox()
        Me.cmbPkrjaan = New System.Windows.Forms.ComboBox()
        Me.cmbGereja = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(316, 50)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(348, 20)
        Me.txtNama.TabIndex = 0
        '
        'txtTmptLhr
        '
        Me.txtTmptLhr.Location = New System.Drawing.Point(316, 99)
        Me.txtTmptLhr.Name = "txtTmptLhr"
        Me.txtTmptLhr.Size = New System.Drawing.Size(163, 20)
        Me.txtTmptLhr.TabIndex = 2
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(316, 194)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(313, 20)
        Me.txtAlamat.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(211, 53)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "NAMA LENGKAP : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "GOL. DARAH : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TEMPAT LAHIR : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TANGGAL LAHIR : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "STATUS KAWIN : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ALAMAT : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(245, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "NO. TELP : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(223, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "GEREJA ASAL : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(193, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "PENDIDIKAN AKHIR : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(232, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "PEKERJAAN : "
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(317, 76)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(32, 17)
        Me.rbA.TabIndex = 16
        Me.rbA.TabStop = True
        Me.rbA.Text = "A"
        Me.rbA.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(355, 76)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(32, 17)
        Me.rbB.TabIndex = 17
        Me.rbB.TabStop = True
        Me.rbB.Text = "B"
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbAB
        '
        Me.rbAB.AutoSize = True
        Me.rbAB.Location = New System.Drawing.Point(393, 76)
        Me.rbAB.Name = "rbAB"
        Me.rbAB.Size = New System.Drawing.Size(39, 17)
        Me.rbAB.TabIndex = 18
        Me.rbAB.TabStop = True
        Me.rbAB.Text = "AB"
        Me.rbAB.UseVisualStyleBackColor = True
        '
        'rbO
        '
        Me.rbO.AutoSize = True
        Me.rbO.Location = New System.Drawing.Point(438, 76)
        Me.rbO.Name = "rbO"
        Me.rbO.Size = New System.Drawing.Size(33, 17)
        Me.rbO.TabIndex = 19
        Me.rbO.TabStop = True
        Me.rbO.Text = "O"
        Me.rbO.UseVisualStyleBackColor = True
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Location = New System.Drawing.Point(316, 129)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(200, 20)
        Me.dtpTglLahir.TabIndex = 20
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"BELUM KAWIN", "KAWIN", "CERAI HIDUP", "CERAI MATI"})
        Me.cmbStatus.Location = New System.Drawing.Point(316, 164)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatus.TabIndex = 21
        '
        'mtxtTelp
        '
        Me.mtxtTelp.Location = New System.Drawing.Point(332, 220)
        Me.mtxtTelp.Mask = "6200000000000000"
        Me.mtxtTelp.Name = "mtxtTelp"
        Me.mtxtTelp.Size = New System.Drawing.Size(105, 20)
        Me.mtxtTelp.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "+"
        '
        'cmbPddk
        '
        Me.cmbPddk.FormattingEnabled = True
        Me.cmbPddk.Location = New System.Drawing.Point(316, 246)
        Me.cmbPddk.Name = "cmbPddk"
        Me.cmbPddk.Size = New System.Drawing.Size(141, 21)
        Me.cmbPddk.TabIndex = 24
        '
        'cmbPkrjaan
        '
        Me.cmbPkrjaan.FormattingEnabled = True
        Me.cmbPkrjaan.Location = New System.Drawing.Point(316, 281)
        Me.cmbPkrjaan.Name = "cmbPkrjaan"
        Me.cmbPkrjaan.Size = New System.Drawing.Size(141, 21)
        Me.cmbPkrjaan.TabIndex = 25
        '
        'cmbGereja
        '
        Me.cmbGereja.FormattingEnabled = True
        Me.cmbGereja.Location = New System.Drawing.Point(316, 312)
        Me.cmbGereja.Name = "cmbGereja"
        Me.cmbGereja.Size = New System.Drawing.Size(141, 21)
        Me.cmbGereja.TabIndex = 26
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(604, 359)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(27, 415)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(834, 168)
        Me.dgvData.TabIndex = 28
        '
        'Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 749)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbGereja)
        Me.Controls.Add(Me.cmbPkrjaan)
        Me.Controls.Add(Me.cmbPddk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtxtTelp)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.rbO)
        Me.Controls.Add(Me.rbAB)
        Me.Controls.Add(Me.rbB)
        Me.Controls.Add(Me.rbA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTmptLhr)
        Me.Controls.Add(Me.txtNama)
        Me.Name = "Insert"
        Me.Text = "Insert"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTmptLhr As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents rbA As RadioButton
    Friend WithEvents rbB As RadioButton
    Friend WithEvents rbAB As RadioButton
    Friend WithEvents rbO As RadioButton
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents mtxtTelp As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPddk As ComboBox
    Friend WithEvents cmbPkrjaan As ComboBox
    Friend WithEvents cmbGereja As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dgvData As DataGridView
End Class
