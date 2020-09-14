'Calvin Coxen
'RCET0265
'Fall 2020
'Fortune Cookie
'https://github.com/CalvinAC/FortuneCookie/blob/master/FortuneCookie.vb

Option Explicit On
Option Strict On
Option Compare Text


Module FortuneCookie

    Sub Main()
        'This section of code creates variables from the user to end program and from the random muber generator
        'for displaying a message, also displays instructions for the user
        Dim randomNum As Integer
        Dim userInput As String
        Console.WriteLine("Hit enter to recieve a fortune. Select q to stop getting fortunes")

        ' A while loop that takes the numbers 1-3 generated and assigns them to a "fortune" that will be displayed
        'everytime the user hits enter. 
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
    'This function generates a random number between 1 and 3, and returns it to the main sub
    'to be used for displaying a fortune.
    Function GetRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim number As Single
        Randomize()
        number = CInt(Int(3 * Rnd()) + 1)
        number = ((max - min + 1) * Rnd()) + min
        Return CInt((number))
    End Function

End Module
