Public Class BMI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight As Double = InputBox("Enter Your Weight (KG)", "BMI Calculator")
        Dim height As Double = InputBox("Enter Your Height (M)", "BMI Calculator")
        Dim BMI As Double

        lblWeight.Text = weight
        lblHeight.Text = height

        BMI = weight / (height * height)
        BMI = Math.Round(BMI, 2)
        lblBMI.Text = BMI

        If BMI < 18.5 Then
            lblStatus.Text = "Underweight"
        ElseIf BMI >= 18.5 And BMI <= 24.9 Then
            lblStatus.Text = "Healthy"
        ElseIf BMI >= 25.0 And BMI <= 29.9 Then
            lblStatus.Text = "Overweight"
        ElseIf BMI >= 30.0 Then
            lblStatus.Text = "Obese"
        End If
    End Sub
End Class