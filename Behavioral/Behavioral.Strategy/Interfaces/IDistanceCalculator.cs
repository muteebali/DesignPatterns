namespace Behavioral.Strategy.Interfaces
{
    internal interface IDistanceCalculator
    {
        //Params are just for example
        Task<double> CalculateAsync(int point1, int point2);
    }
}
