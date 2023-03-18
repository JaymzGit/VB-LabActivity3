Public Class Days
    Public Enum month
        January = 1
        February
        March
        April
        May
        June
        July
        August
        September
        October
        November
        December
    End Enum
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim monthSelected As String = ComboBox1.SelectedItem

        Select Case monthSelected
            Case "January"
                lblDays.Text = "31 Days in January"
            Case "February"
                lblDays.Text = "28 Days in February"
            Case "March"
                lblDays.Text = "31 Days in March"
            Case "April"
                lblDays.Text = "30 Days in April"
            Case "May"
                lblDays.Text = "31 Days in May"
            Case "June"
                lblDays.Text = "30 Days in June"
            Case "July"
                lblDays.Text = "31 Days in July"
            Case "August"
                lblDays.Text = "31 Days in August"
            Case "September"
                lblDays.Text = "30 Days in September"
            Case "October"
                lblDays.Text = "31 Days in October"
            Case "November"
                lblDays.Text = "30 Days in November"
            Case "December"
                lblDays.Text = "31 Days in December"
        End Select
    End Sub

    Private Sub Days_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = [Enum].GetNames(GetType(month))
    End Sub
End Class