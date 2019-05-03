Imports System.Text

Module Module1
    Public Random As New Random
    Public UserInput As String
    Sub Main()
        Console.WriteLine("Welcome to Rock Paper Scissors!" & vbCrLf & "Please enter either: Rock, Paper or Scissors now.")
        Dim UserInput As String = vbNull
        Dim UserInputValid As Boolean = False
        While UserInputValid = False
            UserInput = UppercaseFirstLetter(Console.ReadLine)
            If UserInput = "Rock" Or UserInput = "Paper" Or UserInput = "Scissors" Then
                UserInputValid = True
                Exit While
            End If
            Console.WriteLine("That was not a valid input, try again.")
        End While
        Console.Clear()
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
                Throw New ArgumentException("Exception Occured")
        End Select
    End Function
    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function
End Module
