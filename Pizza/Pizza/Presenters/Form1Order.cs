using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza.Presenters
{
    class Form1Order
    {

        private IForm1ListViewDishesAndCheckedListBoxSideDish loadDishesAndSides;
        private IForm1Order form1Order;

        public Form1Order(IForm1ListViewDishesAndCheckedListBoxSideDish listDishes, IForm1Order order)
        {
            loadDishesAndSides = listDishes;
            form1Order = order;
        }

        public void AddDishesToListViewOrder()
        {
            if (CheckNumberTextViewDishes() > 0)
            {
                int x = CheckListDishesSelectedItem();
                Dish dish = new Dish
                {
                    Name = loadDishesAndSides.ListViewDishes.Items[x].SubItems[0].Text,
                    Price = loadDishesAndSides.ListViewDishes.Items[x].SubItems[1].Text
                };

                for (int i = 0; i < CheckNumberTextViewDishes(); i++)
                {
                    ListViewItem lvi;
                    if (CheckSelecktSideDishes().Equals(""))
                    {
                        lvi = new ListViewItem(dish.Name);
                        lvi.SubItems.Add(CheckSelecktSideDishes());
                        lvi.SubItems.Add(dish.Price);
                    }
                    else
                    {
                        lvi = new ListViewItem(dish.Name + " -" + dish.Price);
                        lvi.SubItems.Add(CheckSelecktSideDishes());
                        lvi.SubItems.Add(PriceDisheAndSide(dish.Price));
                    }
                    form1Order.ListViewOrder.Items.Add(lvi);
                }
            }
        }

        private int CheckListDishesSelectedItem()
        {
            return loadDishesAndSides.ListViewDishes.FocusedItem.Index;
        }

        private string CheckSelecktSideDishes()
        {
            string side = "";
            foreach (object item in loadDishesAndSides.CheckedListBoxSideDish.CheckedItems)
            {
                if (side.Equals(""))
                {
                    side += item.ToString();
                }
                else
                {
                    side += ", ";
                    side += item.ToString();
                }
            }
            if (side.Equals("")) return side;
            else return side + ".";
        }

        private int CheckNumberTextViewDishes()
        {
            int number = CheckTextIsNumber(form1Order.TextBoxQuantityDishes.Text);
            if (number > 0) return number;
            else return number;
        }

        private int CheckTextIsNumber(string textNumber)
        {
            int number = 0;
            try
            {
                number = Convert.ToUInt16(textNumber);
            }
            catch
            {
                MessageBox.Show("Podana ilość produktów nie jest prawidłowa");
            }
            return number;
        }

        private string PriceDisheAndSide(string priceDish)
        {
            string priceSide;
            int priceAll = FindsPrice(priceDish);

            foreach (object item in loadDishesAndSides.CheckedListBoxSideDish.CheckedItems)
            {
                priceSide = item.ToString();
                priceAll += FindsPrice(priceSide);
            }
            return priceAll + "zł";
        }

        private int FindsPrice(string priceSide)
        {
            int start = priceSide.IndexOf("zł") - 2;
            priceSide = priceSide.Substring(start, 2);
            priceSide = priceSide.Trim();
            priceSide = priceSide.Replace("-", " ");
            return Convert.ToInt16(priceSide);
        }

        public void LabelPrice()
        {

            form1Order.LabelPrice.Text = "Cena: " + PriceCalculation(form1Order.ListViewOrder).ToString() + "zł";
        }

        private double PriceCalculation(ListView list)
        {
            double priceOrder = 0;
            string priceDishes;

            if (!(list.Items == null))
            {
                int i = 0;
                foreach (var item in list.Items)
                {
                    priceDishes = list.Items[i].SubItems[2].Text;
                    priceDishes = priceDishes.Remove(priceDishes.IndexOf("zł"));
                    priceOrder += Convert.ToDouble(priceDishes);
                    i++;
                }
            }
            AddPriceAllToOrder(priceOrder);
            return priceOrder;
        }

        static Order order   = new Order();

        void AddPriceAllToOrder(double price)
        {
            order.PriceAll.Price = Convert.ToString(price);

        }


        public void SetListDenmark(ListView ListView)
        {
            
            var list = new List<Dish>();
            if (!(ListView.Items == null))
            {
                int i = 0;
                foreach (var item in ListView.Items)
                {
                    list.Add(new Dish()
                    {
                        Name = ListView.Items[i].SubItems[0].Text,
                        SidesDishes = ListView.Items[i].SubItems[1].Text,
                        Price = ListView.Items[i].SubItems[2].Text
                    });
                    i++;
                }
            }
            order.ListDishes = list;
        }

        public void SetCommentsAndDate(string comments)
        {
            order.PriceAll.Comments = comments;
            order.PriceAll.Date = DateTime.Now.ToString();
        }

        public Order GetOrder()
        {
            return order;
        }

        static string sendMesseg;
        public void SubmitOrder()
        {
            if (ChceckListViewOrderIsNotEpmty())
            {
                SetCommentsAndDate(form1Order.TextBoxComments.Text);
                SetListDenmark(form1Order.ListViewOrder);
                EmailMessage messeg = new EmailMessage(GetOrder());
                sendMesseg = messeg.WriteBill();
                if (form1Order.BackgroundWorker.IsBusy != true)
                {
                    form1Order.BackgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Przetwarzanie danych proszę czekać");
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać produkt");
            }
        }

        private bool ChceckListViewOrderIsNotEpmty()
        {
            if (form1Order.ListViewOrder.Items.Count > 0) return true;
            else return false;
        }

        private bool SendEmail(string message)
        {
            Email email = new Email();
            return email.SendEmail(message);
        }

        public void SendEmailAndSaveOrder ()
        {
            Save save = new Save();
              if (SendEmail(sendMesseg))
            {              
                save.SaveOrder(Save.ChoiceSaveOrder.Txt, GetOrder());
                save.SaveOrder(Save.ChoiceSaveOrder.Sql, GetOrder());               
            }
            else
            {
                MessageBox.Show("Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym");
            }
        }

    }
}
