Public Class frmReport
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This is the help box for Dungeons and Dynamite - Desktop!\n Reports!", "Dungeons and Dynamite Help",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExintToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class