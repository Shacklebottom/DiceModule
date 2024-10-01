using GambitDomain.Enums;
using GambitDomain.Interfaces;
using GambitDomain.Objects;
using GambitDomain.Factories;

Console.WriteLine("turtles begin" + "\n");
#region NUMERICS
//var facets = new List<IFacet>();

//for (int i = 1; i < 5; i++)
//{
//    facets.Add(FacetFactory.CreateFacet((Numerics)i));
//}

//Die die = new(facets);
//var result = die.Roll();

//Console.WriteLine($"You rolled {result.Face}!");
#endregion


#region SYMBOLS
var facets = new List<IFacet>();

for (int i = 0; i < 5; i++)
{
    facets.Add(FacetFactory.CreateFacet(Symbols.Moon));
}
facets.Add(FacetFactory.CreateFacet(Symbols.Sun));

Die die = new(facets);
var result = die.RollResult;

Console.WriteLine($"You rolled the {result.Face}!");

if (result.Equals(new SymbolFacet { Face = Symbols.Sun}))
{
    Console.WriteLine("\n" + "You won! :)");
}
else
{
    Console.WriteLine("\n" + "You lost! :(");
}
#endregion

//var facets = new List<IFacet>();

//foreach (Numerics facet in Enum.GetValues(typeof(Numerics)))
//{
//    facets.Add(FacetFactory.CreateFacet(facet));
//}

//foreach (Symbols facet in Enum.GetValues(typeof(Symbols)))
//{
//    facets.Add(FacetFactory.CreateFacet(facet));
//}

//Die die = new(facets);
//var result = die.Roll();

//Console.WriteLine($"You rolled the {result.Face}!");


//Console.WriteLine("\n" + "turtles end");


