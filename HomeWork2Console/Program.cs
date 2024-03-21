using System;

class Program
{
	static void Main()
	{
		// Declaration of three variables of type char
		char first = 'A';
		char second = 'B';
		char third = 'C';

		// Displaying variables in the original order
		Console.WriteLine("Original order:");
		Console.WriteLine("First variable: " + first);
		Console.WriteLine("Second variable: " + second);
		Console.WriteLine("Third variable: " + third);

		// Displaying variables in reverse order
		Console.WriteLine("\nReverse order:");
		Console.WriteLine("Third variable: " + third);
		Console.WriteLine("Second variable: " + second);
		Console.WriteLine("First variable: " + first);

		Console.ReadKey();
	}
}