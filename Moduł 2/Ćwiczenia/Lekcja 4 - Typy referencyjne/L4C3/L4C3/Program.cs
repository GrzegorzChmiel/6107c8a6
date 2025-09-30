// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start");
Console.WriteLine();

float length = 10.0f;
float width = 5.0f;
double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));

Console.WriteLine("Parametry prostokata:");
Console.WriteLine($"Dlugosc: {length}");
Console.WriteLine($"Szerokosc: {width}");
Console.WriteLine($"Przekatna: {diagonal}");

Console.WriteLine();
Console.WriteLine("Stop");