using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace PizzaTest
{
    [TestClass]
    public class TestLoadingAnDSaveFiles
    {
        Name name = new Name();

        [TestMethod]
        public void TestSaveOrder()
        {
            TSaveFiles saveFiles = new TSaveFiles();
            saveFiles.CleanFilesTxt(); 

            ListOfDishes listOfDishes = new ListOfDishes();

            List<Dish> lPizza = listOfDishes.LoadListPizza();
            PriceAll price = new PriceAll();
            price.Comments = "hhhhh";
            price.Date = "24.03.2020";
            price.Price = "120";


            Order order = new Order();
            order.PriceAll = price;
            order.ListDishes = lPizza;

            TSave save = new TSave();
            save.SaveOrder(TSave.ChoiceSaveOrder.Txt, order);

            TLoadOrder load = new TLoadOrder();
            List<Order> lOrder = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Txt);
            Assert.AreEqual(order.ListDishes[0].Name, name.Margh);

            Assert.AreEqual(order.PriceAll.Comments, lOrder[0].PriceAll.Comments);
            Assert.AreEqual(order.PriceAll.Date, lOrder[0].PriceAll.Date);
            Assert.AreEqual(order.PriceAll.Price, lOrder[0].PriceAll.Price);

            Assert.AreEqual(order.ListDishes[0].Name, lOrder[0].ListDishes[0].Name);
            Assert.AreEqual(order.ListDishes[0].Price, lOrder[0].ListDishes[0].Price);

            Assert.AreEqual(order.ListDishes[0].SidesDishes, lOrder[0].ListDishes[0].SidesDishes);
        }

        [TestMethod]
        public void TestSaveOrderList()
        {
            TSaveFiles saveFiles = new TSaveFiles();
            saveFiles.CleanFilesTxt();

            TestAddOrderFromForm1 testAdd = new TestAddOrderFromForm1();
            List<string> lside = new List<string>();
            ListOfDishes listOfDishes = new ListOfDishes();
            LoadListOfSideDishes listOfSideDishes = new LoadListOfSideDishes();
            TestSqLite testSql = new TestSqLite();
            Order order = new Order();
            order.ListDishes = listOfDishes.LoadListPizza();


            string price = Convert.ToString(testSql.CalcuationPrice(order));
            order.PriceAll.Price = price + "zł";
            string date = DateTime.Now.ToString();
            order.PriceAll.Date = date;

            List<Order> lOrder = new List<Order>();
            lOrder.Add(order);

            TSave save = new TSave();
            save.SaveOrderList(TSave.ChoiceSaveOrder.Txt, lOrder);

            TLoadOrder load = new TLoadOrder();
            List<Order> loadSql = new List<Order>();
            loadSql = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Txt);

            Assert.AreEqual(lOrder[0].PriceAll.Comments, lOrder[0].PriceAll.Comments);
            Assert.AreEqual(lOrder[0].PriceAll.Date, lOrder[0].PriceAll.Date);
            Assert.AreEqual(lOrder[0].PriceAll.Price, lOrder[0].PriceAll.Price);

            Assert.AreEqual(lOrder[0].ListDishes[0].Name, lOrder[0].ListDishes[0].Name);
            Assert.AreEqual("Margheritta", lOrder[0].ListDishes[0].Name);
            Assert.AreEqual(lOrder[0].ListDishes[0].Price, lOrder[0].ListDishes[0].Price);
            Assert.AreEqual(lOrder[0].ListDishes[0].SidesDishes, lOrder[0].ListDishes[0].SidesDishes);

            Assert.AreEqual(lOrder[0].ListDishes[1].Name, lOrder[0].ListDishes[1].Name);
            Assert.AreEqual(lOrder[0].ListDishes[1].Price, lOrder[0].ListDishes[1].Price);
            Assert.AreEqual(lOrder[0].ListDishes[1].SidesDishes, lOrder[0].ListDishes[1].SidesDishes);

            Assert.AreEqual(lOrder[0].ListDishes[2].Name, lOrder[0].ListDishes[2].Name);
            Assert.AreEqual(lOrder[0].ListDishes[2].Price, lOrder[0].ListDishes[2].Price);
            Assert.AreEqual(lOrder[0].ListDishes[2].SidesDishes, lOrder[0].ListDishes[2].SidesDishes);

            Assert.AreEqual(lOrder[0].ListDishes[3].Name, lOrder[0].ListDishes[3].Name);
            Assert.AreEqual(lOrder[0].ListDishes[3].Price, lOrder[0].ListDishes[3].Price);
            Assert.AreEqual(lOrder[0].ListDishes[3].SidesDishes, lOrder[0].ListDishes[3].SidesDishes);


            order.ListDishes = listOfDishes.LoadListMainDish();
            price = Convert.ToString(testSql.CalcuationPrice(order));
            order.PriceAll.Price = price + "zł";
            date = DateTime.Now.ToString();
            order.PriceAll.Date = date;
            lOrder.Add(order);
            save.SaveOrderList(TSave.ChoiceSaveOrder.Txt, lOrder);
            loadSql = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Txt);

            Assert.AreEqual(lOrder[1].PriceAll.Comments, lOrder[1].PriceAll.Comments);
            Assert.AreEqual(lOrder[1].PriceAll.Date, lOrder[1].PriceAll.Date);
            Assert.AreEqual(lOrder[1].PriceAll.Price, lOrder[1].PriceAll.Price);

            Assert.AreEqual(lOrder[1].ListDishes[0].Name, lOrder[1].ListDishes[0].Name);
            Assert.AreEqual("Schabowy z frytkami/ryżem/ziemniakami", lOrder[1].ListDishes[0].Name);
            Assert.AreEqual(lOrder[1].ListDishes[0].Price, lOrder[1].ListDishes[0].Price);
            Assert.AreEqual(lOrder[1].ListDishes[0].SidesDishes, lOrder[1].ListDishes[0].SidesDishes);

            Assert.AreEqual(lOrder[1].ListDishes[1].Name, lOrder[1].ListDishes[1].Name);
            Assert.AreEqual(lOrder[1].ListDishes[1].Price, lOrder[1].ListDishes[1].Price);
            Assert.AreEqual(lOrder[1].ListDishes[1].SidesDishes, lOrder[1].ListDishes[1].SidesDishes);

            Assert.AreEqual(lOrder[1].ListDishes[2].Name, lOrder[1].ListDishes[2].Name);
            Assert.AreEqual(lOrder[1].ListDishes[2].Price, lOrder[1].ListDishes[2].Price);
            Assert.AreEqual(lOrder[1].ListDishes[2].SidesDishes, lOrder[1].ListDishes[2].SidesDishes);


            order.ListDishes = listOfDishes.LoadListSoups();
            price = Convert.ToString(testSql.CalcuationPrice(order));
            order.PriceAll.Price = price + "zł";
            date = DateTime.Now.ToString();
            order.PriceAll.Date = date;
            lOrder.Add(order);
            save.SaveOrderList(TSave.ChoiceSaveOrder.Txt, lOrder);
            loadSql = load.LoadOrderList(TLoadOrder.ChoiceLoadOrder.Txt);

            Assert.AreEqual(lOrder[2].PriceAll.Comments, lOrder[2].PriceAll.Comments);
            Assert.AreEqual(lOrder[2].PriceAll.Date, lOrder[2].PriceAll.Date);
            Assert.AreEqual(lOrder[2].PriceAll.Price, lOrder[2].PriceAll.Price);

            Assert.AreEqual(lOrder[2].ListDishes[0].Name, lOrder[2].ListDishes[0].Name);
            Assert.AreEqual("Pomidorowa", lOrder[2].ListDishes[0].Name);
            Assert.AreEqual(lOrder[2].ListDishes[0].Price, lOrder[2].ListDishes[0].Price);
            Assert.AreEqual(lOrder[2].ListDishes[0].SidesDishes, lOrder[2].ListDishes[0].SidesDishes);

            Assert.AreEqual(lOrder[2].ListDishes[1].Name, lOrder[2].ListDishes[1].Name);
            Assert.AreEqual(lOrder[2].ListDishes[1].Price, lOrder[2].ListDishes[1].Price);
            Assert.AreEqual(lOrder[2].ListDishes[1].SidesDishes, lOrder[2].ListDishes[1].SidesDishes);
        }
    }   
}
