using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class ProductBussiness : IDB<Product, string >
    {

        public void Create(Product item)
        {

            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    context.Products.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Product Read(string key)
        {

            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    return context.Products.Find(key);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Product> ReadAll()
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    return context.Products.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Product item)
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    Product productFromDB = context.Products.Find(item.Barcode);
                    context.Entry(productFromDB).CurrentValues.SetValues(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    Product productFromDB = context.Products.Find(key);
                    context.Products.Remove(productFromDB);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
