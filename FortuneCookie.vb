'Calvin Coxen
'RCET0265
'Fall 2020
'Fortune Cookie

Option Explicit On
Option Strict On
Option Compare Text


Module FortuneCookie

    Sub Main()
        Dim randomNum As Integer
        Dim userInput As String

        Console.WriteLine("Hit enter to recieve a fortune. Select q to stop getting fortunes")
        Do

            randomNum = GetRandomNumber(1, 2)
                userInput = Console.ReadLine()

                If randomNum = 1 Then
                    Console.WriteLine("Halt! You have violated the law, pay your quater fine or serve your sentence!")

                ElseIf randomNum = 2 Then
                    Console.WriteLine("I used to be an adventurer like you, unitl I took an arrow to the knee.")

                ElseIf randomNum = 3 Then
                    Console.WriteLine("You know, PO-TAY-TOES! Boil 'em, Mash 'em, Stick 'em in a stew!")
                End If

            If userInput = "q" Then
                Exit Sub

            End If
        Loop


    End Sub

    Function GetRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim number As Single
        Randomize()
        number = CInt(Int(3 * Rnd()) + 1)
        number = ((max - min + 1) * Rnd()) + min
        Return CInt((number))
    End Function

End Module
