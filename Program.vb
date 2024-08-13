Imports System

Module Program
    Sub Main()
        Dim f As Double
        Console.WriteLine("ingresa el valor de tu frecuencia")
        f = Console.ReadLine
        Dim l As Double
        Console.WriteLine("ingresa el valor de tu inductor")
        l = Console.ReadLine
        Dim c As Double
        Console.WriteLine("ingresa el valor de tu capacitor")
        c = Console.ReadLine
        Dim r As Double
        Console.WriteLine("ingresa el valor de tu resistencia")
        r = Console.ReadLine
        Dim xl As Double
        xl = (2 * 3.1415 * f * l)
        Dim angxl As Double
        angxl = Math.Atan(xl / r)
        Dim xc As Double
        xc = (1 / (2 * 3.1415 * f * c))
        Dim angxc As Double
        angxc = Math.Atan(-xc / r)
        Dim z As Double
        z = Math.Sqrt(r ^ 2 + (xl - xc) ^ 2)
        Dim anguloz As Double
        anguloz = Math.Atan((xl - xc) / r)
        Dim f0 As Double
        f0 = (1 / (2 * 3.1415 * Math.Sqrt(l * c)))
        Dim X As Double
        X = (xl - xc)
        Console.WriteLine("el valor de xl es igual a: " & xl)
        Console.WriteLine("el angulo de xl es igual a: " & angxl)
        Console.WriteLine("el valor de xc es igual a: " & xc)
        Console.WriteLine("el angulo de xc es igual a: " & angxc)
        Console.WriteLine("tu impedancia total es: " & z)
        Console.WriteLine("x: " & X)
        Console.WriteLine("el angulo de tu impedancia total es: " & anguloz)
        Console.WriteLine("tu frecuencia de resonancia es igual a: " & f0)

    End Sub
End Module
