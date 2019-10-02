using System;
using System.Threading.Tasks;
using ExternalDependency;

namespace AsyncExamples
{
    class ReturnWithoutAwaits
    {
        private readonly ExternalCall _ec;

        public ReturnWithoutAwaits(ExternalCall ec)
        {
            _ec = ec;
        }

        public async Task GoAsync()
        {
            await DoStuffAsync();
        }

        public Task DoStuffAsync()
        {
            var worker = new SomeWorker(_ec);
            return worker.WorkAsync();
        }

        public class SomeWorker : IDisposable
        {
            private readonly ExternalCall _ec;

            public SomeWorker(ExternalCall ec)
            {
                _ec = ec;
            }

            public Task WorkAsync()
            {
                Console.WriteLine("Doing stuff...");
                return AnotherMethodAsync();
            }

            private Task AnotherMethodAsync()
            {
                Console.WriteLine("Quick work here...");
                return _ec.WorkHardAsync();
            }

            public void Dispose()
            {
                Console.WriteLine("Disposing stuff");
            }
        }
    }
}