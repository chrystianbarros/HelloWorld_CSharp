//In this program file, I'm exposing some concepts that I've learned during Microsoft Learn sessions.
/*
variables and its types
string myName = "Chrystian";
char nameInitial = 'c';
int myAge = 22;
decimal howTallAmI = 1.9M;
bool lastInfo = false;
*/

/*
about var: this variable type indicates to the compiler that its type is implict in the value.
var thisIsAString = "This is a String!";
Console.Write(thisIsAString);
*/

//concatenate and interpolation
/*
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("Path: C:\\repos\\MyCode\\Program.cs");
*/

//exercise: Writing according to final text
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");

//exercise: Writing using "@" literal
Console.WriteLine(@"Output Directory: c\repos\test\MyCode.cs
    Finished.");

//variables interpolation
string name = "Chrystian";
string greeting = "Hello, nice to meet you!";
string myName = $"My name is {name}. What's your name?";

Console.WriteLine(@$"{greeting} {myName}");