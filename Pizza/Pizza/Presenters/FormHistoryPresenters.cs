using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pizza.SqlLite;

namespace Pizza.Presenters
{

    class FormHistoryPresenters
    {
        readonly IFormHistory history;
        List<Order> orderList = new List<Order>();
        readonly LoadOrder load = new LoadOrder();
        

        public FormHistoryPresenters(IFormHistory fromHistory)
        {
            history = fromHistory;
        }

        public void  CopyData(LoadOrder.ChoiceLoadOrder data)
        {
            Save save = new Save();
            List<Order> listOrder = new List<Order>();           

            switch (data)
            {
                case LoadOrder.ChoiceLoadOrder.Sql:
                    listOrder = load.LoadOrderList(LoadOrder.ChoiceLoadOrder.Sql);
                    save.SaveOrderList(Save.ChoiceSaveOrder.Txt, listOrder);
                    break;
                case LoadOrder.ChoiceLoadOrder.Txt:
                    listOrder = load.LoadOrderList(LoadOrder.ChoiceLoadOrder.Txt);
                    save.SaveOrderList(Save.ChoiceSaveOrder.Sql, listOrder);
                    break;
            }

        }

        public void LoadHistroyFromTxt()
        {
                ClearAllList();
                orderList = load.LoadOrderList(LoadOrder.ChoiceLoadOrder.Txt);
                LoadLVPriceAll();
        }

        public void LoadHistoryFromSQL ()
        {
                ClearAllList();              
                orderList = load.LoadOrderList(LoadOrder.ChoiceLoadOrder.Sql);
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

        public void LoadLVDishes()
        {
            history.ListViewDishes.Items.Clear();
            foreach (var dish in orderList[history.ListViewPrice.FocusedItem.Index].ListDishes)
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
