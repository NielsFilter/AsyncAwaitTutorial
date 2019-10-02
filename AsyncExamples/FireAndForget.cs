using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExternalDependency;

namespace AsyncExamples
{
    public class FireAndForget
    {
        private Task _go;
        private readonly ExternalCall _ec;

        public FireAndForget(ExternalCall ec)
        {
            _ec = ec;
        }

        public void Go()
        {
            Console.WriteLine("Preparing to work hard...");

            _ec.WorkHardAsync();

            Console.WriteLine("DONE!!!! Earned yourself a cold one");
        }

        public async Task HighFiveTeamAsync()
        {
            Console.WriteLine("Gathering team mates");
            await Task.Delay(500);

            var teamMates = new List<string>()
            {
                "Hein",
                "Johann",
                "Luvi",
                "Phil",
                "Thys",
                "Theunis",
                "Diana"
            };
        }

        private async Task GiveHighFiveAsync(string person)
        {
            Console.WriteLine("Aim...");
            await Task.Delay(2000);
            Console.WriteLine("High Five {0}", person);
            await Task.Delay(1000);
        }
    }
}