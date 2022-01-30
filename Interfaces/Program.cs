using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }


        }
    }
}
