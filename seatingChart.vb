Public Class seatingChart
    Dim seats(20, 6) As String
    Dim frmAssign As New assignFlyer()
    Private Sub frmSeatingChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRows.Items.Add(" ABC DEF ")
        For i As Integer = 1 To 20
            For j As Integer = 1 To 6
                seats(i, j) = "O"
            Next
            lstRows.Items.Add(" OOO OOO ")
        Next
    End Sub

    Private Sub updateRow(row As Integer)
        txtRow.Text = row.ToString()
        txtA.Text = seats(row, 1)
        txtB.Text = seats(row, 2)
        txtC.Text = seats(row, 3)
        txtD.Text = seats(row, 4)
        txtE.Text = seats(row, 5)
        txtF.Text = seats(row, 6)
    End Sub
    Private Sub Assign(Seat As Integer)
        Dim row As Integer = lstRows.SelectedIndex
        If row > 0 Then
            assignFlyer.seat = seats(row, Seat)
            assignFlyer.ShowDialog()
            seats(row, Seat) = assignFlyer.seat
            updateRow(row)
            lstRows.Items(row) = " " & seats(row, 1) & seats(row, 2) & seats(row, 3) &
                                 " " & seats(row, 4) & seats(row, 5) & seats(row, 6)
        End If
    End Sub

    Private Sub lstRows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRows.SelectedIndexChanged
        Dim row As Integer = lstRows.SelectedIndex
        If row > 0 Then
            updateRow(row)
        End If
    End Sub

    Private Sub txtA_Click(sender As Object, e As EventArgs) Handles txtA.Click
        Assign(1)
    End Sub

    Private Sub txtB_Click(sender As Object, e As EventArgs) Handles txtB.Click
        Assign(2)
    End Sub

    Private Sub txtC_Click(sender As Object, e As EventArgs) Handles txtC.Click
        Assign(3)
    End Sub

    Private Sub txtD_Click(sender As Object, e As EventArgs) Handles txtD.Click
        Assign(4)
    End Sub

    Private Sub txtE_Click(sender As Object, e As EventArgs) Handles txtE.Click
        Assign(5)
    End Sub

    Private Sub txtF_Click(sender As Object, e As EventArgs) Handles txtF.Click
        Assign(6)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim passengers As Integer = 0
        Dim vacant As Integer = 0
        Dim window As Integer = 0

        For i As Integer = 1 To 20
            For j As Integer = 1 To 6
                Select Case seats(i, j)
                    Case " - "
                        passengers += 1
                    Case Else
                        vacant += 1
                        If j = 1 Or j = 6 Then
                            window += 1
                        End If
                End Select
            Next
        Next

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Seats Filled : " & (20 * 6 - vacant))
        lstDisplay.Items.Add("Windows Available : " & window)
        lstDisplay.Items.Add("Other Available seats :" & vacant - window)
    End Sub

End Class

