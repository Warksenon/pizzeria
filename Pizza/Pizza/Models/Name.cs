using System.Configuration;

namespace Pizza
{
    public class Name
    {
        public string GetNameConfig(string key)
        {
            string name = ConfigurationManager.AppSettings[key];
            HelpFinding help = new HelpFinding();
            if (help.CheckStringIsNotEmpty(name))
            {
                return name;
            }
            else return name = "name retrieval error: " + key;
        }

        public string LMenuInfoPizza
        {
            get
            {
                return GetNameConfig("lMenuInfoPizza");
            }
        }

        public string LMenuInfoMainDish
        {
            get
            {
                return GetNameConfig("lMenuInfoMainDish");
            }
        }

        public string LMenuInfoSoups
        {
            get
            {
                return GetNameConfig("lMenuInfoSoups");
            }
        }

        public string LMenuInfoDrinks
        {
            get
            {
                return GetNameConfig("lMenuInfoDrinks");
            }
        }

        public string PriceAll
        {
            get
            {
               return GetNameConfig("priceAll");
            }
        }

        public string Dishes
        {
            get
            {
                return GetNameConfig("dishes");
            }
        }

        public string IdPrice
        {
            get
            {
                return GetNameConfig("idPrice");
            }
        }

        public string Comments
        {
            get
            {
                return GetNameConfig("comments");
            }
        }

        public string Id
        {
            get
            {
                return GetNameConfig("id");
            }
        }

        public string SidesDishes
        {
            get
            {
                return GetNameConfig("sidesDishes");
            }
        }

        public string Date
        {
            get
            {
                return GetNameConfig("Date");
            }
        }

        public string Price
        {
            get
            {
                return GetNameConfig("Price");
            }
        }

        public string Dish
        {
            get
            {
                return GetNameConfig("Dish");
            }
        }

        public string PriceForDish
        {
            get
            {
                return GetNameConfig("priceForDish");
            }
        }

        public string HashSigns51
        {
            get
            {
                return GetNameConfig("hashSigns51");
            }
        }

        public string CommentsMessag
        {
            get
            {
                return GetNameConfig("commentsMessag");
            }
        }

        public string BeginningOfOrderCode
        {
            get
            {
                return GetNameConfig("beginningOfOrderCode");
            }
        }
        public string EndOfOrderCode
        {
            get
            {
                return GetNameConfig("endOfOrderCode");
            }
        }

        public string PriceAllBeginning
        {
            get
            {
                return GetNameConfig("priceAllBeginning");
            }
        }

        public string PriceAllEnd
        {
            get
            {
                return GetNameConfig("priceAllEnd");
            }
        }

        public string DishBeginning
        {
            get
            {
                return GetNameConfig("dishBeginning");
            }
        }

        public string DishEnd
        {
            get
            {
                return GetNameConfig("dishEnd");
            }
        }

        public string NPrice
        {
            get
            {
                return GetNameConfig("nPrice");
            }
        }

        public string Pizza
        {
            get
            {
                return GetNameConfig("pizza");
            }
        }

        public string Denmark
        {
            get
            {
                return GetNameConfig("denmark");
            }
        }

        public string Soups
        {
            get
            {
                return GetNameConfig("soups");
            }
        }

        public string Drinks
        {
            get
            {
                return GetNameConfig("drinks");
            }
        }

        public string Margh
        {
            get
            {
                return GetNameConfig("margh");
            }
        }

        public string Veget
        {
            get
            {
                return GetNameConfig("veget");
            }
        }

        public string Tosca
        {
            get
            {
                return GetNameConfig("tosca");
            }
        }

        public string Venec
        {
            get
            {
                return GetNameConfig("venec");
            }
        }

        public string MarghPrice
        {
            get
            {
                return GetNameConfig("marghPrice");
            }
        }

        public string VegetPrice
        {
            get
            {
                return GetNameConfig("vegetPrice");
            }
        }

        public string ToscaPrice
        {
            get
            {
                return GetNameConfig("toscaPrice");
            }
        }

        public string VenecPrice
        {
            get
            {
                return GetNameConfig("venecPrice");
            }
        }

        public string DoubelCheese
        {
            get
            {
                return GetNameConfig("doubelCheese");
            }
        }

        public string Salami
        {
            get
            {
                return GetNameConfig("salami");
            }
        }

        public string Ham
        {
            get
            {
                return GetNameConfig("ham");
            }
        }
     
        public string Mushrooms
        {
            get
            {
                return GetNameConfig("mushrooms");
            }
        }

        public string DoubelCheesePrice
        {
            get
            {
                return GetNameConfig("doubelCheesePrice");
            }
        }

        public string SalamiPrice
        {
            get
            {
                return GetNameConfig("salamiPrice");
            }
        }

        public string HamPrice
        {
            get
            {
                return GetNameConfig("hamPrice");
            }
        }

        public string MushroomsPrice
        {
            get
            {
                return GetNameConfig("mushroomsPrice");
            }
        }

        public string Schnitzel
        {
            get
            {
                return GetNameConfig("schnitzel");
            }
        }

        public string Fish
        {
            get
            {
                return GetNameConfig("fish");
            }
        }

        public string Potato
        {
            get
            {
                return GetNameConfig("potato");
            }
        }

        public string SchnitzelPrice
        {
            get
            {
                return GetNameConfig("schnitzelPrice");
            }
        }

        public string FishPrice
        {
            get
            {
                return GetNameConfig("fishPrice");
            }
        }

        public string PotatoPrice
        {
            get
            {
                return GetNameConfig("potatoPrice");
            }
        }

        public string Bar
        {
            get
            {
                return GetNameConfig("bar");
            }
        }

        public string SetOfSauces
        {
            get
            {
                return GetNameConfig("setOfSauces");
            }
        }

        public string BarPrice
        {
            get
            {
                return GetNameConfig("barPrice");
            }
        }

        public string SetOfSaucesPrice
        {
            get
            {
                return GetNameConfig("setOfSaucesPrice");
            }
        }

        public string Tomato
        {
            get
            {
                return GetNameConfig("tomato");
            }
        }

        public string ChickenSoup
        {
            get
            {
                return GetNameConfig("chickenSoup");
            }
        }

        public string TomatoPrice
        {
            get
            {
                return GetNameConfig("tomatoPrice");
            }
        }

        public string ChickenSoupPrice
        {
            get
            {
                return GetNameConfig("chickenSoupPrice");
            }
        }

        public string Coffee
        {
            get
            {
                return GetNameConfig("coffee");
            }
        }

        public string Tea
        {
            get
            {
                return GetNameConfig("tea");
            }
        }

        public string Cola
        {
            get
            {
                return GetNameConfig("cola");
            }
        }

        public string CoffeePrice
        {
            get
            {
                return GetNameConfig("coffeePrice");
            }
        }

        public string TeaPrice
        {
            get
            {
                return GetNameConfig("teaPrice");
            }
        }

        public string ColaPrice
        {
            get
            {
                return GetNameConfig("colaPrice");
            }
        }

        public string Sender
        {
            get
            {
                return GetNameConfig("sender");
            }
        }

        public string Password
        {
            get
            {
                return GetNameConfig("password");
            }
        }

        public string Smtp
        {
            get
            {
                return GetNameConfig("smtp");
            }
        }

        public string Port
        {
            get
            {
                return GetNameConfig("port");
            }
        }

        public string Recipient
        {
            get
            {
                return GetNameConfig("recipient");
            }
        }

    }
}
