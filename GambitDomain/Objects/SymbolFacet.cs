using GambitDomain.Interfaces;
using GambitDomain.Enums;

namespace GambitDomain.Objects
{
    public class SymbolFacet : IFacet<Symbols>
    {
        public Symbols Face { get; set; }

        object IFacet.Face => Face;

        public bool Equals(IFacet other)
        {
            if (other.Face is not Symbols) return false;
            if (Face == (Symbols)other.Face) return true;
            else return false;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return Equals((IFacet)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}