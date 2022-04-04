Public Class Form3
    Dim a As Integer
    Dim b As Integer
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        a = txtnum1.Text
        b = txtnum2.Text
        txtresult.Text = (a + b)
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        a = txtnum1.Text
        b = txtnum2.Text
        txtresult.Text = (a - b)
    End Sub

    Private Sub btnmult_Click(sender As Object, e As EventArgs) Handles btnmult.Click
        a = txtnum1.Text
        b = txtnum2.Text
        txtresult.Text = (a * b)
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        a = txtnum1.Text
        b = txtnum2.Text
        txtresult.Text = (a / b)
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim myForm As New Form1
        Me.Hide()
        myForm.Show()
    End Sub
End Class