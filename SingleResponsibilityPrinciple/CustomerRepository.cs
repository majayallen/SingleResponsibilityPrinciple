using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            try
            {
                // Add customer to Database 
            }
            catch (Exception e)
            {
                FileLogger.Log(e.ToString());
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
