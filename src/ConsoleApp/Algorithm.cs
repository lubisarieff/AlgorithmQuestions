using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	public static class Algorithm
	{
		public static void TestOne(int maxNumbers)
		{
			for (int i = 1; i <= maxNumbers; i++)
			{
				Console.WriteLine(i);
				if (i % 3 == 0)
					Console.WriteLine("Fizz");
			
				if (i % 5 == 0)
					Console.WriteLine("Buzz");
				
				if (i % 3 == 0 && i%5 == 0)
					Console.WriteLine("FizzBuzz");
			}
		}

		public static int TestTwo(string s)
		{
			int result = -1;
			
			for (int i = 0; i < s.Length; i++)
			{
				for (int j = i + 1; j < s.Length; j++)
				{
					if (s[i] == s[j])
					{
						result = i;
						break;
					}
				}

				if (result != -1)
					break;
			}

			return result;
		}

		public static void TestThree(List<int> numbers)
		{
			int length = numbers.Count;
			int maximumNumber = 0;
			int indexMaximum = 0;

			for (int i = 0; i < length; i++)
			{
				if (numbers[i] > maximumNumber)
				{
					maximumNumber = numbers[i];
					indexMaximum = i;
				}
			}

			Swap(numbers, indexMaximum, 0);
			
			bool isSwap = false;
			for (int j = 1; j < length; j++)
			{
				isSwap = false;
				for (int index = 1; index < length - 1; index++)
				{
					if (numbers[index] > numbers[index + 1])
					{
						Swap(numbers, index, index + 1);
						isSwap = true;
					}
				}

				if (!isSwap)
					break;
			}
		}

		private static void Swap(List<int> numbers, int firstIndex, int secondIndex)
		{
			int temp = numbers[firstIndex];
			numbers[firstIndex] = numbers[secondIndex];
			numbers[secondIndex] = temp;
		}
	}
}
