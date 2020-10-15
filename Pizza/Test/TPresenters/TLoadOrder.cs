using Pizza;
using System.Collections.Generic;
using Test.TModels.TFilesTxt;
using Test.TModels.TSQLite;

namespace Test.TPresenters
{
    public class TLoadOrder
    {
        public List<Order> LoadOrderList(ChoiceLoadOrder en)
        {
            ILoadHistoryOrders load;
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
