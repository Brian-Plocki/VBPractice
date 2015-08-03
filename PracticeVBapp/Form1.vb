Public Class Form1


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'printEvenNumbers()

        Dim myPerson As Person = New Person()

        Dim n As String
        Dim a As String
        Dim c As String
        Dim z As String

        n = txtName.Text.ToString()
        a = txtAge.Text.ToString()
        c = txtCity.Text.ToString()
        z = txtZip.Text.ToString()

        myPerson.Name = n
        myPerson.Age = a
        myPerson.City = c
        myPerson.Zip = z

        clearEntries()
        MessageBox.Show(myPerson.ToString)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        clearEntries()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub clearEntries()

        txtName.Text = ""
        txtAge.Text = ""
        txtCity.Text = ""
        txtZip.Text = ""

    End Sub

    Private Sub printEvenNumbers()

        For i As Integer = 1 To 10
            If i Mod 2 = 0 Then
                MessageBox.Show(i.ToString)

            Else
                ' we do nothing as the number is odd
            End If
        Next

    End Sub


End Class
