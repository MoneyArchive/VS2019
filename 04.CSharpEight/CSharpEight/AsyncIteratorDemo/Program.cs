using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncIteratorDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Demo();
        }

        public static async Task Demo()
        {
            await foreach (var number in GenerateNum())
            {
                Console.WriteLine($"Time: {DateTime.Now:HH:mm:ss}. Get: {number}");
            }
        }

        static async IAsyncEnumerable<int> GenerateNum()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 10 == 0)
                    await Task.Delay(5000);
                yield return i;
            }
        }
    }
}
