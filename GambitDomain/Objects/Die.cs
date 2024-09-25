using GambitDomain.Extensions;
using GambitDomain.Interfaces;

namespace GambitDomain.Objects
{
    public class Die(List<IFacet> facets)
    {
        public List<IFacet> Facets { get; set; } = facets;

        public IFacet Roll()
        {
            var facet = Facets.Randomize().First();

            return facet;
        }
    }
}