using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    interface IForm1Order
    {
        TextBox TextBoxQuantityDishes { get; set; }

        ListView ListViewOrder { get; set; }

        Label LabelPrice { get; set; }

        BackgroundWorker BackgroundWorker { get; set;}

        TextBox TextBoxComments { get; set; }
    }
}
