using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalDependency
{
    public class ExternalCall
    {
        public async Task<int> GetLuckyNumberAsync()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Calculating lucky number...");
                await Task.Delay(1000);
            }

            return new Random().Next(0, 100);
        }

        public int GetLuckyNumber()
        {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine("Calculating lucky number...");
                    Thread.Sleep(1000);
                }

                return new Random().Next(0, 100);
        }

        public async Task WorkHardAsync(int iterations = 5)
        {
            for (var i = 0; i < iterations; i++)
            {
                Console.WriteLine("Some gnarly work...");
                await Task.Delay(1000);
            }
        }
    }
}