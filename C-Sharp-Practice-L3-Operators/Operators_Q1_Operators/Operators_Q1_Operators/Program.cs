// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//---------------------------------------------------------------------
// Part 1: Mathematical Operators
// Write a C# program to print the sum of two numbers.
// Hint: You can use the + operator to add two numbers.
// Test data: int num1 = 10, int num2 = 5
int num1 = 10;
int num2 = 5;
int sum = num1 + num2;
Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

//---------------------------------------------------------------------
// Part 2: Mathematical Operators
// Write a C# program to print the difference between two numbers.
// Hint: You can use the - operator to subtract two numbers.
// Test data: int num1 = 10, int num2 = 5
// int num1 = 10;
// int num2 = 5;
int difference = num1 - num2;
Console.WriteLine("The difference between " + num1 + " and " + num2 + " is: " + difference);


//---------------------------------------------------------------------
// Part 3: Mathematical Operators
// Write a C# program to print the product of two numbers.
// Hint: You can use the * operator to multiply two numbers.
// Test data: int num1 = 10, int num2 = 5
// int num1 = 10;
// int num2 = 5;
int product = num1 * num2;
Console.WriteLine("The product of " + num1 + " and " + num2 + " is: " + product);

//---------------------------------------------------------------------
// Part 4: Mathematical Operators
// Write a C# program to print the division of two numbers.
// Hint: You can use the / operator to divide two numbers.
// Test data: int num1 = 10, int num2 = 5
// int num1 = 10;
// int num2 = 5;
int division = num1 / num2;
Console.WriteLine("The division of " + num1 + " and " + num2 + " is: " + division);

//---------------------------------------------------------------------
// Part 5: Mathematical Operators
// Write a C# program to print the remainder of two numbers.
// Hint: You can use the % operator to find the remainder of two numbers.
// Test data: int num1 = 10, int num2 = 5
// int num1 = 10;
// int num2 = 5;
int remainder = num1 % num2;
Console.WriteLine("The remainder of " + num1 + " and " + num2 + " is: " + remainder);

//---------------------------------------------------------------------
// Part 6: Mathematical Operators
// Write a C# program to calculate the square of a number.
// Hint: You can use the * operator to multiply a number by itself.
// Test data: int num = 5
int num = 5;
int square = num * num;
Console.WriteLine("The square of " + num + " is: " + square);   

//---------------------------------------------------------------------
// Part 7: Mathematical Operators
// Write a C# program to calculate the average of two numbers.
// Hint: You can add the two numbers together and then divide the sum by 2 to find the average.
// Test data: int num1 = 10, int num2 = 20
int num3 = 10;
int num4 = 20;
int average = (num3 + num4) / 2;
Console.WriteLine("The average of " + num3 + " and " + num4 + " is: " + average);
//---------------------------------------------------------------------
// Part 8: Mathematical Operators
// Write a C# program to calculate the average of three numbers.
// Hint: You can add the three numbers together and then divide the sum by 3 to find the average.
// Test data: int num1 = 10, int num2 = 20, int num3 = 30
int num5 = 10;
int num6 = 20;
int num7 = 30;
int average3 = (num5 + num6 + num7) / 3;    
Console.WriteLine("The average of " + num5 + ", " + num6 + ", and " + num7 + " is: " + average3);

//---------------------------------------------------------------------
// Part 9: Mathematical Operators
// Write a C# program to convert temperature from Celsius to Fahrenheit.
// Hint: Use the formula (Celsius * 9/5) + 32.
// Test data: double celsius = 20
double _celsius = 25.4;
double _fahrenheit = (_celsius * 9 / 5) + 32;
Console.WriteLine("The temperature in Fahrenheit is: " + _fahrenheit);

//---------------------------------------------------------------------
// Part 10: Mathematical Operators
// Write a C# program to calculate the area of a rectangle given its length and width.
// Hint: Use the formula area = length * width.
// Test data: double length = 10, double width = 5
double _length = 10.5;
double _width = 5.0;
double _area = _length * _width;
Console.WriteLine("The area of the rectangle is: " + _area);

//---------------------------------------------------------------------
// Part 11: Mathematical Operators
// Write a C# program to calculate the volume of a sphere given its radius.
// Hint: Use the formula volume = (4/3) * Pi * radius^3.
// Test data: double radius = 5
double _radius = 5.0;
double _volume = (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
Console.WriteLine("The volume of the sphere is: " + _volume);

//---------------------------------------------------------------------
// Part 12: Mathematical Operators
// Write a C# program to calculate the factorial of a given integer.
// Hint: Use a loop to multiply the numbers from 1 to the given integer.
// Test data: int num = 5
int _num = 5;
int _factorial = 1;
for (int i = 1; i <= _num; i++)
{
    _factorial *= i;
}
Console.WriteLine("The factorial of " + _num + " is: " + _factorial);


//---------------------------------------------------------------------
// Part 13: Mathematical Operators
// Write a C# program to calculate the compound interest given the principal amount, interest rate, and time period.
// Hint: Use the formula A = P * (1 + r/n)^(nt).
// Test data: double principal = 1000, double rate = 0.05, int time = 5
double _principal = 1000.0;
double _rate = 0.05;    
int _time = 5;
double _amount = _principal * Math.Pow(1 + _rate, _time);
Console.WriteLine("The compound interest is: " + _amount);

//---------------------------------------------------------------------
// Part 14: Mathematical Operators
// Write a C# program to solve a quadratic equation of the form ax^2 + bx + c = 0.
// Hint: Use the quadratic formula.
// Test data: double a = 1, double b = 5, double c = 6
double _a = 2.1;
double _b = 10.6;    
double _c = 12.2;
double _discriminant = Math.Pow(_b, 2) - 4 * _a * _c;
if (_discriminant > 0)
{
    double _root1 = (-_b + Math.Sqrt(_discriminant)) / (2 * _a);
    double _root2 = (-_b - Math.Sqrt(_discriminant)) / (2 * _a);
    Console.WriteLine("The roots are: " + _root1 + " and " + _root2);
}
else if (_discriminant == 0)
{
    double _root = -_b / (2 * _a);
    Console.WriteLine("The root is: " + _root);
}
else
{
    Console.WriteLine("The equation has no real roots.");
}

//---------------------------------------------------------------------
// Part 15: Mathematical Operators
// Write a C# program to calculate the nth Fibonacci number using recursion.
// Hint: Use a recursive function to calculate Fibonacci numbers.
// Test data: int n = 8
int _n = 8;
int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
Console.WriteLine("The " + _n + "th Fibonacci number is: " + Fibonacci(_n));
//---------------------------------------------------------------------
// Part 16: Mathematical Operators
// Write a C# program to calculate the nth term of the arithmetic sequence given the first term, common difference, and term number.
// Hint: Use the formula nth term = first term + (n - 1) * common difference.
// Test data: int firstTerm = 3, int commonDifference = 2, int termNumber = 5
int _firstTerm = 3;
int _commonDifference = 2;
int _termNumber = 5;
int _nthTerm = _firstTerm + (_termNumber - 1) * _commonDifference;
Console.WriteLine("The " + _termNumber + "th term of the arithmetic sequence is: " + _nthTerm);



//---------------------------------------------------------------------
// Part 17: Relational Operators
// Write a C# program to check if a given number is greater than another number.
// Hint: Use the > operator to check if the first number is greater than the second number.
// Test data: int num1 = 10, int num2 = 5
int _num1 = 10;
int _num2 = 5;
if (_num1 > _num2)
{
    Console.WriteLine(_num1 + " is greater than " + _num2);
}
else
{
    Console.WriteLine(_num1 + " is not greater than " + _num2);
}




//---------------------------------------------------------------------
// Part 18: Relational Operators
// Write a C# program to check if a given number is less than or equal to 100.
// Prompt the user to enter a number and check if it is less than or equal to 100.
// Hint: Use the <= operator to check if the number is less than or equal to 100.
// Test data: Enter a number: 88
// Console.Write("Enter a number: ");
// int _inputNumber = int.Parse(Console.ReadLine());
// if (_inputNumber <= 100)
// {
//     Console.WriteLine(_inputNumber + " is less than or equal to 100.");
// }
// else
// {
//     Console.WriteLine(_inputNumber + " is not less than or equal to 100.");
// }


//---------------------------------------------------------------------
// Part 19: Logical Operators
// Write a C# program to check if a given number is even AND greater than 10.
// Prompt the user to enter a number and check if it satisfies both conditions.
// Hint: Use the % operator to check if the number is even, and the && operator to check both conditions.
// Test data: Enter a number: 16
// Console.Write("Enter a number: ");
// int _inputNum = int.Parse(Console.ReadLine());
// if (_inputNum % 2 == 0 && _inputNum > 10)
// {
//     Console.WriteLine(_inputNum + " is even and greater than 10.");
// }
// else
// {
//     Console.WriteLine(_inputNum + " does not satisfy both conditions.");
// }
//---------------------------------------------------------------------
// Part 20: Logical Operators
// Write a C# program to check if a given number is divisible by 3 OR 5.
// Prompt the user to enter a number and check if it is divisible by either 3 or 5.
// Hint: Use the % operator to check for divisibility, and the || operator to check either condition.
// Test data: Enter a number: 9
// Console.Write("Enter a number: ");
// int _inputNum2 = int.Parse(Console.ReadLine());
// if (_inputNum2 % 3 == 0 || _inputNum2 % 5 == 0)
// {
//     Console.WriteLine(_inputNum2 + " is divisible by 3 or 5.");
// }
// else
// {
//     Console.WriteLine(_inputNum2 + " is not divisible by 3 or 5.");
// }

//---------------------------------------------------------------------
// Part 21: Initialization and Assignment Operators
// Write a C# program to increment a variable by 5 using the shorthand assignment operator.
// Prompt the user to enter a number and increment it by 5 using the shorthand assignment operator.
// Hint: Use the += operator to increment the variable by 5.
// Test data: Enter a number: 7
// Console.Write("Enter a number: ");
// int _inputNum3 = int.Parse(Console.ReadLine());
// _inputNum3 += 5;
// Console.WriteLine("The number after incrementing by 5 is: " + _inputNum3);

//---------------------------------------------------------------------
// Part 22: Initialization and Assignment Operators
// Write a C# program to calculate the remainder when dividing a number by 7 and update the number using the %= operator.
// Initialize a variable 'number' with a value of 27, then calculate the remainder when dividing 'number' by 7 and update 'number' with the result.
// Hint: Use the %= operator to update the value of 'number' with the remainder of 'number' divided by 7.
// Test data: int number = 27
Console.Write("Enter a number: ");
int _number = int.Parse(Console.ReadLine());
_number %= 7;
Console.WriteLine("The remainder when dividing the number by 7 is: " + _number);

