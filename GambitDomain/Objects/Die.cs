using GambitDomain.Extensions;
using GambitDomain.Interfaces;

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
    }
}