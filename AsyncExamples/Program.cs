using System;
using System.Threading.Tasks;
using ExternalDependency;

namespace AsyncExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var ec = new ExternalCall();
            RunExamplesAsync(ec)
                .GetAwaiter()
                .GetResult();

            Console.WriteLine("APPLICATION CLOSING...");
            Console.Read();
        }

        private static async Task RunExamplesAsync(ExternalCall ec)
        {
            new FireAndForget(ec).Go();
            //await new ErrorHandling(ec).GoAsync();
            //await new ReturnWithoutAwaits(ec).GoAsync();
        }
    }
}