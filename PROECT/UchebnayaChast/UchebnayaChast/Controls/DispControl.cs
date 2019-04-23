using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebnayaChast
{
    public partial class DispControl : UserControl
    {
        public DispControl()
        {
            InitializeComponent();
            DispPoiskType.DropDownStyle = ComboBoxStyle.DropDownList;
            Actions();
        }

        public virtual void MainAction()
        {
            Functional.GetData(SpecialSqlController.Tables.disp, delegate (ref List<Dictionary<string, string>> privet) { });
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref DispGrid);
            DispPoiskName.Text = "";
            this.DispGrid.Sort(this.DispGrid.Columns["D_shifr"], ListSortDirection.Ascending);
        }
    }
}
