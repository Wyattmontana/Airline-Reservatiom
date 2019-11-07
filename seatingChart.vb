Public Class seatingChart
    Dim seats(20, 6) As String
    Dim frmAssign As New assignFlyer()
    Private Sub frmSeatingChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRows.Items.Add(" ABC DEF ")
        For i As Integer = 1 To 20
            For j As Integer = 1 To 6
                seats(i, j) = " - "
            Next
            lstRows.Items.Add(" OOO OOO")
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
    End Sub


End Class

