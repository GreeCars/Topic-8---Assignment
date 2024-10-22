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
int numberCount, numberMax, numberMin, numberAppearance, count = 0, numberReplace;
Console.WriteLine();
List<int> numbers = new List<int>();
Console.WriteLine("How many numbers do you need?");
Int32.TryParse(Console.ReadLine(), out numberCount);
Console.WriteLine("What is your maximum value?");
Int32.TryParse(Console.ReadLine(), out numberMax);
Console.WriteLine("What is your minimum value?");
Int32.TryParse(Console.ReadLine(), out numberMin);

numberMax += 1;

for (int i = 0; i < numberCount; i++)
{
    numbers.Add(generator.Next(numberMin, numberMax));
}
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine();

Console.WriteLine("Pick a number within the range, then I can tell you how many times it appears");
Int32.TryParse(Console.ReadLine(), out numberAppearance);
for (int i = 0; i < numberCount; i++)
{
    if (numbers[i] == numberAppearance)
        count += 1;
}
Console.WriteLine("There are " + count + " instances of the number " + numberAppearance + ".");
Console.WriteLine();

Console.WriteLine("Give me a number, and I will replace all occurences of it with zero");
Int32.TryParse(Console.ReadLine(), out numberReplace);
for (int i = 0; i < numberCount; i++)
{
    if (numbers[i] == numberReplace)
        numbers[i] = 0;
}
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine();

Console.WriteLine("Convert all to zero");
for (int i = 0; i < numberCount; i++)
{
    numbers[i] = 0;
}
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine();

numbers.Clear();

Console.WriteLine("Generate new numbers");
for (int i = 0; i < numberCount; i++)
{
    numbers.Add(generator.Next(numberMin, numberMax));
}
Console.WriteLine(string.Join(", ", numbers));