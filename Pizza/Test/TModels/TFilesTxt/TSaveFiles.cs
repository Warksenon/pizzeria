using Pizza;
using System;
using System.Collections.Generic;
using System.IO;

namespace Test.TModels.TFilesTxt
{
    public class TSaveFiles : ISaveHistory
    {
        const string folderDatabase = @"c:\SQLtest\Konsola\sqlite\Historia zamówień.txt";
        Name name = new Name();
        private void SaveListOrder(List<Order> listOrder)
        {
            try
            {
                using (StreamWriter streamW = new StreamWriter((folderDatabase), false))
                {
                    streamW.WriteLine("");
                    streamW.Flush();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Zapisanie do pilku txt nie powiodło się \n" + e);
            }

            foreach (var order in listOrder)
            {
                Save(order);
            }
        }

        private void Save(Order order)
        {
            try
            {
                using (StreamWriter streamW = new StreamWriter((folderDatabase), true))
                {
                    string s = "";
                    s = name.BeginningOfOrderCode + "\n" + AddPriceAll(order.PriceAll) + AddDishes(order) + name.EndOfOrderCode;
                    streamW.WriteLine(s);
                    streamW.Flush();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Zapisanie do pilku txt nie powiodło się \n" + e);
            }
        }

        private string AddPriceAll(PriceAll priceAll)
        {
            string stPriceAll = name.PriceAllBeginning + "\n";
            stPriceAll += name.PriceAll + priceAll.Price + "\n";
            stPriceAll += name.Date + priceAll.Date + "\n";
            stPriceAll += name.Comments + priceAll.Comments + "\n";
            stPriceAll += name.PriceAllEnd + "\n";
            return stPriceAll;
        }

        private string AddDishes(Order order)
        {
            string stDish = "";
            foreach (var dish in order.ListDishes)
            {
                stDish += name.DishBeginning + "\n";
                stDish += name.Dish + dish.Name + "\n";
                stDish += name.Price + dish.Price + "\n";
                stDish += name.SidesDishes + dish.SidesDishes + "\n";
                stDish += name.DishEnd + "\n";
            }
            return stDish;
        }

        public void CleanFilesTxt()
        {
            try
            {
                using (StreamWriter streamW = new StreamWriter((folderDatabase), false))
                {
                    streamW.WriteLine("");
                    streamW.Flush();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Zapisanie do pilku txt nie powiodło się \n" + e);
            }

        }

        public void SaveHistoryOrders(List<Order> listOrder)
        {
            SaveListOrder(listOrder);
        }

        public void AddOrder(Order order)
        {
            Save(order);
        }
    }
}
