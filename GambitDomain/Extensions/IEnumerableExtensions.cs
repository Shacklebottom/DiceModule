
namespace GambitDomain.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Randomizes the collection using the Fisher-Yates algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>the collection, but randomized</returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> collection)
        {
            var random = new Random();

            var result = collection.ToList();

            for (var i = 0; i < result.Count; i++)
            {
                var j = random.Next(i + 1);

                (result[i], result[j]) = (result[j], result[i]);
            }

            return result;
        }
    }
}
