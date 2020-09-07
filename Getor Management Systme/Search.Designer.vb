<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbImanuel = New System.Windows.Forms.RadioButton()
        Me.rbBukit = New System.Windows.Forms.RadioButton()
        Me.rbEfrata = New System.Windows.Forms.RadioButton()
        Me.rbKanaan = New System.Windows.Forms.RadioButton()
        Me.rbSion = New System.Windows.Forms.RadioButton()
        Me.rbEbenhaezer = New System.Windows.Forms.RadioButton()
        Me.rbArarat = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Location = New System.Drawing.Point(12, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1231, 439)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1280, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1280, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PKBGT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(67, 129)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(434, 20)
        Me.txtSearch.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(518, 127)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(67, 155)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(36, 17)
        Me.rbAll.TabIndex = 6
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbImanuel
        '
        Me.rbImanuel.AutoSize = True
        Me.rbImanuel.Location = New System.Drawing.Point(109, 155)
        Me.rbImanuel.Name = "rbImanuel"
        Me.rbImanuel.Size = New System.Drawing.Size(99, 17)
        Me.rbImanuel.TabIndex = 7
        Me.rbImanuel.Text = "Jemaat Imanuel"
        Me.rbImanuel.UseVisualStyleBackColor = True
        '
        'rbBukit
        '
        Me.rbBukit.AutoSize = True
        Me.rbBukit.Location = New System.Drawing.Point(214, 155)
        Me.rbBukit.Name = "rbBukit"
        Me.rbBukit.Size = New System.Drawing.Size(119, 17)
        Me.rbBukit.TabIndex = 8
        Me.rbBukit.Text = "Jemaat Bukit Zaitun"
        Me.rbBukit.UseVisualStyleBackColor = True
        '
        'rbEfrata
        '
        Me.rbEfrata.AutoSize = True
        Me.rbEfrata.Location = New System.Drawing.Point(339, 155)
        Me.rbEfrata.Name = "rbEfrata"
        Me.rbEfrata.Size = New System.Drawing.Size(90, 17)
        Me.rbEfrata.TabIndex = 9
        Me.rbEfrata.Text = "Jemaat Efrata"
        Me.rbEfrata.UseVisualStyleBackColor = True
        '
        'rbKanaan
        '
        Me.rbKanaan.AutoSize = True
        Me.rbKanaan.Location = New System.Drawing.Point(435, 155)
        Me.rbKanaan.Name = "rbKanaan"
        Me.rbKanaan.Size = New System.Drawing.Size(99, 17)
        Me.rbKanaan.TabIndex = 10
        Me.rbKanaan.Text = "Jemaat Kanaan"
        Me.rbKanaan.UseVisualStyleBackColor = True
        '
        'rbSion
        '
        Me.rbSion.AutoSize = True
        Me.rbSion.Location = New System.Drawing.Point(540, 155)
        Me.rbSion.Name = "rbSion"
        Me.rbSion.Size = New System.Drawing.Size(143, 17)
        Me.rbSion.TabIndex = 11
        Me.rbSion.Text = "Jemaat Sion Kanibungan"
        Me.rbSion.UseVisualStyleBackColor = True
        '
        'rbEbenhaezer
        '
        Me.rbEbenhaezer.AutoSize = True
        Me.rbEbenhaezer.Location = New System.Drawing.Point(689, 155)
        Me.rbEbenhaezer.Name = "rbEbenhaezer"
        Me.rbEbenhaezer.Size = New System.Drawing.Size(119, 17)
        Me.rbEbenhaezer.TabIndex = 12
        Me.rbEbenhaezer.Text = "Jemaat Ebenhaezer"
        Me.rbEbenhaezer.UseVisualStyleBackColor = True
        '
        'rbArarat
        '
        Me.rbArarat.AutoSize = True
        Me.rbArarat.Location = New System.Drawing.Point(814, 155)
        Me.rbArarat.Name = "rbArarat"
        Me.rbArarat.Size = New System.Drawing.Size(90, 17)
        Me.rbArarat.TabIndex = 13
        Me.rbArarat.Text = "Jemaat Ararat"
        Me.rbArarat.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 749)
        Me.Controls.Add(Me.rbArarat)
        Me.Controls.Add(Me.rbEbenhaezer)
        Me.Controls.Add(Me.rbSion)
        Me.Controls.Add(Me.rbKanaan)
        Me.Controls.Add(Me.rbEfrata)
        Me.Controls.Add(Me.rbBukit)
        Me.Controls.Add(Me.rbImanuel)
        Me.Controls.Add(Me.rbAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Search"
        Me.Text = "Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents rbImanuel As RadioButton
    Friend WithEvents rbBukit As RadioButton
    Friend WithEvents rbEfrata As RadioButton
    Friend WithEvents rbKanaan As RadioButton
    Friend WithEvents rbSion As RadioButton
    Friend WithEvents rbEbenhaezer As RadioButton
    Friend WithEvents rbArarat As RadioButton
End Class
