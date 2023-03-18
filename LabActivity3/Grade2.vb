Public Class Grade2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marks As Integer = txtMarks.Text

        Select Case marks
            Case 80 To 100
                txtGrade.Text = "A"
            Case 70 To 79
                txtGrade.Text = "B"
            Case 60 To 69
                txtGrade.Text = "C"
            Case 50 To 59
                txtGrade.Text = "D"
            Case 0 To 50
                txtGrade.Text = "E"
            Case Else
                txtGrade.Text = "Invalid"
        End Select
    End Sub
End Class