using GambitDomain.Enums;
using GambitDomain.Interfaces;

namespace GambitDomain.Objects
{
    public class NumericFacet : IFacet<Numerics>
    {
        public Numerics Face { get; set; }

        object IFacet.Face => Face;
    }
}