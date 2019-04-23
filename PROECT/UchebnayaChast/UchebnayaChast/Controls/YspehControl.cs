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
    public partial class YspehControl : UserControl
    {
        public YspehControl()
        {
            InitializeComponent();
            Actions();
        }

        public virtual void MainAction()
        {
            Functional.GetData(SpecialSqlController.Tables.yspeh, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    i["Y_data"] = Convert.ToDateTime(i["Y_data"]).ToShortDateString();
                    if ((i["St_id"] != null) && (i["St_id"].Length > 0))
                        i["St_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(i["St_id"]))["St_fio"];
                    if ((i["P_id"] != null) && (i["P_id"].Length > 0))
                        i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];
                    if ((i["D_id"] != null) && (i["D_id"].Length > 0))
                        i["D_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(i["D_id"]))["D_name"];
                }
            });
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref YspehGrid);
            YspehPoiskDisp.Text = "";
            YspehPoiskPrepod.Text = "";
            YspehPoiskStydent.Text = "";
            this.YspehGrid.Sort(this.YspehGrid.Columns["St_id"], ListSortDirection.Ascending);
        }
    }
}
