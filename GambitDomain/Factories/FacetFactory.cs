using GambitDomain.Interfaces;
using GambitDomain.Enums;
using GambitDomain.Objects;


namespace GambitDomain.Factories
{
    public static class FacetFactory
    {
        public static IFacet<T> CreateFacet<T>(T facet) where T : Enum
        {
            return facet switch
            {
                Numerics numeric when typeof(T) == typeof(Numerics) => (IFacet<T>)(object)new NumericFacet() { Face = numeric },

                Symbols symbol when typeof(T) == typeof(Symbols) => (IFacet<T>)(object)new SymbolFacet() { Face = symbol },
                
                _ => throw new NotImplementedException($"{typeof(T)} has not been implemented, ya goof!")
            };
        }
    }
}
