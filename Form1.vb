Public Class Form1
    Private Sub RegisterationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterationToolStripMenuItem.Click
        Dim myForm As New Form2
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program is designed by NUR AZRINA ATIQAH BINTI AZRI, 10DDT20F1030, JTMK", "Verification")
    End Sub

End Class
