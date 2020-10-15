using Pizza.Presenters;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Pizza
{

    public partial class Form1 : Form , IForm1ListViewDishesAndCheckedListBoxSideDish, IForm1Order
    {
        public Form1 form1;

        public Form1()
        { 
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;            
        }

        Form1OrderPresenters orderPresenters ;
        private Form1LoadDishesPresenters loadPresenters;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            orderPresenters = new Form1OrderPresenters(this, this);
            loadPresenters = new Form1LoadDishesPresenters(this);
            Start(ButtonMenu.Pizza);
            loadPresenters.LoadPizza();
            loadPresenters.LoadSidesDishPizza();
            SetVisibleButtonRemoveAll();
            SetVisibleButtonRemove();
            form1 = this;

            SqlLite.CreateTabeles createTabeles = new SqlLite.CreateTabeles();
            createTabeles.CreateSQLiteTables();        
        }
      
        public ListView ListViewDishes { get => listViewDish; set => listViewDish = value; }
        public CheckedListBox CheckedListBoxSideDish { get => chListBoxSideDishes; set => chListBoxSideDishes = value; }

        public TextBox TextBoxQuantityDishes { get => textBoxQuantityDishes; set => textBoxQuantityDishes = value; }
        public ListView ListViewOrder { get => listViewOrder; set => listViewOrder = value; }
        public Label LabelPrice { get => lPrice; set => lPrice = value; }
        public BackgroundWorker BackgroundWorker { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public TextBox TextBoxComments { get => tComments; set => tComments = value; }

        public enum ButtonMenu
        {
            Pizza,
            MainDish,
            Soups,
            Drinks
        }

        private void Start(ButtonMenu en)
        {
            ClearColorButton();
            switch (en)
            {
                case ButtonMenu.Pizza: PizzaButtonSettings(en);
                    break;
                case ButtonMenu.MainDish: MainDishButtonSettings(en);
                    break;
                case ButtonMenu.Soups: SoupsButtonSettings(en);
                    break;
                case ButtonMenu.Drinks: DrinkseButtonSettings(en);
                    break;
            }
        }

        private void PizzaButtonSettings(ButtonMenu en)
        {
            bPizza.BackColor = Color.LawnGreen;        
            ChengeNameLabelMenuInfo(en);
            SetVisibleButtonDishesOK(false);
            SetVisibleTextViewDishesQuantity(false);
        }

        private void MainDishButtonSettings(ButtonMenu en)
        {
            bMainDish.BackColor = Color.LawnGreen;         
            ChengeNameLabelMenuInfo(en);
            SetVisibleButtonDishesOK(false);
            SetVisibleTextViewDishesQuantity(false);
        }

        private void SoupsButtonSettings(ButtonMenu en)
        {
            bSoups.BackColor = Color.LawnGreen;         
            ChengeNameLabelMenuInfo(en);
            SetVisibleButtonDishesOK(false);
            SetVisibleTextViewDishesQuantity(false);
        }

        private void DrinkseButtonSettings(ButtonMenu en)
        {
            bDrinks.BackColor = Color.LawnGreen;         
            ChengeNameLabelMenuInfo(en);
            SetVisibleButtonDishesOK(false);
            SetVisibleTextViewDishesQuantity(false);
        }

        private void ClearColorButton()
        {
            bPizza.BackColor = SystemColors.Control;
            bMainDish.BackColor = SystemColors.Control;
            bSoups.BackColor = SystemColors.Control;
            bDrinks.BackColor = SystemColors.Control;
        }

        private void ChengeNameLabelMenuInfo(ButtonMenu en)
        {
            switch (en)
            {
                case ButtonMenu.Pizza: lMenuInfo.Text = "Pizza"; 
                    break;
                case ButtonMenu.MainDish: lMenuInfo.Text = "Dania główne"; 
                    break;
                case ButtonMenu.Soups: lMenuInfo.Text = "Zupy"; 
                    break;
                case ButtonMenu.Drinks: lMenuInfo.Text = "Napoje"; 
                    break;
            }
        }

        private void ButtonPizza_Click(object sender, EventArgs e)
        {
            Start(ButtonMenu.Pizza);
            loadPresenters.LoadPizza();
            loadPresenters.LoadSidesDishPizza();           
        }

        private void ButtonMainDish_Click(object sender, EventArgs e)
        {
           Start(ButtonMenu.MainDish);
           loadPresenters.LoadMainDish();
           loadPresenters.LoadSidesDishMainDish();          
        }

        private void ButtonDrinks_Click(object sender, EventArgs e)
        {
           Start(ButtonMenu.Drinks);
            loadPresenters.LoadDrinks();          
        }

        private void ButtonSoup_Click(object sender, EventArgs e)
        {
            Start(ButtonMenu.Soups);
            loadPresenters.LoadSoups();            
        }



        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            orderPresenters.SubmitOrder();            
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            orderPresenters.AddDishesToListViewOrder();
            SetVisibleButtonRemoveAll();
            orderPresenters.LabelPrice();
            SelectColorbOrder();
        }

        private void SelectColorbOrder()
        {
            if((listViewOrder.Items.Count > 0)|| (backgroundWorker1.IsBusy == true))
            {
                if (listViewOrder.Items.Count > 0) bOrder.BackColor = Color.LawnGreen;
                if (backgroundWorker1.IsBusy == true) bOrder.BackColor = Color.Firebrick;
            }          
            else bOrder.BackColor = SystemColors.Control;
        }

        private void ButtonRemoveListBox_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 0) return;
            listViewOrder.SelectedItems[0].Remove();
            orderPresenters.LabelPrice();           
            SetVisibleButtonRemoveAll();
            SetVisibleButtonRemove();
            bRemoveListBox.Visible = false;
            SelectColorbOrder();
        }

        private void ButtonRemoveAllListBox_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            orderPresenters.LabelPrice();
            SelectColorbOrder();
            SetVisibleButtonRemoveAll();
            SetVisibleButtonRemove();
        }

        private void AddressEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMail fm = new FormMail();
            fm.ShowDialog();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (backgroundWorker1.IsBusy != true)
            {
                FormHistory fm = new FormHistory();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Historia jeszcze nie gotowa", "Przetwarzanie danych");
            }
           
        }
      
        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {        
            SelectColorbOrder();
            orderPresenters.SendEmailAndSaveOrder();          
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SelectColorbOrder();
        }

        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void ListViDania_SelectedIndexChanged(object sender, EventArgs e)
        {
           SetVisibleButtonRemove();
        }

        private void SetVisibleButtonRemove()
        {
            if (CheckingListOrderIfEmpty())
            {
                bRemoveListBox.Visible = true;
            }
            else bRemoveListBox.Visible = false;
        }

        private void SetVisibleButtonRemoveAll()
        {
            if (CheckingListOrderIfEmpty())
            {
                bRemoveAllListBox.Visible = true;
            }
            else bRemoveAllListBox.Visible = false;
        }

        private bool CheckingListOrderIfEmpty()
        {
            if (listViewOrder.Items.Count > 0) return true;
            else return false;
        }

        private void ListViewDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetVisibleButtonDishesOK(true);
            SetVisibleTextViewDishesQuantity(true);     
        }

        private void SetVisibleButtonDishesOK(bool visable)
        {
            if (visable) bAddDish.Visible = true;
            else
            {
                CleaningTextViewDishesQuantity();
                bAddDish.Visible = false;
            }         
        }

        private void SetVisibleTextViewDishesQuantity(bool visalbe)
        {
            if (visalbe) textBoxQuantityDishes.Visible = true;            
            else
            {
                CleaningTextViewDishesQuantity();
                textBoxQuantityDishes.Visible = false;
            }
        }

        private void CleaningTextViewDishesQuantity()
        {
            textBoxQuantityDishes.Text = "1";
        }

    }
}
