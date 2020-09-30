using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace PizzaTest
{
    [TestClass]
    public class TestListOfSideDidhes
    {
        [TestMethod]
        public void TestLoadSidePizza()
        {
            Name name = new Name();
            LoadListOfSideDishes loadListOfSideDishes = new LoadListOfSideDishes();

            List<string> listSideDishes = loadListOfSideDishes.LoadSidePizza();

            Assert.AreEqual(name.DoubelCheesePrice, listSideDishes[0]);
            Assert.AreEqual(name.SalamiPrice, listSideDishes[1]);
            Assert.AreEqual(name.HamPrice, listSideDishes[2]);
            Assert.AreEqual(name.MushroomsPrice, listSideDishes[3]);
        }

        [TestMethod]
        public void TestLoadMainDish()
        {
            Name name = new Name();
            LoadListOfSideDishes loadListOfSideDishes = new LoadListOfSideDishes();

            List<string> listSideDishes = loadListOfSideDishes.LoadSideMainDish();

            Assert.AreEqual(name.BarPrice, listSideDishes[0]);
            Assert.AreEqual(name.SetOfSaucesPrice, listSideDishes[1]);           
        }
    }
}
