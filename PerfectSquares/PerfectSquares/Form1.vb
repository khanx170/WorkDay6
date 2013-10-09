Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim num As Integer
        num = 1
        Do While num <= 1000
            lstResult.Items.Add("The Perfect Square: " & num ^ 2)
            num = num + 1 ' if you forget this, it will be an infinite loop 
        Loop


    End Sub
End Class
