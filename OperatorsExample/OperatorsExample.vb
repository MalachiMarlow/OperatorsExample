'Malachi Marlow
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/MalachiMarlow/OperatorsExample.git

Option Compare Text

Module OperatorsExample

    Sub Main()

        'sum operator
        Console.Write("5 + 3 = ") 'print the string
        Console.WriteLine(5 + 3) 'print the sum
        Console.WriteLine()

        'difference operator
        Console.Write("5 - 3 = ") 'print the string
        Console.WriteLine(5 - 3) 'print the difference
        Console.WriteLine()

        'multiplication operator
        Console.Write("5 * 3 = ") 'print the string
        Console.WriteLine(5 * 3) 'print the product
        Console.WriteLine()

        'floating point division operator
        Console.Write("5 / 3 = ") 'print the string
        Console.WriteLine(5 / 3) 'print the floating point quotient
        Console.WriteLine()

        'multiplication operator
        Console.Write("3 * 1.66666666666667 = ") 'print the string
        Console.WriteLine(3 * 1.66666666666667) 'print the product
        Console.WriteLine()

        'interger division operator
        Console.Write("5 \ 3 = ") 'print the string
        Console.WriteLine(5 \ 3) 'print the quotient
        Console.WriteLine()

        'modulus operator
        Console.Write("5 mod 3 = ") 'print the string
        Console.WriteLine(5 Mod 3) 'print the remainder
        Console.WriteLine()

        'exponent operator
        Console.Write("5 ^ 3 = ") 'print the string
        Console.WriteLine(5 ^ 3) 'print exponent
        Console.WriteLine()

        'concatenation operator
        Console.Write("5" & " " & " + " & " 3 " & " = " & " 8 ") 'print the string
        Console.WriteLine()
        Console.WriteLine("wake up samurai..." & vbNewLine & "We got a city to burn...")
        Console.WriteLine(StrDup(10, "Ω"))

        'compare
        Console.Write("5 > 3 = ") 'print a string
        Console.WriteLine(5 > 3)
        Console.WriteLine()

        'compare
        Console.Write("5 < 3 = ") 'print a string
        Console.WriteLine(5 < 3)
        Console.WriteLine()

        'compare
        Console.Write("does 5 = 3 ? ") 'print a string
        Console.WriteLine(5 = 3)
        Console.WriteLine()

        Console.Write("is 5 not equal to 3? ") 'print a string
        Console.WriteLine(5 <> 3)
        Console.WriteLine()

        Console.Write("A > B = ") 'print a string
        Console.WriteLine("A" > "B")
        Console.WriteLine()

        Console.Write("is " & Chr(34) & "A" & Chr(34) & "the same as " & "a" & " ") 'print a string
        Console.WriteLine("A" = "a")
        Console.WriteLine()


    End Sub

End Module
