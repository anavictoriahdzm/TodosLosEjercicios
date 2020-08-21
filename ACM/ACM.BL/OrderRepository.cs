using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrieve one order.
        public Order Retrieve(int orderId)
        {
            //Create the instance of the order class
            //Pass in the requested id
            Order order = new Order(orderId);

            //Corde that retrieves the defined order

            //Temporary hard coded values to return
            //a populated order
            if (orderId == 10)
            {
                //Use current year in hard coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        //save the current order
        public bool Save(Order order)
        {
            //code that saves the passed in order
            return true;
        }
    }
}
