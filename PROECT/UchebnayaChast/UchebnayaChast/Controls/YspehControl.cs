using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchebnayaChast.FormAddChange;

namespace UchebnayaChast
{
    public partial class YspehControl : UserControl
    {
        public YspehControl()
        {
            InitializeComponent();
            Actions();
        }

        protected void OpenForm(Form form, bool show = true, bool hide = false, bool close = false, bool dialog = true)
        {
            if (hide)
                this.Hide();
            if (dialog)
                form.ShowDialog();
            else
            {
                form.Show();
                this.Hide();
            }

            if (show && hide) this.Show();
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

        private void YspehPoiskStydent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void YspehPoiskPrepod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void YspehPoiskDisp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void BtnFncSearch_Click(object sender, EventArgs e)
        {
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            if (YspehPoiskStydent.Text!="")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["St_id"].ToLower().Replace(" ", "").Contains(YspehPoiskStydent.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (YspehPoiskPrepod.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["P_id"].ToLower().Replace(" ", "").Contains(YspehPoiskPrepod.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (YspehPoiskDisp.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["D_id"].ToLower().Replace(" ", "").Contains(YspehPoiskDisp.Text.ToLower().Replace(" ", ""))) return false; else return true; });

            MainAction();
            Functional.Filtres(tags.ToArray(), "Успеваемости с такими критериями нет");
            //PrepodSortirovka.SelectedIndex = 0;
            Functional.Print(ref YspehGrid);
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangeYspeh());
            Actions();
        }
    }
}
