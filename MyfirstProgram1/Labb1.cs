// Esbjörn Holmerin Nord, NET25

// Create an int with a number
int number = 5;

// Checks if the number is bigger than 10 and respond accordingly
if (number > 10)
{
    Console.WriteLine("Talet är stort!");
}
else
{
    Console.WriteLine("Oj. Lågt tal!");
}

string input = "x";

// Reads what a user inputs and stores it in a string variable.
// The do while loop makes sure that the user ctually inputs a something to avoid a null value
do
{
    Console.WriteLine("Vad heter du?");
    input = Console.ReadLine();

    if (input == null || input.Length < 1)
    {
        Console.WriteLine("Du behöver inte använda ditt riktiga namn, men skriv något iaf.");
    }
}
while (input == null || input.Length < 1);

// Greets the user with their input name
Console.WriteLine("Hej " + input);


// Prints every number from 0 to the number arbitrarily decided at the start of the program
for (int i = 0; i <= number; i++)
{
    Console.WriteLine(i);
}
