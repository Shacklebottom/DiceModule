using GambitDomain.Enums;
using GambitDomain.Interfaces;

namespace GambitDomain.Objects
{
    public class NumericFacet : IFacet<Numerics>
    {
        public Numerics Face { get; set; }

        object IFacet.Face => Face;

        public bool Equals(IFacet other)
        {
            if (other.Face is not Numerics) return false;
            if (Face == (Numerics)other.Face) return true;
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