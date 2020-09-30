using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaTest
{
    [TestClass]
    public class TestAddOrderFromForm1
    {

        [TestMethod]
        public void TestSetListDenmarkPizza()
        {         
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListPizza());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);        
            order = addOrder.GetOrder();

            Assert.AreEqual("Margheritta", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("20zł", order.ListDishes[0].Price);

            Assert.AreEqual("Vegetariana", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("22zł", order.ListDishes[1].Price);

            Assert.AreEqual("Tosca", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("25zł", order.ListDishes[2].Price);

            Assert.AreEqual("Venecia", order.ListDishes[3].Name);
            Assert.AreEqual("", order.ListDishes[3].SidesDishes);
            Assert.AreEqual("25zł", order.ListDishes[3].Price);

        }


        [TestMethod]
        public void TestSetListDenmarkMainDish()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListMainDish());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Schabowy z frytkami/ryżem/ziemniakami", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("30zł", order.ListDishes[0].Price);

            Assert.AreEqual("Ryba z frytkami", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("28zł", order.ListDishes[1].Price);

            Assert.AreEqual("Placek po węgiersku", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("27zł", order.ListDishes[2].Price);


            order = NewOrder(listOfDishes.LoadListDrinks());
            listView = SetListView(order.ListDishes);
            addOrder = NewAddOrder(listView);
            addOrder.SetListDenmark(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Kawa", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[0].Price);

            Assert.AreEqual("Herbata", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[1].Price);

            Assert.AreEqual("Cola", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[2].Price);

            order = NewOrder(listOfDishes.LoadListSoups());
            listView = SetListView(order.ListDishes);
            addOrder = NewAddOrder(listView);
            addOrder.SetListDenmark(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Pomidorowa", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("12zł", order.ListDishes[0].Price);

            Assert.AreEqual("Rosół", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("10zł", order.ListDishes[1].Price);





        }

        [TestMethod]
        public void TestSetListDenmarkDrinks()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListDrinks());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Kawa", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[0].Price);

            Assert.AreEqual("Herbata", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[1].Price);

            Assert.AreEqual("Cola", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[2].Price);

        }

        [TestMethod]
        public void TestSetListDenmarkSoups()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListSoups());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Pomidorowa", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("12zł", order.ListDishes[0].Price);

            Assert.AreEqual("Rosół", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("10zł", order.ListDishes[1].Price);
        }

        [TestMethod]
        public void TestSetListDenmarkAll()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListPizza());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Margheritta", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("20zł", order.ListDishes[0].Price);

            Assert.AreEqual("Vegetariana", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("22zł", order.ListDishes[1].Price);

            Assert.AreEqual("Tosca", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("25zł", order.ListDishes[2].Price);

            Assert.AreEqual("Venecia", order.ListDishes[3].Name);
            Assert.AreEqual("", order.ListDishes[3].SidesDishes);
            Assert.AreEqual("25zł", order.ListDishes[3].Price);

            order = NewOrder(listOfDishes.LoadListMainDish());
            listView = SetListView(order.ListDishes);
            addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Schabowy z frytkami/ryżem/ziemniakami", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("30zł", order.ListDishes[0].Price);

            Assert.AreEqual("Ryba z frytkami", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("28zł", order.ListDishes[1].Price);

            Assert.AreEqual("Placek po węgiersku", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("27zł", order.ListDishes[2].Price);


            order = NewOrder(listOfDishes.LoadListDrinks());
            listView = SetListView(order.ListDishes);
            addOrder = NewAddOrder(listView);
            addOrder.SetListDenmark(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Kawa", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[0].Price);

            Assert.AreEqual("Herbata", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[1].Price);

            Assert.AreEqual("Cola", order.ListDishes[2].Name);
            Assert.AreEqual("", order.ListDishes[2].SidesDishes);
            Assert.AreEqual("5zł", order.ListDishes[2].Price);

            order = NewOrder(listOfDishes.LoadListSoups());
            listView = SetListView(order.ListDishes);
            addOrder = NewAddOrder(listView);
            addOrder.SetListDenmark(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("Pomidorowa", order.ListDishes[0].Name);
            Assert.AreEqual("", order.ListDishes[0].SidesDishes);
            Assert.AreEqual("12zł", order.ListDishes[0].Price);

            Assert.AreEqual("Rosół", order.ListDishes[1].Name);
            Assert.AreEqual("", order.ListDishes[1].SidesDishes);
            Assert.AreEqual("10zł", order.ListDishes[1].Price);
        }


        public Order NewOrder(List<Dish> listDish)
        {
            Order order = new Order();
            order.ListDishes = listDish;
            return order;
        }

        public ListView SetListView( List<Dish> listDish)
        {
            ListView listView = new ListView();
            foreach (var disch in listDish)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
                lvi.SubItems.Add(disch.SidesDishes);
                lvi.SubItems.Add(disch.Price);
                listView.Items.Add(lvi);
            }
            return listView;
        }

        public AddOrderFromForm1 NewAddOrder(ListView listView)
        {
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            addOrder.SetListDenmark(listView);
            return addOrder;
        }

        [TestMethod]
        public void TestFindsPricePizza()
        {
            List<string> lside = new List<string>();
            ListOfDishes listOfDishes = new ListOfDishes();
            LoadListOfSideDishes listOfSideDishes = new LoadListOfSideDishes();

            Order order = NewOrder(listOfDishes.LoadListPizza());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            string nameAndPrice = order.ListDishes[0].Name + order.ListDishes[0].Price;           
            Assert.AreEqual(20, addOrder.FindsPrice(nameAndPrice));
             nameAndPrice = order.ListDishes[1].Name + order.ListDishes[1].Price;
            Assert.AreEqual(22, addOrder.FindsPrice(nameAndPrice));
             nameAndPrice = order.ListDishes[2].Name + order.ListDishes[2].Price;
            Assert.AreEqual(25, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = order.ListDishes[3].Name + order.ListDishes[3].Price;
            Assert.AreEqual(25, addOrder.FindsPrice(nameAndPrice));

            lside = listOfSideDishes.LoadSidePizza();

            nameAndPrice = lside[0];
            Assert.AreEqual(2, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = lside[1];
            Assert.AreEqual(2, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = lside[2];
            Assert.AreEqual(2, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = lside[3];
            Assert.AreEqual(2, addOrder.FindsPrice(nameAndPrice));
        }

        [TestMethod]
        public void TestFindsPriceMainDish()
        {
            List<string> lside = new List<string>();
            ListOfDishes listOfDishes = new ListOfDishes();
            LoadListOfSideDishes listOfSideDishes = new LoadListOfSideDishes();

            Order order = NewOrder(listOfDishes.LoadListMainDish());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            string nameAndPrice = order.ListDishes[0].Name + order.ListDishes[0].Price;
            Assert.AreEqual(30, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = order.ListDishes[1].Name + order.ListDishes[1].Price;
            Assert.AreEqual(28, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = order.ListDishes[2].Name + order.ListDishes[2].Price;
            Assert.AreEqual(27, addOrder.FindsPrice(nameAndPrice));
           

            lside = listOfSideDishes.LoadSideMainDish();

            nameAndPrice = lside[0];
            Assert.AreEqual(5, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = lside[1];
            Assert.AreEqual(6, addOrder.FindsPrice(nameAndPrice));
        }


        [TestMethod]
        public void TestFindsPriceSoups()
        {       
            ListOfDishes listOfDishes = new ListOfDishes();
            LoadListOfSideDishes listOfSideDishes = new LoadListOfSideDishes();

            Order order = NewOrder(listOfDishes.LoadListSoups());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = NewAddOrder(listView);
            order = addOrder.GetOrder();

            string nameAndPrice = order.ListDishes[0].Name + order.ListDishes[0].Price;
            Assert.AreEqual(12, addOrder.FindsPrice(nameAndPrice));
            nameAndPrice = order.ListDishes[1].Name + order.ListDishes[1].Price;
            Assert.AreEqual(10, addOrder.FindsPrice(nameAndPrice));
        }


        [TestMethod]
        public void TestPriceCalculationPizza()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListPizza());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            addOrder.PriceCalculation(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("92", order.PriceAll.Price);
        }

        [TestMethod]
        public void TestPriceCalculationMainDish()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListMainDish());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            addOrder.PriceCalculation(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("85", order.PriceAll.Price);
        }

        [TestMethod]
        public void TestPriceCalculationSoups()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListSoups());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            addOrder.PriceCalculation(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("22", order.PriceAll.Price);
        }

        [TestMethod]
        public void TestPriceCalculationDrinks()
        {
            ListOfDishes listOfDishes = new ListOfDishes();

            Order order = NewOrder(listOfDishes.LoadListDrinks());
            ListView listView = SetListView(order.ListDishes);
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            addOrder.PriceCalculation(listView);
            order = addOrder.GetOrder();

            Assert.AreEqual("15", order.PriceAll.Price);
        }



    }
}
