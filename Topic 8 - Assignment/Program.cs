// See https://aka.ms/new-console-template for more information
Console.WriteLine("Reading in Colors");
Console.WriteLine();
Random generator = new Random();
List<string> colors = new List<string> { "Red", "Blue", "Yellow", "Green", "Orange" };
Console.WriteLine(string.Join(", ", colors));
Console.WriteLine();
Console.WriteLine("Here is a random color:");
Console.WriteLine(colors[generator.Next(colors.Count)]);
Console.WriteLine();

Console.WriteLine("Random Numbers");
int numberCount, numberMax, numberMin;
Console.WriteLine();
List<int> numbers = new List<int>();
Console.WriteLine("How many numbers do you need?");
Int32.TryParse(Console.ReadLine(), out numberCount);
Console.WriteLine("What is your maximum value?");
Int32.TryParse(Console.ReadLine(), out numberMax);
Console.WriteLine("What is your minimum value?");
Int32.TryParse(Console.ReadLine(), out numberMin);
for (int i = numberMin + 1; i < numberMax + 1; i++)
    numbers.Add(generator.Next(numberCount + 1));
Console.WriteLine(string.Join(", ", numbers));