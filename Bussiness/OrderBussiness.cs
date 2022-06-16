using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class OrderBussiness : IDB<Order, int>
    {
        public void Create(Order item)
        {


            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    context.Orders.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Order Read(int key)
        {


            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    return context.Orders.Find(key);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Order> ReadAll()
        {
            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    return context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Order item)
        {

            try
            {
                using (BookStoreDbContext context = new BookStoreDbContext())
                {
                    Order orderFromDB = context.Orders.Find(item.Id);
                    context.Entry(orderFromDB).CurrentValues.SetValues(item);
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
                    Order orderFromDB = context.Orders.Find(key);
                    context.Orders.Remove(orderFromDB);
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
