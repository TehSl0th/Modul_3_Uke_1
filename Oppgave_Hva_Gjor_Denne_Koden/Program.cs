// See https://aka.ms/new-console-template for more information
var range = 250;
var counts = new int[range];
var totalCount = 0;
string text = "something";

while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    text = text.ToLower();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
        totalCount++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var percent = 100 * (double)counts[i] / totalCount;
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i] + " | " + percent.ToString("F2") + "%" );
        }
    }
    Console.WriteLine("Total count is: " + totalCount);
}
