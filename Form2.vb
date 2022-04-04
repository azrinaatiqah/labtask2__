Public Class Form2
    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Dim strName As String = txt1.Text
        Dim strAge As String = txt2.Text
        Dim strResult As String = "My Name is " + strName + ", I am " + strAge + " Years Old"

        txtdetails.Text = strResult

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myForm As New Form3
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim myForm As New Form1
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        BackColor = ColorDialog1.Color
    End Sub
End Class