Public Class assignFlyer
    Public seat As String
    Private Sub assignFlyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case seat
            Case " - "
                MsgBox("ERROR SEAT ALREADY TAKEN")
                Close()
            Case Else
                MsgBox("Please fill out the information asked for")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        seat = " - "
        Close()
    End Sub
End Class