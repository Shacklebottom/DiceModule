using GambitDomain.Interfaces;
using GambitDomain.Enums;

namespace GambitDomain.Objects
{
    public class SymbolFacet : IFacet<Symbols>
    {
        public Symbols Face { get; set; }

        object IFacet.Face => Face;
    }
}