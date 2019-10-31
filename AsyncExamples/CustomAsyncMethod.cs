using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExternalDependency;

namespace AsyncExamples
{
    public class CustomAsyncMethod
    {
        private readonly ExternalCall _ec;

        public CustomAsyncMethod(ExternalCall ec)
        {
            _ec = ec;
        }

        public async Task GoAsync()
        {
            Console.WriteLine("Delay and then execute");
            StartActionDelayed(5000, () => Console.WriteLine("Done waiting. Doing something now...") );
        }

        public void StartActionDelayed(int delay, Action action)
        {
            Thread.Sleep(delay);
            action();
        }
    }
}
