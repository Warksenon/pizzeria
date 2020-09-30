using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public interface ISaveHistory
    {
        void SaveHistoryOrders(List<Order> listOrder);

        void AddOrder(Order order);
    }
}
