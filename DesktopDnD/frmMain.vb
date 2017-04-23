Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim re As New Text.RegularExpressions.Regex("\d") 'check that it has a digit
        If Not re.IsMatch(txtID.Text) Then
            MsgBox("Must have at least one digit!")
        Else
            Me.Hide()
            frmReport.ShowDialog()

        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim re As New Text.RegularExpressions.Regex("\d") 'check that it has a digit
        If Not re.IsMatch(txtID.Text) Then
            MsgBox("Must have at least one digit!")
        Else
            MessageBox.Show("New ID Registered!", "ID Registered",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmReport.ShowDialog()

        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This is the help box for Dungeons and Dynamite - Desktop!\n Login!", "Dungeons and Dynamite Help",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExintToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.Text.Trim() IsNot "" Then
            btnLogin.Enabled = True
            btnRegister.Enabled = True
        Else
            btnLogin.Enabled = False
            btnRegister.Enabled = False
        End If
    End Sub
End Class
