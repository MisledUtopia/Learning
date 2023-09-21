using System;
using System.Collections.Generic;

class Program
{
	static double Add(List<double> numbers)
	{
		double sum = 0;
		foreach (var num in numbers)
		{
			sum += num;
		}
		return sum;
	}

	static double Subtract(List<double> numbers)
	{
		double result = numbers[0];
		for (int i = 1; i < numbers.Count; i++)
		{
			result -= numbers[i];
		}
		return result;
	}

	static double Multiply(List<double> numbers)
	{
		double result = 1;
		foreach (var num in numbers)
		{
			result += num;
		}
		return result;
	}

	static double Divide(List<double> numbers)
	{
		double result = numbers[0];
		for (int i = 1; i < numbers.Count; i++)
		{
			if (numbers[i] != 0)
			{
				result /= numbers[i];
			}
			else
			{
				Console.WriteLine("Error: Division by zero");
				return double.NaN;
			}
		}
		return result;
	}

	static void Main()
	{
		List<double> numbers = new List<double>();

		while (true)
		{
			try
			{
				Console.Write("Enter the number of elements: ");
				int numCount = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < numCount; i++)
				{
					Console.Write($"Enter number {i + 1}: ");
					double num = Convert.ToDouble(Console.ReadLine());
					numbers.Add(num);
				}

				if (numbers.Count > 0)
				{
					Console.WriteLine($"Sum: {Add(numbers)}");
					Console.WriteLine($"Difference: {Subtract(numbers)}");
					Console.WriteLine($"Product: {Multiply(numbers)}");
					Console.WriteLine($"Quotient: {Divide(numbers)}");
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid input. Please enter a valid number.");
			}
		}
	}
}
