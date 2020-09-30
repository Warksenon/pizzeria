using System.Collections.Generic;

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
                    load = new SqlLite.InsertAndQuestionSQL(); break;
                case ChoiceLoadOrder.Txt:
                    load = new LoadingFilesTxt(); break;
                default:
                    load = new SqlLite.InsertAndQuestionSQL(); break;
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
