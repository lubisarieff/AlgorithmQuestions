using System;
using System.Collections.Generic;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Algoritm Questions Number 1");
			TestOne();
			Console.WriteLine("Algoritm Questions Number 2");
			TestTwo();
			Console.WriteLine("Algoritm Questions Number 3");
			TestThree();
		}

		static void TestOne()
		{
			Algorithm.TestOne(100);
		}

		static void TestTwo()
		{
			string characterOne = "ABBA";
			string characterTwo = "ABBC";

			Console.WriteLine(characterOne[Algorithm.TestTwo(characterOne)]);
			Console.WriteLine(characterTwo[Algorithm.TestTwo(characterTwo)]);
		}

		static void TestThree()
		{
			List<int> numbers1 = new List<int>() { 
				1,3,13,12,2,5
			};
			List<int> numbers2 = new List<int>() {
				1,3,7,8,2,9
			};

			Algorithm.TestThree(numbers1);
			numbers1.ForEach(number => Console.Write($" {number}"));

			Console.WriteLine();

			Algorithm.TestThree(numbers2);
			numbers2.ForEach(number => Console.Write($" {number}"));
		}
	}
}
