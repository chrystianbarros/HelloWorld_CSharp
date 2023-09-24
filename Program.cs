//In this program file, I'm exposing some concepts that I've learned during Microsoft Learn sessions.
//variables and its types
using System.Globalization;

Console.WriteLine("\tSession: My first variables and its types.");

string myName = "Chrystian";
char nameInitial = 'c';
int myAge = 22;
decimal howTallAmI = 1.9M;
bool lastInfo = false;

Console.Write("Hello, my name is " + myName + " and I'm " + myAge  + " years old.");
Console.WriteLine(" My first name inital letter is " + nameInitial + ", as you can see. If you look my profile picture, maybe you'll think that I'm " + howTallAmI + " tall.");
Console.WriteLine("This is obviously " + lastInfo + ".");

//about var: this variable type indicates to the compiler that its type is implict in the value.
Console.WriteLine("\n\n\tSession: The VAR variable.");

var thisIsAString = "This is a String!"; //in this example, the varible var is telling the compiler that the type of variable used in it (String) is explicity the type it needs to compile.
Console.Write(thisIsAString);

//concatenate and interpolation: in these examples bellow, we have different ways to separate/organize the output using the \
Console.WriteLine("\n\n\tSession: Concatenate and Interpolation.");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("Path: C:\\repos\\MyCode\\Program.cs");

//exercise: Writing according to final text
Console.WriteLine("\n\n\tSession: Variables and text interpolation & writing exercises.");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");

//exercise: Writing using "@" literal
Console.WriteLine(@"Output Directory: c\repos\test\MyCode.cs
    Finished.");

//variables interpolation
string name = "Chrystian";
string greeting = "\nHello, nice to meet you!";
myName = $"My name is {name}. What's your name?";

Console.WriteLine(@$"{greeting} {myName}");

//Peforming basic numbers operations
Console.WriteLine("\n\n\tSession: Perform basic numbers operations");

int firstNumber = 1;
int secondNumber = 2;
Console.WriteLine(@$"In this output, I'm adding a first number ({firstNumber}) to a second number ({secondNumber}). The result is: {firstNumber + secondNumber}.");

Console.WriteLine("In the next lines, I'm performing different math operations with the same two numbers: 5 and 2.");
int sum = 5 + 2;
int difference = 5 - 2;
int product = 5 * 2;
int quotient = 5 / 2;
decimal decimalQuotient = 5m / 2;

Console.Write($"Sum: {sum}\t");
Console.Write($"Difference: {difference}\t");
Console.Write($"Product: {product}\t");
Console.Write($"Quotient: {quotient}\t");
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

Console.WriteLine("\nIn the next lines, I'm using increment operators to increase the value of the variable \"varNumber\".");

int varNumber = 0;
Console.Write($"\"varNumber\" variable first value: {varNumber}.\n");
Console.Write($"Using the \"varNumber = varNumber + 1\" operator. New value: {varNumber = varNumber + 1}.\n");
Console.Write($"Using the \"varNumber += 5\" operator (Attention: the last value of the variable was {varNumber}). New value: {varNumber += 5}.\n");
Console.WriteLine($"Using the \"++varNumber\" operator (Attention: the last value of the variable was {varNumber}). New value: {++varNumber}.");

Console.WriteLine($"\nIn the next line, I'm converting a temperature in Farenheit to Celsius.");

int tempFarenheit = 94;
decimal tempCelsius = (tempFarenheit - 32) * (5m / 9);
Console.Write($"Temperature in Farenheit: {tempFarenheit}.\tTemperature in Celsius: {tempCelsius}.");