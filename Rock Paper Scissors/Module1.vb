Module Module1
    Public Random As New Random
    Sub Main()
        Console.WriteLine("Welcome to Rock Paper Scissors!" & vbCrLf & "Please enter either: Rock, Paper or Scissors now.")
        Dim UserInput As String = Console.ReadLine()
        If UserInput <> "Rock" And UserInput <> "Paper" And UserInput <> "Scissors" Then
            Dim UserInputValid As Boolean = False
            While UserInputValid = False
                Console.WriteLine("That was not a valid input, try again.")
                UserInput = Console.ReadLine()
                If UserInput <> "Rock" And UserInput <> "Paper" And UserInput <> "Scissors" Then
                Else
                    UserInputValid = True
                End If
            End While
        End If
        Dim AIInput As String = AI()
        Console.Write(String.Format("You picked: {0}{1}The computer picked: {2}{1}", UserInput, Environment.NewLine, AIInput))
        If UserInput = AIInput Then
            Console.WriteLine("It's a draw.")
        End If
        If UserInput = "Rock" And AIInput = "Scissors" Then
            Console.WriteLine("The Rock smashes the Scissors. The player wins!")
        End If
        If UserInput = "Paper" And AIInput = "Rock" Then
            Console.WriteLine("The paper wraps around the rock. The player wins!")
        End If
        If UserInput = "Scissors" And AIInput = "Paper" Then
            Console.WriteLine("The Scissors cut through the Paper. The player wins!")
        End If
        If AIInput = "Rock" And UserInput = "Scissors" Then
            Console.WriteLine("The Rock smashes the Scissors. The AI wins!")
        End If
        If AIInput = "Paper" And UserInput = "Rock" Then
            Console.WriteLine("The paper wraps around the rock. The AI wins!")
        End If
        If AIInput = "Scissors" And UserInput = "Paper" Then
            Console.WriteLine("The Scissors cut through the Paper. The AI wins!")
        End If
        Console.ReadLine()
    End Sub
    Function AI()
        Select Case Random.Next(0, 3)
            Case 0
                Return "Rock"
            Case 1
                Return "Paper"
            Case 2
                Return "Scissors"
            Case Else
                Return "Failed"
        End Select
    End Function
End Module
