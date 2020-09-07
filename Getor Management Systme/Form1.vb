Public Class mdiParent
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        Insert.MdiParent = Me
        Insert.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Search.MdiParent = Me
        Search.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Edit.MdiParent = Me
        Edit.Show()
    End Sub

    Private Sub mdiParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChartToolStripMenuItem.Click
        Pie_Chart.MdiParent = Me
        Pie_Chart.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.MdiParent = Me
        About.Show()
    End Sub
End Class
