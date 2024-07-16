using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public People(string name)
        {
            Name = name;
        }
    }

    public class FindFiveMethod
    {
        private const int PERSONS_TO_RETURN = 5;
        public static IList<string> findfive(IList<People> persons)
        {
            var watchForParallel = Stopwatch.StartNew();
            var result = GetListWithParallel(persons);
            watchForParallel.Stop();
            return result;
        }

        private static IList<string> GetListWithParallel(IList<People> persons)
        {

            var result = new List<string>();
            CancellationTokenSource cts = new();
            // Use ParallelOptions instance to store the CancellationToken
            ParallelOptions options = new()
            {
                CancellationToken = cts.Token,
                MaxDegreeOfParallelism = Environment.ProcessorCount
            };
            Parallel.ForEach(persons, Person =>
            {
                if (Verify(Person.Name))
                    result.Add(Person.Name);
                if(result.Count == PERSONS_TO_RETURN)
                {
                    // Run a task so that we can cancel from another thread.
                    Task.Factory.StartNew(() =>
                    {
                        cts.Cancel();
                    });
                }
                    
            });

            return result;
        }
        private static bool Verify(string name)
        {
            return true;
        }
    }
}
