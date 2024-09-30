Public Class Form1
    Private Sub btnGenerateTable_Click(sender As Object, e As EventArgs) Handles btnGenerateTable.Click
        ' Clear the ListBox before adding new data
        lstMultiplicationTable.Items.Clear()

        ' Nested loop to generate the multiplication table (1-10)
        For i As Integer = 1 To 10
            For j As Integer = 1 To 10
                ' Add the result of multiplication to the ListBox
                lstMultiplicationTable.Items.Add(i.ToString() & " x " & j.ToString() & " = " & (i * j).ToString())
            Next
            ' Add a blank line after each row for readability
            lstMultiplicationTable.Items.Add("")
        Next
    End Sub
End Class
