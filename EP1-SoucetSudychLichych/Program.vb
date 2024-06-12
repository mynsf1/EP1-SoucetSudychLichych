Imports System

Module Program
    Sub Main()
        Dim pocetcisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Ahoj, kolik Ÿ¡sel chceç? ")
        Console.WriteLine()
        pocetcisel = Console.ReadLine
        Console.WriteLine()
        If IsNumeric(pocetcisel) = False Then
            'zde zjiçóujeme zdali je nebo nen¡ v objektu
            'svov no Ÿ¡slo
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba - nezadali jste Ÿ¡slo! ")
            Console.WriteLine()
            Console.ReadKey()
            Main()
        End If
        Dim cistecislo As Integer = pocetcisel
        If cistecislo <= 0 Then
            'zde zjiçóujeme je Ÿ¡slo nula
            'a mebo z porn‚
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba - nezadali jste kladn‚ Ÿ¡slo! ")
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
        Console.WriteLine("SouŸet sudìch je: " & soucetsudych)
        Console.WriteLine("SouŸet lychìch je: " & soucetlychych)
        Console.ReadKey()

    End Sub
End Module