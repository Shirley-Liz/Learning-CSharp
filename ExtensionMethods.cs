using System.Collections.Generic;
using System.Linq;

namespace Learning_CSharp
{
   public static class ExtensionMethods
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> value)
        {
            return value != null && value.Any();
        }

        public static bool IsNotNullOrEmptyOrWhiteSpace(this string value)
        {
            return !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }

        public static bool IsNotNull(this object value)
        {
            return value != null;
        }
    }
}
