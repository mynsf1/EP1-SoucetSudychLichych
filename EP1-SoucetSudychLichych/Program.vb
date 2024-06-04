Imports System

Module Program
    Sub Main(args As String())
        Dim pocetcisel As Integer
        Dim cislo As String


        Console.WriteLine(" Zadejte poèet èísel:")
        Console.ReadLine()

        If Integer.TryParse(cislo, pocetcisel) Then

            For i As Integer = 1 To pocetcisel
                Console.WriteLine($" Zadejte èíslo {i}:")
                cislo = Console.ReadLine

            Next

        End If
    End Sub
End Module
