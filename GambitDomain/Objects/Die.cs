using GambitDomain.Extensions;
using GambitDomain.Interfaces;
using System.Runtime.CompilerServices;

namespace GambitDomain.Objects
{
    public class Die(IEnumerable<IFacet> facets)
    {
        private readonly IEnumerable<IFacet> _facets = facets;

        public IFacet RollResult
        {
            get { return _facets.Randomize().First(); }
        }

        public IFacet Roll() => RollResult;

        public bool Equals(IFacet facet)
        {
            if (this == facet) return true;
            else return false;
        }
    }
}