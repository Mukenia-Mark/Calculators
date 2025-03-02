from ast import Break


def add(x, y):
    return x + y

def subtract(x, y):
    return x - y

def multiply(x, y):
    return x * y

def divide(x, y):
    if y == 0:
        return "Error cannot divide by zero!"
    return x / y

def calculator():
    while True:

        print("Welcome to the Python Calculator!")
        print("Operations:")
        print("1. Addition (+)")
        print("2. Subtraction (-)")
        print("3. Multiplication (*)")
        print("4. Division (/)")

        choice = input("Enter the operation number (1/2/3/4) or 'exit': ")

        if choice == "exit":
            print("Exiting the calculator. Goodbye!")
            break

        if choice in ['1','2','3', '4']:
            try:
                num1 = float(input("Enter the first number: "))
                num2 = float(input("Enter the second number: "))
            except ValueError:
                print("Invalid input! Please enter numeric values.")
                continue

            if choice == '1':
                print(f"Result: {num1} + {num2} = {add(num1, num2)}")

            elif choice == '2':
                print(f"Result: {num1} - {num2} = {subtract(num1, num2)}")

            elif choice == '3':
                print(f"Result: {num1} * {num2} = {multiply(num1, num2)}")

            elif choice == '4':
                print(f"Result: {num1} / {num2} = {divide(num1, num2)}")

        else:
            print("Invalid input! Please select a valid operation.")

calculator()
