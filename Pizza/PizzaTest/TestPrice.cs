using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using System.Collections.Generic;

namespace PizzaTest
{
    [TestClass]
    public class testForm1
    {
        [TestMethod]
        public void TestPriceSidePizza()
        {
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            LoadListOfSideDishes loadListOfSideDishes = new LoadListOfSideDishes();
            List<string> sideDishes = loadListOfSideDishes.LoadSidePizza();

            foreach(var st in sideDishes)
            {
                int priceAll = addOrder.FindsPrice(st);
                Assert.AreEqual(2, priceAll);
            }
        }


        [TestMethod]
        public void TestPriceSideDania()
        {
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            LoadListOfSideDishes loadListOfSideDishes = new LoadListOfSideDishes();

            List<string> sideDishes = loadListOfSideDishes.LoadSideMainDish();


            int price = addOrder.FindsPrice(sideDishes[0]);
            Assert.AreEqual(5, price);

            price = addOrder.FindsPrice(sideDishes[1]);
            Assert.AreEqual(6, price);           
        }

        [TestMethod]
        public void TestPriceListDaniaGlowne()
        {
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            ListOfDishes listOfDishes = new ListOfDishes();

            List<Dish> lDishes = listOfDishes.LoadListMainDish();

            int price = addOrder.FindsPrice(lDishes[0].Price);
            Assert.AreEqual(30, price);

            price = addOrder.FindsPrice(lDishes[1].Price);
            Assert.AreEqual(28, price);

            price = addOrder.FindsPrice(lDishes[2].Price);
            Assert.AreEqual(27, price);
        }

        [TestMethod]
        public void TestPriceListPizza()
        {
            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            ListOfDishes listOfDishes = new ListOfDishes();

            List<Dish> lDishes = listOfDishes.LoadListPizza();

            int price = addOrder.FindsPrice(lDishes[0].Price);
            Assert.AreEqual(20, price);

            price = addOrder.FindsPrice(lDishes[1].Price);
            Assert.AreEqual(22, price);

            price = addOrder.FindsPrice(lDishes[2].Price);
            Assert.AreEqual(25, price);

            price = addOrder.FindsPrice(lDishes[3].Price);
            Assert.AreEqual(25, price);
        }

     

        [TestMethod]
        public void TestPriceListZupy()
        {

            AddOrderFromForm1 addOrder = new AddOrderFromForm1();
            ListOfDishes listOfDishes = new ListOfDishes();

            List<Dish> lDishes = listOfDishes.LoadListSoups();

            int price = addOrder.FindsPrice(lDishes[0].Price);
            Assert.AreEqual(12, price);

            price = addOrder.FindsPrice(lDishes[1].Price);
            Assert.AreEqual(10, price);
        }
    }
}
