using System;
using System.Collections;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Lists.ProductExample
{
    class Products : ICollection<Product>
    {
        public List<Product> ProdList = new List<Product>();
        public int Count
        {
            get { return ProdList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false;  }
        }

        public void Add(Product item)
        {
            ProdList.Add(item);
        }

        public void Clear()
        {
            ProdList.Clear();
        }

        public bool Contains(Product item)
        {
            return ProdList.Contains(item);
        }

        public void CopyTo(Product[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return ProdList.GetEnumerator();
        }

        public bool Remove(Product item)
        {
            return ProdList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SortList()
        {
            ProdList.Sort();
        }

        public Product GetProduct(int id)
        {
            Product product = null;
            foreach  (Product p in ProdList)
            {
                if (p.ProductNo.Equals(id))
                {
                    product = p;
                    break;
                }
            }
            return product;
        }

        public bool RemoveByID(int id)
        {
            Product prodDelete = GetProduct(id);
            bool removed = false;

            if (prodDelete != null)
            {
                ProdList.Remove(prodDelete);
                removed = true;
            }
            return removed;
        }

        public List<Product> GetInStockItems()
        {
            List<Product> inStockList = new List<Product>();

            foreach (Product p in ProdList)
            {
                if(p.InStock == true)
                {
                    inStockList.Add(p);
                }
            }

            return inStockList;
        }
    }
}
