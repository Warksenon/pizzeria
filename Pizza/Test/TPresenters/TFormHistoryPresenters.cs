using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza;
using Test.TModels.TSQLite;

namespace Test.TPresenters
{
    class TFormHistoryPresenters
    {

        IFormHistory history;
        List<Order> orderList = new List<Order>();
        TLoadOrder load = new TLoadOrder();


        public TFormHistoryPresenters(IFormHistory fromHistory)
        {
            history = fromHistory;
        }

        public void CopyData(LoadOrder.ChoiceLoadOrder data)
        {
            TSave save = new TSave();
            List<Order> listOrder = new List<Order>();
            TInsertAndQuestionSQL sql = new TInsertAndQuestionSQL();

            switch (data)
            {
                case LoadOrder.ChoiceLoadOrder.Sql:
                    listOrder = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Sql);
                    save.SaveOrderList(TSave.ChoiceSaveOrder.Txt, listOrder);
                    break;
                case LoadOrder.ChoiceLoadOrder.Txt:
                    listOrder = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Txt);
                    save.SaveOrderList(TSave.ChoiceSaveOrder.Sql, listOrder);
                    break;
            }

        }

        public void LoadHistroyFromTxt()
        {
            ClearAllList();
            orderList = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Txt);
            LoadLVPriceAll();
        }

        public void LoadHistoryFromSQL()
        {
            ClearAllList();
            orderList = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Sql);
            LoadLVPriceAll();

        }

        private void ClearAllList()
        {
            history.ListViewDishes.Items.Clear();
            history.ListViewPrice.Items.Clear();
            orderList.Clear();
        }

        private void LoadLVPriceAll()
        {
            foreach (var price in orderList)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(price.PriceAll.ID));
                lvi.SubItems.Add(price.PriceAll.Date);
                lvi.SubItems.Add(price.PriceAll.Price);
                lvi.SubItems.Add(price.PriceAll.Comments);
                history.ListViewPrice.Items.Add(lvi);
            }
        }

        public void LoadLVDishes(int idPrice)
        {
            history.ListViewDishes.Items.Clear();
            foreach (var dish in orderList[idPrice].ListDishes)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(dish.IdPrice));
                lvi.SubItems.Add(dish.Name);
                lvi.SubItems.Add(dish.Price);
                lvi.SubItems.Add(dish.SidesDishes);
                history.ListViewDishes.Items.Add(lvi);
            }
        }
    }
}
