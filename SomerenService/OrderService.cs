using SomerenModel;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    
    public class OrderService
    {
        OrderDao orderdb;
        public OrderService()
        {
            orderdb = new OrderDao();
        }
        public void OrderDrink(int studentNr, int drinkId, int quantity)
        {
            orderdb.PlaceDrinkOrder(studentNr, drinkId, quantity);
        }
    }
}
