Console.WriteLine("Веддiть своє число");
if (int.TryParse(Console.ReadLine(), out int number))
{
     Console.WriteLine($"Ви ввели число {number}");
}
else
{
    Console.WriteLine("Wrong Data");
}
