using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseePortal.Common.Extensions
{
    public static class CommonExtensions
    {
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }

        public static T ConvertToFlag<T>(this IEnumerable<T> flags) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new NotSupportedException($"{typeof(T)} must be an enumerated type");

            return (T)(object)flags.Cast<int>().Aggregate(0, (c, n) => c |= n);
        }

        public static T ConvertToFlag<T>(this IEnumerable<string> flags) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new NotSupportedException($"{typeof(T)} must be an enumerated type");

            List<T> enums = new List<T>();
            foreach (var flag in flags) enums.Add((T)Enum.Parse(typeof(T), flag.Trim()));

            return ConvertToFlag<T>(enums);
        }
    }
}
