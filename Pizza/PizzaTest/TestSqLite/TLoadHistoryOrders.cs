using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza;

namespace PizzaTest
{
    public  interface TILoadHistoryOrders
    {
        List<Order> LoadHistory();
    }
}
