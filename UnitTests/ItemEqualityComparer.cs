using System.Collections.Generic;
using Ingenio.CodeTest.Core.Data;

namespace Ingenio.CodeTest.UnitTests
{
    internal sealed class ItemEqualityComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item x, Item y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.CategoryId == y.CategoryId && x.ParentCategoryId == y.ParentCategoryId && string.Equals(x.Name, y.Name) && string.Equals(x.Keywords, y.Keywords);
        }

        public int GetHashCode(Item obj)
        {
            unchecked
            {
                int hashCode = obj.CategoryId;
                hashCode = (hashCode * 397) ^ obj.ParentCategoryId;
                hashCode = (hashCode * 397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.Keywords != null ? obj.Keywords.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}