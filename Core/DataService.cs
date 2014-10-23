using System;
using System.Collections.Generic;
using System.Linq;
using Ingenio.CodeTest.Core.Data;

namespace Ingenio.CodeTest.Core
{
    public class DataService
    {
        private readonly ItemContainer _container;

        public DataService(ItemContainer container)
        {
            if (container == null) throw new ArgumentNullException("container");
            _container = container;
        }

        public Item GetItemWithKeywordByCategoryId(int categoryId)
        {
            Item found = _container.Items.FirstOrDefault(item => item.CategoryId == categoryId);
            if (found == null)
                return null;

            if (found.Keywords != null)
                return found;

            var parent = FindItemWithKeywordByCategoryId(categoryId);
            found.Keywords = parent.Keywords;

            return found;
        }

        public int[] GetCategoriesByLevel(int level)
        {
            return (from item in _container.Items where GetLevel(item.CategoryId) == level select item.CategoryId).ToArray();
        }

        private int GetLevel(int categoryId)
        { 
            Item found = _container.Items.FirstOrDefault(item => item.CategoryId == categoryId);
            if (found == null)
                return 0;
            if (found.ParentCategoryId == -1)
                return 1;

            return 1 + GetLevel(found.ParentCategoryId);
        }


        private Item FindItemWithKeywordByCategoryId(int categoryId)
        {
            if (categoryId == -1)
                return null;

            Item found = _container.Items.FirstOrDefault(item => item.CategoryId == categoryId);
            if (found == null)
                return null;

            if (found.Keywords != null)
                return found;

            return GetItemWithKeywordByCategoryId(found.ParentCategoryId);
        }
    }
}