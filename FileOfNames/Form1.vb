Imports System.IO

Public Class Form1
    Private Counter As Integer
    Private newCounter As Integer
    Private nameArray(50) As String
    Private newArray(50) As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxAddNames.Clear()
        ListBox1.Items.Clear()

    End Sub

    Private Sub btnStoreDisplay_Click(sender As Object, e As EventArgs) Handles btnStoreDisplay.Click
        Dim reader As New System.IO.StreamReader("Names.txt")
        Dim names As String
        ' Dim i As Integer
        Dim newName As String
        Dim listOfNames As New List(Of String)


        If IO.File.Exists("Names.txt") Then
            names = reader.ReadLine.ToString ' priming read

            Do While reader.Peek <> -1
                ListBox1.Items.Add(names)
                nameArray(Counter) = names
                Counter += 1
                names = reader.ReadLine.ToString 'stores names to array, shows them in listbox
            Loop
            ListBox1.Items.Add(names) ' need to store last item
            nameArray(Counter) = names
            Counter += 1

        Else
            Dim swCreate As IO.StreamWriter = IO.File.CreateText("Names.txt")
        End If

        reader.Close() ' closes the file

        newName = txtBoxAddNames.Text
        newArray(newCounter) = newName
        ListBox1.Items.Add(newArray(newCounter))
        newCounter += 1


    End Sub

End Class
