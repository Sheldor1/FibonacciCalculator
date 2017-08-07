Public Class Form1
    Dim number As Integer
    'Private Sub form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
    'For i As Integer = 5 To 100
    'If i Mod 5 = 0 Then
    'Debug.Write(i.ToString + ", ")
    'End If
    'Next
    'Dim index As Integer = 0



    'While index <= 100
    'If index Mod 5 = 0 Then
    'Debug.Write(index.ToString & " ")

    'End If
    'Index += 1

    'End While
    '    Dim sum As Integer = 2
    '    Dim lastnumber As Integer = 2
    '    Dim slastnumber As Integer = 1
    '    Dim nextnumber As Integer
    '    Debug.Write(1)
    '    While lastnumber <= 4000000
    '        nextnumber = lastnumber + slastnumber
    '        slastnumber = lastnumber
    '        lastnumber = nextnumber
    '        Debug.Write(" , " + lastnumber.ToString)
    '        If lastnumber Mod 2 = 0 And lastnumber <> 2 Then
    '            sum = sum + lastnumber

    '        End If
    '    End While
    '    MsgBox(sum)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 2
        Dim lastnumber As Integer = 2
        Dim slastnumber As Integer = 1
        Dim nextnumber As Integer
        Debug.Write(1)
        While lastnumber <= 4000000
            nextnumber = lastnumber + slastnumber
            slastnumber = lastnumber
            lastnumber = nextnumber
            Debug.Write(" , " + lastnumber.ToString)
            If lastnumber Mod 2 = 0 And lastnumber <> 2 Then
                sum = sum + lastnumber

            End If
        End While
        MsgBox(sum)
    End Sub
    'Private Function cube(number As Integer)

    '    Return number * number * number
    'End Function
End Class
