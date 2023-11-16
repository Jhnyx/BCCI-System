Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Home
    Private Sub pInput_Paint(sender As Object, e As PaintEventArgs) Handles pInput.Paint
        pInput.BackColor = Color.FromArgb(125, Color.Black)
    End Sub

    Private Sub pOutput_Paint(sender As Object, e As PaintEventArgs) Handles pOutput.Paint
        pOutput.BackColor = Color.FromArgb(125, Color.Black)
    End Sub

    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        Dim Name As String = employeeNameInput.Text
        Dim Company As String = companyNameInput.Text
        Dim monthlySalary As Double = Convert.ToDouble(monthlySalaryInput.Value)

        ' Calculate the values
        Dim incomeTaxValue As Double = IncomeTax(monthlySalary)
        Dim pagIbigValue As Double = PagIbig(monthlySalary)
        Dim sssValue As Double = SSS(monthlySalary)
        Dim philhealthValue As Double = PhilHealth(monthlySalary)

        ' Display the values in the output TextBoxes
        employeeNameOutput.Text = Name
        companyNameOutput.Text = Company
        monthlySalaryOutput.Text = monthlySalary.ToString("C2")
        incomeTaxOutput.Text = incomeTaxValue.ToString("C2")
        pagIbigOutput.Text = pagIbigValue.ToString("C2")
        sssOutput.Text = sssValue.ToString("C2")
        philhealthOutput.Text = philhealthValue.ToString("C2")
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click

        employeeNameInput.Text = "Name of Employee"
        companyNameInput.Text = "Name of Company"
        monthlySalaryInput.Value = 0

        employeeNameOutput.Text = "Name of Employee"
        companyNameOutput.Text = "Name of Company"
        monthlySalaryOutput.Text = "Monthly Salary"
        incomeTaxOutput.Text = "Income Tax"
        pagIbigOutput.Text = "Pag-Ibig"
        sssOutput.Text = "SSS"
        philhealthOutput.Text = "PhilHealth"
    End Sub

    Public Function IncomeTax(MonthlySalary As Double) As Double
        Dim AnnualSalary As Double = MonthlySalary * 12
        Dim tax As Double
        If AnnualSalary <= 250000 Then
            tax = 0

        ElseIf AnnualSalary > 250000 & AnnualSalary <= 400000 Then
            tax = (0.2 * (AnnualSalary - 250000)) / 12

        ElseIf AnnualSalary > 400000 & AnnualSalary <= 800000 Then
            tax = (30000 + (0.25 * (AnnualSalary - 400000))) / 12

        ElseIf AnnualSalary > 800000 & AnnualSalary <= 2000000 Then
            tax = (130000 + (0.3 * (AnnualSalary - 800000))) / 12

        ElseIf AnnualSalary > 2000000 & AnnualSalary <= 8000000 Then
            tax = (490000 + (0.32 * (AnnualSalary - 2000000))) / 12

        Else
            tax = (2410000 + (0.35 * (AnnualSalary - 8000000))) / 12
        End If
        Return tax.ToString("0.00")
    End Function

    Public Function PagIbig(MonthlySalary As Double) As Double
        Dim Ibig As Double
        If MonthlySalary <= 1500 Then
            Ibig = 0.01 * MonthlySalary
        Else
            Ibig = 0.02 * MonthlySalary
        End If

        Return Ibig.ToString("0.00")
    End Function

    Public Function SSS(MonthlySalary As Double) As Double
        Dim SS As Double = 0
        Dim first As Double = 2250
        Dim last As Double = 2749.99
        Dim max As Double = 19750
        Dim j As Integer = 80

        For i As Integer = 1 To 36
            If MonthlySalary < first Then
                SS = j
                Exit For
            ElseIf MonthlySalary > max Then
                SS = 800
                Exit For
            Else
                j += 20
                first += 500
            End If
        Next
        Return SS.ToString("0.00")
    End Function

    Public Function PhilHealth(MonthlySalary As Double) As Double
        Dim Health As Double = 0
        Dim first As Double = 9000
        Dim last As Double = 9999.99
        Dim max As Double = 35000
        Dim j As Double = 112.5

        For i As Integer = 1 To 27
            If MonthlySalary < first Then
                Health = 100
                Exit For

            ElseIf MonthlySalary > max Then
                Health = 437.5
                Exit For

            ElseIf MonthlySalary >= first & MonthlySalary <= last Then
                Health = j
                Exit For

            Else
                j += 12.5
                first += 1000
                last += 1000
            End If
        Next
        Return Health.ToString("0.00")
    End Function
End Class
