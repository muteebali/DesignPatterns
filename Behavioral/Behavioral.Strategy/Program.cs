using Behavioral.Strategy.Implementation;
using Behavioral.Strategy.Interfaces;

IDistanceCalculator googleDistanceCalculator= new GoogleService();
DistanceCalculationContext googleContext= new DistanceCalculationContext(googleDistanceCalculator);
Console.WriteLine(await googleContext.Execute(1,2));

IDistanceCalculator osrmDistanceCalculator = new OsrmService();
DistanceCalculationContext osrmContext = new DistanceCalculationContext(osrmDistanceCalculator);
Console.WriteLine(await osrmContext.Execute(1, 2));

Console.WriteLine("Hello, World!");
