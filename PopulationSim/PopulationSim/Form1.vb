Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim currentpop As Double
        Dim currentyear As Integer
        currentyear = 2012
        currentpop = 7000
        Do While (currentpop > 6)
            currentyear = currentyear - 50
            currentpop = currentpop / 2

        Loop
        MessageBox.Show("This year is " & currentyear, "Error")

    End Sub
End Class
