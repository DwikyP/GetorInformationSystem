<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pie_Chart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpSet = New System.Windows.Forms.GroupBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbKanaan = New System.Windows.Forms.RadioButton()
        Me.rbBukit = New System.Windows.Forms.RadioButton()
        Me.rbEfrata = New System.Windows.Forms.RadioButton()
        Me.rbImanuel = New System.Windows.Forms.RadioButton()
        Me.rbEben = New System.Windows.Forms.RadioButton()
        Me.rbSion = New System.Windows.Forms.RadioButton()
        Me.rbArarat = New System.Windows.Forms.RadioButton()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSet.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(78, 362)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.IsValueShownAsLabel = True
        Series1.LabelFormat = "0%"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(666, 296)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(426, 63)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsValueShownAsLabel = True
        Series2.LabelFormat = "0%"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(318, 270)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PENDIDIKAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "UMUR"
        '
        'Chart3
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(54, 63)
        Me.Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.IsValueShownAsLabel = True
        Series3.LabelFormat = "0%"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(318, 270)
        Me.Chart3.TabIndex = 4
        Me.Chart3.Text = "Chart3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PEKERJAAN"
        '
        'grpSet
        '
        Me.grpSet.Controls.Add(Me.rbArarat)
        Me.grpSet.Controls.Add(Me.rbSion)
        Me.grpSet.Controls.Add(Me.rbEben)
        Me.grpSet.Controls.Add(Me.rbImanuel)
        Me.grpSet.Controls.Add(Me.rbEfrata)
        Me.grpSet.Controls.Add(Me.rbBukit)
        Me.grpSet.Controls.Add(Me.rbKanaan)
        Me.grpSet.Controls.Add(Me.rbAll)
        Me.grpSet.Location = New System.Drawing.Point(777, 113)
        Me.grpSet.Name = "grpSet"
        Me.grpSet.Size = New System.Drawing.Size(200, 220)
        Me.grpSet.TabIndex = 6
        Me.grpSet.TabStop = False
        Me.grpSet.Text = "Pengaturan"
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(6, 31)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(153, 17)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Klasis Bontang Kutai Kaltim"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbKanaan
        '
        Me.rbKanaan.AutoSize = True
        Me.rbKanaan.Location = New System.Drawing.Point(6, 54)
        Me.rbKanaan.Name = "rbKanaan"
        Me.rbKanaan.Size = New System.Drawing.Size(99, 17)
        Me.rbKanaan.TabIndex = 1
        Me.rbKanaan.Text = "Jemaat Kanaan"
        Me.rbKanaan.UseVisualStyleBackColor = True
        '
        'rbBukit
        '
        Me.rbBukit.AutoSize = True
        Me.rbBukit.Location = New System.Drawing.Point(6, 79)
        Me.rbBukit.Name = "rbBukit"
        Me.rbBukit.Size = New System.Drawing.Size(119, 17)
        Me.rbBukit.TabIndex = 2
        Me.rbBukit.Text = "Jemaat Bukit Zaitun"
        Me.rbBukit.UseVisualStyleBackColor = True
        '
        'rbEfrata
        '
        Me.rbEfrata.AutoSize = True
        Me.rbEfrata.Location = New System.Drawing.Point(6, 102)
        Me.rbEfrata.Name = "rbEfrata"
        Me.rbEfrata.Size = New System.Drawing.Size(90, 17)
        Me.rbEfrata.TabIndex = 3
        Me.rbEfrata.Text = "Jemaat Efrata"
        Me.rbEfrata.UseVisualStyleBackColor = True
        '
        'rbImanuel
        '
        Me.rbImanuel.AutoSize = True
        Me.rbImanuel.Location = New System.Drawing.Point(6, 125)
        Me.rbImanuel.Name = "rbImanuel"
        Me.rbImanuel.Size = New System.Drawing.Size(99, 17)
        Me.rbImanuel.TabIndex = 4
        Me.rbImanuel.Text = "Jemaat Imanuel"
        Me.rbImanuel.UseVisualStyleBackColor = True
        '
        'rbEben
        '
        Me.rbEben.AutoSize = True
        Me.rbEben.Location = New System.Drawing.Point(6, 148)
        Me.rbEben.Name = "rbEben"
        Me.rbEben.Size = New System.Drawing.Size(119, 17)
        Me.rbEben.TabIndex = 5
        Me.rbEben.Text = "Jemaat Ebenhaezer"
        Me.rbEben.UseVisualStyleBackColor = True
        '
        'rbSion
        '
        Me.rbSion.AutoSize = True
        Me.rbSion.Location = New System.Drawing.Point(6, 171)
        Me.rbSion.Name = "rbSion"
        Me.rbSion.Size = New System.Drawing.Size(143, 17)
        Me.rbSion.TabIndex = 6
        Me.rbSion.Text = "Jemaat Sion Kanibungan"
        Me.rbSion.UseVisualStyleBackColor = True
        '
        'rbArarat
        '
        Me.rbArarat.AutoSize = True
        Me.rbArarat.Location = New System.Drawing.Point(6, 194)
        Me.rbArarat.Name = "rbArarat"
        Me.rbArarat.Size = New System.Drawing.Size(90, 17)
        Me.rbArarat.TabIndex = 7
        Me.rbArarat.Text = "Jemaat Ararat"
        Me.rbArarat.UseVisualStyleBackColor = True
        '
        'Pie_Chart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 749)
        Me.Controls.Add(Me.grpSet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Pie_Chart"
        Me.Text = "Pie_Chart"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSet.ResumeLayout(False)
        Me.grpSet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents grpSet As GroupBox
    Friend WithEvents rbArarat As RadioButton
    Friend WithEvents rbSion As RadioButton
    Friend WithEvents rbEben As RadioButton
    Friend WithEvents rbImanuel As RadioButton
    Friend WithEvents rbEfrata As RadioButton
    Friend WithEvents rbBukit As RadioButton
    Friend WithEvents rbKanaan As RadioButton
    Friend WithEvents rbAll As RadioButton
End Class
