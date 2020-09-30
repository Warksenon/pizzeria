using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza;

namespace PizzaTest
{
    public interface TISaveHistory
    {
        void SaveHistoryOrders(List<Order> listOrder);

        void AddOrder(Order order);
    }


}
