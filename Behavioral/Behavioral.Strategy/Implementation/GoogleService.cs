using Behavioral.Strategy.Interfaces;

namespace Behavioral.Strategy.Implementation
{
    internal class GoogleService : IDistanceCalculator
    {
        public Task<double> CalculateAsync(int point1, int point2)
        {
            Console.WriteLine("Calculating distance using Google Service...");
            return Task.FromResult(42.0); // Dummy distance
        }
    }
}
