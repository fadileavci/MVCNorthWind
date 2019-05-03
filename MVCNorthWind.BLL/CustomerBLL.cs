using MVCNorthWind.DAL;
using MVCNorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNorthWind.BLL
{
   public class CustomerBLL
    {

        public static NorthWindDbContext db = new NorthWindDbContext();
        public  static List<Customer> GetCustomer()
        {

            return db.Customers.ToList();

            
        }

        public static Customer GetCustomerDetail(string CusID)
        {

            return db.Customers.Where(x => x.CustomerID == CusID).FirstOrDefault();
        }


        public static int DeleteCustomer(string CusID)
        {
            var deleted = db.Customers.Where(x => x.CustomerID == CusID).FirstOrDefault();
            db.Customers.Remove(deleted);
            return db.SaveChanges();


        }
    }
}
