//In this program file, I'm exposing some concepts that I've learned during Microsoft Learn sessions.
//variables and its types
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