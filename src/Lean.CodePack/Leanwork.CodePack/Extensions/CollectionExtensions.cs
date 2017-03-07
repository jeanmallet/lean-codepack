using System;
using System.Collections.Generic;
using System.Linq;

namespace Leanwork.CodePack
{
    public static class CollectionExtensions
    {
        public static bool FindAndRemove<T>(this ICollection<T> collection, Func<T, bool> predicate)
        {
            var item = collection.FirstOrDefault(predicate);
            if (item != null)
                return collection.Remove(item);

            return false;
        }
    }
}
