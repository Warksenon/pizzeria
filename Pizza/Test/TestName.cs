using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;


namespace Test
{
    [TestClass]
    public class TestName
    {
        readonly Name name = new Name();
        [TestMethod]
        public void TestNameTrue()
        {
            Assert.AreEqual("Dania główne", name.GetNameConfig("denmark"));
        }

        [TestMethod]
        public void TestNameFalse()
        {
            string test = "name retrieval error: denmarkiiii";
            Assert.AreEqual(test, name.GetNameConfig("denmarkiiii"));
        }


        [TestMethod]
        public void TestNameGeter()
        {
            Assert.AreEqual("Pizza", name.LMenuInfoPizza);
            Assert.AreEqual("Dania główne", name.LMenuInfoMainDish);
            Assert.AreEqual("Zupy", name.LMenuInfoSoups);
            Assert.AreEqual("Napoje", name.LMenuInfoDrinks);

            Assert.AreEqual("PriceAll", name.PriceAll);
            Assert.AreEqual("Dishes", name.Dishes);
            Assert.AreEqual("idPrice", name.IdPrice);
            Assert.AreEqual("Comments", name.Comments);
            Assert.AreEqual("id", name.Id);
            Assert.AreEqual("SidesDishes", name.SidesDishes);
            Assert.AreEqual("Price", name.Price);
            Assert.AreEqual("Dish", name.Dish);
            Assert.AreEqual("# Cenna za danie: ", name.PriceForDish);
            Assert.AreEqual("idPrice", name.IdPrice);
            Assert.AreEqual("Uwagi do zamówienia: ", name.CommentsMessag);
            Assert.AreEqual("Data", name.Date);
            Assert.AreEqual("____start____", name.BeginningOfOrderCode);
            Assert.AreEqual("^^^^^end^^^^^", name.EndOfOrderCode);
            Assert.AreEqual("priceAllBeginning", name.PriceAllBeginning);
            Assert.AreEqual("priceAllEnd", name.PriceAllEnd);
            Assert.AreEqual("dishBeginning", name.DishBeginning);
            Assert.AreEqual("dishEnd", name.DishEnd);
            Assert.AreEqual("Cena", name.NPrice);
            Assert.AreEqual("Dania główne", name.Denmark);
            Assert.AreEqual("Zupy", name.Soups);
            Assert.AreEqual("Napoje - 5zł", name.Drinks);

            Assert.AreEqual("Margheritta", name.Margh);
            Assert.AreEqual("Vegetariana", name.Veget);
            Assert.AreEqual("Tosca", name.Tosca);
            Assert.AreEqual("Venecia", name.Venec);

            Assert.AreEqual("Margheritta -20zł", name.MarghPrice);
            Assert.AreEqual("Vegetariana -22zł", name.VegetPrice);
            Assert.AreEqual("Tosca -25zł", name.ToscaPrice);
            Assert.AreEqual("Venecia -25zł", name.VenecPrice);

            Assert.AreEqual("Podwójny Ser", name.DoubelCheese);
            Assert.AreEqual("Salami", name.Salami);
            Assert.AreEqual("Szynka", name.Ham);
            Assert.AreEqual("Pieczarki", name.Mushrooms);


            Assert.AreEqual("Podwójny Ser -2zł", name.DoubelCheesePrice);
            Assert.AreEqual("Salami -2zł", name.SalamiPrice);
            Assert.AreEqual("Szynka -2zł", name.HamPrice);
            Assert.AreEqual("Pieczarki -2zł", name.MushroomsPrice);


            Assert.AreEqual("Schabowy z frytkami/ryżem/ziemniakami", name.Schnitzel);
            Assert.AreEqual("Ryba z frytkami", name.Fish);
            Assert.AreEqual("Placek po węgiersku", name.Potato);

            Assert.AreEqual("Schabowy z frytkami/ryżem/ziemniakami -30zł", name.SchnitzelPrice);
            Assert.AreEqual("Ryba z frytkami -28zł", name.FishPrice);
            Assert.AreEqual("Placek po węgiersku -27zł", name.PotatoPrice);

            Assert.AreEqual("Bar sałatkowy", name.Bar);
            Assert.AreEqual("Zestaw sosów", name.SetOfSauces);
            Assert.AreEqual("Bar sałatkowy -5zł", name.BarPrice);
            Assert.AreEqual("Zestaw sosów -6zł", name.SetOfSaucesPrice);


            Assert.AreEqual("Pomidorowa", name.Tomato);
            Assert.AreEqual("Rosół", name.ChickenSoup);
            Assert.AreEqual("Pomidorowa -12zł", name.TomatoPrice);
            Assert.AreEqual("Rosół -10zł", name.ChickenSoupPrice);

            Assert.AreEqual("Kawa", name.Coffee);
            Assert.AreEqual("Herbata", name.Tea);
            Assert.AreEqual("Cola", name.Cola);
            Assert.AreEqual("Kawa -5zł", name.CoffeePrice);
            Assert.AreEqual("Herbata -5zł", name.TeaPrice);
            Assert.AreEqual("Cola -5zł", name.ColaPrice);


            Assert.AreEqual("nadacwca", name.Sender);
            Assert.AreEqual("hasło", name.Password);
            Assert.AreEqual("smtp", name.Smtp);
            Assert.AreEqual("port", name.Port);
            Assert.AreEqual("odbiorca", name.Recipient);
        }
    }
}
