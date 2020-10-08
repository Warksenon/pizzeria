using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Save
    {
        ISaveHistory save;
        public enum ChoiceSaveOrder
        {
            Sql,
            Txt
        }

        public void  SaveOrderList (ChoiceSaveOrder en, List<Order> orders)
        {
            
            switch (en)
            {
                case ChoiceSaveOrder.Sql:
                    save = new SqlLite.InsertAndQuestionSQL(); break;
                case ChoiceSaveOrder.Txt:
                    save = new SaveFiles(); break;
                default:
                    save = new SqlLite.InsertAndQuestionSQL(); break;
            }
            save.SaveHistoryOrders(orders);
        }

        public void SaveOrder(ChoiceSaveOrder en, Order order)
        { 

            switch (en)
            {
                case ChoiceSaveOrder.Sql:
                    save = new SqlLite.InsertAndQuestionSQL(); break;
                case ChoiceSaveOrder.Txt:
                    save = new SaveFiles(); break;
                default:
                    save = new SqlLite.InsertAndQuestionSQL(); break;
            }
            save.AddOrder(order);
        }

    }

   
}
