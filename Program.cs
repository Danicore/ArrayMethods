using System;

namespace MidAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = {"Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat"};

            Console.WriteLine("Original Animals Array:");
            foreach (string animal in animals)
            {
                Console.Write(animal);
            }
            Console.WriteLine();

            /*Array.Sort Method*/

            Array.Sort(animals);

            Console.WriteLine("Array.Sort Animals Array:");
            foreach (string animal in animals)
            {
                Console.Write(animal);
            }
            Console.WriteLine();

            /*Array.Reverse Method*/

            Array.Reverse(animals);

            Console.WriteLine("Array.Reverse Animals Array:");
            foreach (string animal in animals)
            {
                Console.Write(animal);
            }
            Console.WriteLine();

            /*Array.Clear Method*/

            int[] integerArray = new int[] {4, 6, 8, 1, 3};

	        Console.WriteLine("Integer array before Array.Clear:");
	        foreach (int value in integerArray)
	        {
	            Console.Write(value);
	        }
            Console.WriteLine();

	        Array.Clear(integerArray, 0, integerArray.Length);

	        Console.WriteLine("Integer array after Array.Clear:");
	        foreach (int value in integerArray)
	        {
	            Console.Write(value);
	        }
            Console.WriteLine();

            /*array.IndexOf Method*/

            int[] arr = new int[10];
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
            arr[3] = 400;        
            arr[4] = 500;
            arr[5] = 600;       
            arr[6] = 700;
            arr[7] = 800;
            arr[8] = 900;
            arr[9] = 1000;
            int a = Array.IndexOf(arr, 800);
            Console.WriteLine("Array.IndexOf Method:");
            Console.WriteLine(a);
        }
    }
}
