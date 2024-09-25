using GambitDomain.Enums;
using GambitDomain.Interfaces;
using GambitDomain.Objects;
using GambitDomain.Factories;

Console.WriteLine("turtles begin" + "\n");


var facets = new List<IFacet>();

foreach (Numerics facet in Enum.GetValues(typeof(Numerics)))
{
    facets.Add(FacetFactory.CreateFacet(facet));   
}

foreach (Symbols facet in Enum.GetValues(typeof(Symbols)))
{
    facets.Add(FacetFactory.CreateFacet(facet));
}

Die die = new(facets);


var result = die.Roll();

Console.WriteLine($"{result.Face}");

Console.WriteLine("\n" + "end turtles");


