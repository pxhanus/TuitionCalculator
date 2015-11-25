'Patricia Hanus
'151125
'Tuition Calculator
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const UNDERGRADUATE_PER_HOUR As Decimal = 75
        Const GRADUATE_PER_HOUR As Decimal = 145
        Const THESIS_PER_HOUR As Decimal = 160
        Dim creditHours As Integer
        Dim tuition As Decimal

        If Me.cboCreditHours.SelectedIndex >= 0 Then    'list item selected
            creditHours = Val(Me.cboCreditHours.SelectedItem)
        Else
            creditHours = Val(Me.cboCreditHours.Text)   'value typed
        End If

        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                tuition = UNDERGRADUATE_PER_HOUR * creditHours
            Case "Graduate"
                tuition = GRADUATE_PER_HOUR * creditHours
            Case "Thesis and Dissertation"
                tuition = THESIS_PER_HOUR * creditHours
        End Select

        Me.lblTuition.Text = "Tuition is " & Format(tuition, "Currency")
    End Sub

    Private Sub lstCourseLevels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourseLevels.SelectedIndexChanged
        Me.lblTuition.Text = Nothing
    End Sub
End Class
