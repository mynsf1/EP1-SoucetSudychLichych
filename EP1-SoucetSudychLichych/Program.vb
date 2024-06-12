Imports System

Module Program
    Sub Main()
        Dim pocetcisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Ahoj, kolik ��sel chce�? ")
        Console.WriteLine()
        pocetcisel = Console.ReadLine
        Console.WriteLine()
        If IsNumeric(pocetcisel) = False Then
            'zde zji��ujeme zdali je nebo nen� v objektu
            'svov�no ��slo
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba - nezadali jste ��slo! ")
            Console.WriteLine()
            Console.ReadKey()
            Main()
        End If
        Dim cistecislo As Integer = pocetcisel
        If cistecislo <= 0 Then
            'zde zji��ujeme je ��slo nula
            'a mebo z�porn�
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba - nezadali jste kladn� ��slo! ")
            Console.WriteLine()
            Console.ReadKey()
            Main()
        End If
        Dim nahoda As Integer
        Dim soucetsudych, soucetlychych As Double
        Console.Clear()
        For x = 1 To cistecislo
            nahoda = Rnd() * 1000
            Console.WriteLine(nahoda)
            If nahoda Mod 2 = 0 Then
                soucetsudych += nahoda
            Else
                soucetlychych += nahoda
            End If
        Next
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Sou�et sud�ch je: " & soucetsudych)
        Console.WriteLine("Sou�et lych�ch je: " & soucetlychych)
        Console.ReadKey()

    End Sub
End Module