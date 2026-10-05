Console.WriteLine("Hello C#");
Console.WriteLine();

Console.WriteLine("Name: Onur Erbekte");
Console.WriteLine("Department: Computer Engineering");
Console.WriteLine("Year: 2nd year");
Console.WriteLine();

Console.WriteLine("Current date and time: " + DateTime.Now);
Console.WriteLine();

Console.Write("Enter temperature in Celsius: ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"{celsius} °C = {fahrenheit} °F");