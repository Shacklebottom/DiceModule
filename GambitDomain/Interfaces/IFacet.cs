
namespace GambitDomain.Interfaces
{
    public interface IFacet
    {
        object Face { get; }

        bool Equals(IFacet other);
    }

    public interface IFacet<T> : IFacet where T : Enum
    {
        new T Face { get; }


    }
}