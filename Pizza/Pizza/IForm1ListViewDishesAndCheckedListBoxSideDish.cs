using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    interface IForm1ListViewDishesAndCheckedListBoxSideDish
    {
        ListView ListViewDishes { get; set; }

        CheckedListBox CheckedListBoxSideDish { get; set; }
    }
}
