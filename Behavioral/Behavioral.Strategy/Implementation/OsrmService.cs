using Behavioral.Strategy.Interfaces;

namespace Behavioral.Strategy.Implementation
{
    internal class OsrmService : IDistanceCalculator
    {
        public Task<double> CalculateAsync(int point1, int point2)
        {
            Console.WriteLine("Calculating distance using OSRM Service...");
            return Task.FromResult(84.0); // Dummy distance
        }
    }
}
