<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Controls.Add(Me.Label1)
        Me.grp.Location = New System.Drawing.Point(12, 22)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(245, 224)
        Me.grp.TabIndex = 0
        Me.grp.TabStop = False
        Me.grp.Text = "About"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Copyright 2019"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Getor Management System v1.1.1"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 258)
        Me.Controls.Add(Me.grp)
        Me.Name = "About"
        Me.Text = "About"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
