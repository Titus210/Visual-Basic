Public Class Calculator
    Public Shared Sub Main()
        Dim num1, num2 As Double
        Dim operation As Char

        Console.WriteLine("Calculator")
        Console.WriteLine("-----------------")

        Console.WriteLine("Enter first number:")
        num1 = GetNumberInput()

        Console.WriteLine("Enter second number:")
        num2 = GetNumberInput()

        Console.WriteLine("Enter operation (+, -, *, /):")
        operation = GetOperationInput()

        Dim result As Double = PerformOperation(num1, num2, operation)

        Console.WriteLine($"Result: {result}")
    End Sub

    Private Shared Function GetNumberInput() As Double
        Dim input As String = Console.ReadLine()
        Dim number As Double
        If Double.TryParse(input, number) Then
            Return number
        Else
            Console.WriteLine("Invalid input. Please enter a valid number:")
            Return GetNumberInput()
        End If
    End Function

    Private Shared Function GetOperationInput() As Char
        Dim input As String = Console.ReadLine()
        If input.Length = 1 AndAlso "+-*/".Contains(input(0)) Then
            Return input(0)
        Else
            Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /):")
            Return GetOperationInput()
        End If
    End Function

    Private Shared Function PerformOperation(ByVal num1 As Double, ByVal num2 As Double, ByVal operation As Char) As Double
        Dim result As Double
        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 <> 0 Then
                    result = num1 / num2
                Else
                    Console.WriteLine("Error: Cannot divide by zero!")
                    Environment.Exit(0)
                End If
            Case Else
                Console.WriteLine("Invalid operation!")
                Environment.Exit(0)
        End Select
        Return result
    End Function
End Class
