using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class CustomerBussiness : IDB<Customer, int>
    {
        public void Create(Customer item)
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    context.Customers.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer Read(int key)
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    return context.Customers.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Customer item)
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    Customer customerFromDB = context.Customers.Find(item.Id);

                    context.Entry(customerFromDB).CurrentValues.SetValues(item);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    Customer customerFromDB = context.Customers.Find(key);

                    context.Customers.Remove(customerFromDB);
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
