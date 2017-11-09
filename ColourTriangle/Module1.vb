Module Module1

    Sub Main()

        Dim row As String
        Dim newRow As String
        Dim c1 As Char
        Dim c2 As Char
        Dim pair As String
        Dim Len As Integer

        Console.Write("Enter the starting row ")
        row = Console.ReadLine
        Len = row.Length
        newRow = ""

        Do While Len > 1
            For N = 0 To Len - 2
                c1 = row(N)
                c2 = row(N + 1)
                pair = c1 & c2
                newRow = ""
                'Console.WriteLine("A pair is {0} and {1}", c1, c2)
                If c1 = c2 Then
                    newRow = newRow & c1
                Else
                    Select Case pair
                        Case "RG"
                            newRow = newRow & "B"
                        Case "GR"
                            newRow = newRow & "B"
                        Case "RB"
                            newRow = newRow & "G"
                        Case "BR"
                            newRow = newRow & "G"
                        Case "BG"
                            newRow = newRow & "R"
                        Case "GB"
                            newRow = newRow & "R"

                    End Select
                End If
            Next
            Console.WriteLine(newRow)
            row = newRow
            Len = row.Length
        Loop

        Console.WriteLine(row)

        Console.ReadLine()


    End Sub

End Module
