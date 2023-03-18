Public Class Grade
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marks As Integer = txtMarks.Text

        If marks >= 80 And marks <= 100 Then
            txtGrade.Text = "A"
        ElseIf marks >= 70 And marks <= 79 Then
            txtGrade.Text = "B"
        ElseIf marks >= 60 And marks <= 69 Then
            txtGrade.Text = "C"
        ElseIf marks >= 50 And marks <= 59 Then
            txtGrade.Text = "D"
        ElseIf marks >= 0 And marks < 50 Then
            txtGrade.Text = "E"
        Else
            txtGrade.Text = "Invalid"
        End If
    End Sub
End Class