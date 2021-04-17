Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strDayName(6) As String
        strDayName(0) = "Sunday"
        strDayName(1) = "Monday"
        strDayName(2) = "Tuesday"
        strDayName(3) = "Wendnesday"
        strDayName(4) = "Thrusday"
        strDayName(5) = "Friday"
        strDayName(6) = "Saturday"

        Dim K As Integer
        For K = 0 To 6
            lstbox.Items.Add(strDayName(K))
        Next

    End Sub
End Class
