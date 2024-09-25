using GambitDomain.Enums;
using GambitDomain.Interfaces;
using GambitDomain.Objects;
using GambitDomain.Factories;

Console.WriteLine("turtles begin" + "\n");

var facets = new List<IFacet>();

for (int i = 0; i < 5; i++)
{
    facets.Add(FacetFactory.CreateFacet(Symbols.Moon));
}
facets.Add(FacetFactory.CreateFacet(Symbols.Sun));

Die die = new(facets);
var result = die.Roll();

Console.WriteLine($"You rolled the {result.Face}!");

if ((Symbols)result.Face == Symbols.Sun)
{
    Console.WriteLine("\n" + "You won! :)");
}
else
{
    Console.WriteLine("\n" + "You lost! :(");
}

Console.WriteLine("\n" + "turtles end");