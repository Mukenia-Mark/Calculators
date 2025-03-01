Module Module1

    Sub Main()
        Dim choice As Integer
        Dim num1, num2, result As Double

        Do

            Console.WriteLine("Simple Calculator")
            Console.WriteLine("1. Addition")
            Console.WriteLine("2. Subtraction")
            Console.WriteLine("3. Multiplication")
            Console.WriteLine("4. Division")
            Console.WriteLine("5. Exit")
            Console.Write("Enter your choice (1-5): ")
            choice = Integer.Parse(Console.ReadLine())

            If choice >= 1 And choice <= 4 Then
                Console.Write("Enter the first number: ")
                num1 = Double.Parse(Console.ReadLine())

                Console.Write("Enter the second number: ")
                num2 = Double.Parse(Console.ReadLine())

                Select Case choice
                    Case 1
                        result = num1 + num2
                        Console.WriteLine($"Result: {num1} + {num2} = {result}")

                    Case 2
                        result = num1 - num2
                        Console.WriteLine($"Result: {num1} - {num2} = {result}")

                    Case 3
                        result = num1 * num2
                        Console.WriteLine($"Result: {num1} * {num2} = {result}")

                    Case 4
                        If num2 <> 0 Then
                            result = num1 / num2
                            Console.WriteLine($"Result: {num1} / {num2} = {result}")

                        Else
                            Console.WriteLine("Error: Cannot divide by zero!")
                        End If
                End Select

            ElseIf choice = 5 Then
                Console.WriteLine("Exiting the calculator. Goodbye!")

            Else
                Console.WriteLine("Invalid choice! Please select a valid option.")

            End If
            Console.WriteLine()

        Loop While choice <> 5
    End Sub

End Module
