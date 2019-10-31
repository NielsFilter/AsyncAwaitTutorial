using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dasync.Collections;
using ExternalDependency;

namespace AsyncExamples
{
    public class YieldReturn
    {
        private readonly ExternalCall _ec;

        public YieldReturn(ExternalCall ec)
        {
            _ec = ec;
        }

        public async Task GoAsync()
        {
            var evenNums = GetEvenNumbers();
            foreach (var number in evenNums)
            {
                if (number > 100)
                {
                    break;
                }

                Console.WriteLine(number);
            }

            Console.WriteLine("Done");
        }

        public IEnumerable<int> GetEvenNumbers()
        {
            for (var i = 0; i <= 500_000_000; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}