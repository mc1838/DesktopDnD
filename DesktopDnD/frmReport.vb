Public Class frmReport
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This is the help box for Dungeons and Dynamite - Desktop!\n Reports!", "Dungeons and Dynamite Help",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExintToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub txtReport_TextChanged(sender As Object, e As EventArgs) Handles txtReport.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Database connection here...
        'Dim table As DataTable = modConnect.SQLSelect("SELECT * FROM [dbo].[TestTable]")
        'Dim rows As DataRowCollection = DataTable.Rows
        Dim ds As DataSet = modConnect.SQLSelect("SELECT * FROM [dbo].[TestTable]")
        If ds.Tables(0).Rows.Count > 0 Then
            'txtReport.Text = ds.Tables(0).Rows(0)("Details").ToString
            txtReport.Text = ds.Tables(0).Rows(0).ToString
            'txtReport.Text = ds.Tables(0).Rows(0).ToString
        End If


    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'Me.Close() 'not sure about order
        frmMain.Show()

    End Sub
End Class