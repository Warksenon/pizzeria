using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza;

namespace PizzaTest
{
    public  class TLoadOrder
    {
        public List<Order> LoadOrderList(ChoiceLoadOrder en)
        {
            TILoadHistoryOrders load;
            switch (en)
            {
                case ChoiceLoadOrder.Sql:
                    load = new TInsertAndQuestionSQL(); break;
                case ChoiceLoadOrder.Txt:
                    load = new TLoadingFilesTxt(); break;
                default:
                    load = new TInsertAndQuestionSQL(); break;
            }
            return load.LoadHistory();
        }

        public enum ChoiceLoadOrder
        {
            Sql,
            Txt
        }
    }
}
