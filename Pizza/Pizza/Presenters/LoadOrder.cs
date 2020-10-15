using System.Collections.Generic;
using Pizza.SqlLite;

namespace Pizza
{
    public  class LoadOrder
    {
        public List<Order> LoadOrderList(ChoiceLoadOrder en)
        {
            ILoadHistoryOrders load;
            switch (en)
            {
                case ChoiceLoadOrder.Sql:
                    load = new InsertAndQuestionSQL(); break;
                case ChoiceLoadOrder.Txt:
                    load = new LoadingFilesTxt(); break;
                default:
                    load = new InsertAndQuestionSQL(); break;
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
