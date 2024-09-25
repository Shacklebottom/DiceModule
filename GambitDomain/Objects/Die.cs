using GambitDomain.Extensions;
using GambitDomain.Interfaces;

namespace GambitDomain.Objects
{
    public class Die(IEnumerable<IFacet> facets)
    {
        public IEnumerable<IFacet> Facets { get; set; } = facets;

        public IFacet Roll()
        {
            var facet = Facets.Randomize().First();

            return facet;
        }
    }
}