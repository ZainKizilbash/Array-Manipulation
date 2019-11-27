Module Module1

    Sub Main()
        Dim arr(7), x As String
        Dim i As Integer
        Dim isfound As Boolean
        isfound = True
        i = 0
        x = " "
        For i = 1 To 7
            arr(i) = " "
        Next
        For i = 1 To 7
            Console.Write("Enter A Senence: ")
            x = Console.ReadLine
            arr(i) = x
            Console.WriteLine("Str" & " " & i & " " & x)
        Next
        For i = 1 To 7
            Console.Write("Search Name: ")
            x = Console.ReadLine
            If arr(i) = x Then
                isfound = False
            End If

Next
        If isfound = False Then
            Console.Write("Name Found" & " " & x)
        Else
            Console.Write("Not Found")



        End If
        Console.ReadKey()

       


    End Sub

End Module
