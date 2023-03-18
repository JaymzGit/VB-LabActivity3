Public Class Loan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim income, years As Integer

        income = txtIncome.Text
        years = txtYears.Text

        If income > 30000 And years > 2 Then
            lblStatus.Text = "Applicant qualifies"
        Else
            If years > 5 Then
                lblStatus.Text = "Applicant qualifies"
            Else
                lblStatus.Text = "Applicant does not qualify"
            End If
        End If
    End Sub
End Class