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
    public partial class GrypControl : UserControl
    {
        public GrypControl()
        {
            InitializeComponent();
            //GrypSortirovka.DropDownStyle = ComboBoxStyle.DropDownList;
            GrypPoiskSpecly.DropDownStyle = ComboBoxStyle.DropDownList;
            GrypPoiskKyrs.DropDownStyle = ComboBoxStyle.DropDownList;
            Actions();
            Functional.GetData(SpecialSqlController.Tables.gryp, delegate (ref List<Dictionary<string, string>> poka)
            {
                List<string> l = new List<string>();
                int k = 0;
                foreach (var i in poka)
                {
                    if (!l.Contains(i["Sp_id"]))
                    {
                        l.Add(i["Sp_id"]);
                        k++;
                    }
                }
                for (int i = 0; i < k; i++)
                    GrypPoiskSpecly.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.specly, int.Parse(l[i]))["Sp_name"]);
            });
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
            Functional.GetData(SpecialSqlController.Tables.gryp, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    if ((i["Sp_id"] != null) && (i["Sp_id"].Length > 0))
                        i["Sp_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.specly, int.Parse(i["Sp_id"]))["Sp_name"];
                    if ((i["P_id"] != null) && (i["P_id"].Length > 0))
                        i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];

                }
                //foreach (var i in privet)
                //{
                //    if ((i["P_id"] != null) && (i["P_id"].Length > 0))
                //        i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];
                //}
            });
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref GrypGrid);
            //GrypSortirovka.SelectedIndex = 1;
            //GrypSortirovka.SelectedIndex = 0;
            GrypPoiskKyrs.SelectedIndex = -1;
            GrypPoiskSpecly.SelectedIndex = -1;
            GrypPoiskKlRyk.Text = "";
            GrypPoiskSpecly.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.specly, "Sp_name", "(select count(`Id`) from gryp g where g.Sp_id=specly.Id)=0", false).ToArray());
        }

        //private void GrypSortirovka_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (GrypSortirovka.SelectedIndex)
        //    {
        //        case 0:
        //            Functional.Sort("Sp_id", 1);
        //            break;
        //        case 1:
        //            Functional.Sort("Sp_id", -1);
        //            break;
        //    }
        //    Functional.Print(ref GrypGrid);
        //}

        private void BtnFncSearch_Click(object sender, EventArgs e)
        {
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { if (row["Sp_id"].ToLower().Replace(" ", "").Contains(GrypPoiskSpecly.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            tags.Add(delegate (Dictionary<string, string> row) { if (row["G_kyrs"].ToLower().Replace(" ", "").Contains(GrypPoiskKyrs.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (GrypPoiskKlRyk.Text!="")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["P_id"].ToLower().Replace(" ", "").Contains(GrypPoiskKlRyk.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            MainAction();
            Functional.Filtres(tags.ToArray(), "Группы с такими критериями нет");
            //GrypSortirovka.SelectedIndex = 0;
            Functional.Print(ref GrypGrid);
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangeGryp());
            Actions();
        }

        private void BtnFncChange_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(GrypGrid))
            {
                OpenForm(new FormAddChangeGryp(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(Functional.GetId(GrypGrid)))));
                Actions();
            }
        }

        private void BtnFncDelete_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(GrypGrid, false))
            {
                if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.stydent, "`G_id`=" + Functional.GetId(GrypGrid)).Count == 0)
                {
                    Functional.Delete(GrypGrid, SpecialSqlController.Tables.gryp);
                    Actions();
                }
                else
                {
                    Functional.Error("Вы не можете удалить это, так как есть студенты в этой группе!");
                }
            }
        }

        private void GrypPoiskKlRyk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }
    }
}
