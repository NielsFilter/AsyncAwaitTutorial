using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalDependency;

namespace AsyncExamples
{
    class ErrorHandling
    {
        private readonly Task _task;
        private readonly ExternalCall _ec;

        public ErrorHandling(ExternalCall ec)
        {
            _ec = ec;
        }

        public async Task GoAsync()
        {
            try
            {
                await BreakSomeRulesAsync();
            }
            catch (InvalidLuckyNumberException e)
            {
                Console.WriteLine("Relax! I've got this");
            }

            Console.WriteLine("We're DONE here!");
        }

        public async Task BreakSomeRulesAsync()
        {
            var luckyNumber = await _ec.GetLuckyNumberAsync();
            if (luckyNumber != 7)
            {
                throw new InvalidLuckyNumberException();
            }

            Console.WriteLine("Good to go...");
        }

        
        public void SyncMethod()
        {
            _ec.WorkHardAsync().Wait();
        }
    }

    internal class InvalidLuckyNumberException : Exception
    {
    }
}