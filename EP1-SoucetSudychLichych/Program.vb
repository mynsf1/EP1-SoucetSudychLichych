Imports System

Module Program
    Sub Main(args As String())
        Dim pocetcisel As Integer
        Dim cislo As String


        Console.WriteLine(" Zadejte po�et ��sel:")
        Console.ReadLine()

        If Integer.TryParse(cislo, pocetcisel) Then

            For i As Integer = 1 To pocetcisel
                Console.WriteLine($" Zadejte ��slo {i}:")
                cislo = Console.ReadLine

            Next

        Else
            Console.WriteLine("Neplatn� hodnota. Zadejte pros�m cel� ��slo.")
        End If
    End Sub
End Module
