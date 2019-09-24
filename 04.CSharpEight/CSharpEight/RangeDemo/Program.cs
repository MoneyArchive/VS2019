using System;

namespace RangeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                            // index from start    index from end
                "Item1",    // 0                   ^9
                "Item2",    // 1                   ^8
                "Item3",    // 2                   ^7
                "Item4",    // 3                   ^6
                "Item5",    // 4                   ^5
                "Item6",    // 5                   ^4
                "Item7",    // 6                   ^3
                "Item8",    // 7                   ^2
                "Item9"     // 8                   ^1
            };              // 9 (or words.Length) ^0

            //foreach (var item in words[1..5])
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"The last word is {words[^1]}");

            //Console.WriteLine(string.Concat(words[^2..^0]));

            //Console.WriteLine(string.Concat(words[..])); 
            //Console.WriteLine(string.Concat(words[..4])); 
            //Console.WriteLine(string.Concat(words[6..])); 

            Index a1 = 1;
            Index a4 = 4;
            //Console.WriteLine(string.Concat(words[a1..a4])); 
        }
    }
}
