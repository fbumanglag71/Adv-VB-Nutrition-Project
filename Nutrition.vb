'' Author: Francisco Bumanglag
'' Project: Nutrition Programming Project 
'' Assignment: Module 2 Exercise
'' Course: Adv Visual Basic, Santa Ana College
'' Class: CMPR205 Dr. Kimberly Davis 
'' Date: February 18, 2024


Public Class Nutrition
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        'declarations
        Const ONE_SERVING As Integer = 9
        Dim food As String = txtFood.Text
        Dim approved As String
        Dim calsPersServing As Decimal
        Dim GramsPerServing As Decimal
        Dim totalCalsFat As Decimal
        Dim percentCals As Decimal

        If food <> "" And IsNumeric(txtCalories.Text) And IsNumeric(txtFat.Text) Then

            'calcuations
            calsPersServing = CInt(txtCalories.Text)
            GramsPerServing = CInt(txtFat.Text)

            totalCalsFat = GramsPerServing * ONE_SERVING
            percentCals = totalCalsFat / calsPersServing

            'determine aha recommendations
            If percentCals <= 0.3 Then
                approved = "meets the AH recommendation"
            Else
                approved = "exceeds AHA recommendation"

            End If

        End If

        'display outcome 
        txtResults.Text = food & " contains " & FormatPercent(percentCals, 2) & " of calories from fat, which " & approved
        txtResults.Enabled = True

    End Sub


End Class
