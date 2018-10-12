using System;
using System.Collections;
using System.Collections.Generic;


namespace dbs.ObjectOrientatedProgramming.Lists.TryListsLists
{

    class Products : ICollection<Product>
    {
        public List<Product> ProductList = new List<Product>();
        public int Count
        {
            get { return ProductList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Product item)
        {
            ProductList.Add(item);
        }

        public void Clear()
        {
            ProductList.Clear();
        }

        public bool Contains(Product item)
        {
            return ProductList.Contains(item);
        }

        public void CopyTo(Product[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Product> GetEnumerator() //It wil allow you to iterate through your a list that is already create
        {
            return ProductList.GetEnumerator();
        }

        public bool Remove(Product item)
        {
            return ProductList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //We can creae our own methods

        public void SortList()
        {
            ProductList.Sort();
        }

        public bool RemoveByID(int id)
        {
            Product productDelete = GetProduct(id);
            bool removed = false;

            if (productDelete != null)
            {
                ProductList.Remove(productDelete);
                removed = true;
            }

            return removed;
        }

        public Product GetProduct(int id)
        {
            Product prod = null; //Item you have create e.g you have to send back something 

            foreach (Product product in ProductList) // alternate to the is if(product.ProductNo == id)
            {
                if (product.ProductNo.Equals(id))
                {
                    prod = product;
                    break;
                }

            }

            return prod;
        }

        //We are going to include things that are in store

        public List<Product> GetInStockItems() //The return type is List<Product>
        {
            List<Product> InStockList = new List<Product>();

            foreach (Product productitem in ProductList)
            {
                if (productitem.InStock == true)
                {
                    InStockList.Add(productitem);
                }
            }

            return InStockList;
        }
    }
}
