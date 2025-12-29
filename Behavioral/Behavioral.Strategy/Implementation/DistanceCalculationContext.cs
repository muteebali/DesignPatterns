using Behavioral.Strategy.Interfaces;

namespace Behavioral.Strategy.Implementation
{
    internal class DistanceCalculationContext
    {
        private readonly IDistanceCalculator distanceCalculator;

        public DistanceCalculationContext(IDistanceCalculator distanceCalculator)
        {
            this.distanceCalculator = distanceCalculator;
        }

        public async Task<double> Execute(int point1, int point2)
        {
            return await distanceCalculator.CalculateAsync(point1,point2);
        }
    }
}
