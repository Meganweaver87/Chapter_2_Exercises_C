// See https://aka.ms/new-console-template for more information
// Write dog name-----------------------------------------------
Console.WriteLine("What is your dog's name?");
string dogName = Console.ReadLine();
Console.WriteLine("Hello " + dogName);

// Calculate rectangle area--------------------------------------
Console.WriteLine("Please enter the rectangle length:");
string rectLength = Console.ReadLine();
Console.WriteLine("Please enter the rectangle width:");
string rectWidth = Console.ReadLine();

int rectLengthInt = int.Parse(rectLength);
int rectWidthInt = int.Parse(rectWidth);
int rectArea = rectLengthInt * rectWidthInt;
Console.WriteLine("Rectangle area: " + rectArea);


// Calculate gas mileage----------------------------------------
Console.WriteLine("Please enter the miles driven:");
string miles = Console.ReadLine();
Console.WriteLine("Please enter the gas consumed:");
string gas = Console.ReadLine();

double intMiles = double.Parse(miles);
double intGas = double.Parse(gas);
double gasMileage = intMiles / intGas;
Console.WriteLine("Gas mileage: " + gasMileage);


// Find search term--------------------------------------------
string aliceExcerptOriginal = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
string aliceExcerpt = aliceExcerptOriginal.ToLower();

Console.WriteLine("Please enter a search term:");
string searchTermOriginal = Console.ReadLine();
string searchTerm = searchTermOriginal.ToLower();

Console.WriteLine(aliceExcerpt.Contains(searchTerm));
if (aliceExcerpt.Contains(searchTerm) == true)
    {
        int searchTermIndex = aliceExcerpt.IndexOf(searchTerm);
        Console.WriteLine("Index number: "+ searchTermIndex);
    }