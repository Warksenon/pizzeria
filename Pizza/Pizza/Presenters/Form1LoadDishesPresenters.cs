using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.Presenters
{
    class Form1LoadDishesPresenters
    {
       private ListOfDishes listOfDishes = new ListOfDishes();
       private IForm1ListViewDishesAndCheckedListBoxSideDish form1;

       public Form1LoadDishesPresenters(IForm1ListViewDishesAndCheckedListBoxSideDish view)
        {
            form1 = view;
        }

        public void LoadPizza()
        {
           AddDishesToListView(listOfDishes.LoadListPizza());
        }

        public void LoadMainDish()
        {
           AddDishesToListView(listOfDishes.LoadListMainDish());
        }

        public void LoadSoups()
        {
           AddDishesToListView(listOfDishes.LoadListSoups());
        }

        public void LoadDrinks()
        {
           AddDishesToListView(listOfDishes.LoadListDrinks());
        }

      


        private void AddDishesToListView (List<Dish> listDisch)
        {
            form1.ListViewDishes.Items.Clear();
            foreach (var disch in listDisch)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
                lvi.SubItems.Add(disch.Price);
                form1.ListViewDishes.Items.Add(lvi);
            }
        }

        LoadListOfSideDishes loadListOfSideDishes = new LoadListOfSideDishes();

        public void LoadSidesDishPizza()
        {
           LoadCheckListBoxSideDishe(loadListOfSideDishes.LoadSidePizza());
        }

        public void LoadSidesDishMainDish()
        {
           LoadCheckListBoxSideDishe(loadListOfSideDishes.LoadSideMainDish());
        }

        private  void  LoadCheckListBoxSideDishe(List<string> sideDishes)
        {
            form1.CheckedListBoxSideDish.Items.Clear();
            foreach (var st in sideDishes)
            {
                form1.CheckedListBoxSideDish.Items.Add(st);
            }          
        }

        public void ClearCheckListBoxSideDishe()
        {
            form1.CheckedListBoxSideDish.Items.Clear();
        }
    }
}
