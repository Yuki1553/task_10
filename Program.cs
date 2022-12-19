// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого
Console.Clear();


Console.WriteLine("Enter a three-digit number: ");
string? n = Console.ReadLine();

Console.WriteLine(Convert.ToInt32(n[1].ToString()));
