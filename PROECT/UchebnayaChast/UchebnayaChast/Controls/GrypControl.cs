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
        bool b = true;
        bool par = true;
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
                    GrypPoiskSpecly.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.specly, int.Parse(l[i]))["Sp_nazv"]);
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
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            //int kolvo = 0;
            Functional.GetData(SpecialSqlController.Tables.gryp, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    tags.Add(delegate (Dictionary<string, string> row) { if (row["G_status"].ToLower().Replace(" ", "").Contains("1".ToLower().Replace(" ", ""))) return false; else return true; });
                    i["G_stydentov"] = Functional.Controller.Query("select count(st.Id) from gryp g join stydent st on st.G_id=g.Id where g.Id=" + i["Id"]+" and st.St_status=1")[0][0].ToString();
                        //kolvo += Convert.ToInt32(i["G_stydentov"]);
                        i["G_b"] = Functional.Controller.Query("select count(st.Id) from gryp g join stydent st on st.G_id=g.Id where g.Id=" + i["Id"] + " and st.St_opl='Бюджет'")[0][0].ToString();
                        i["G_k"] = Functional.Controller.Query("select count(st.Id) from gryp g join stydent st on st.G_id=g.Id where g.Id=" + i["Id"] + " and st.St_opl='Контракт'")[0][0].ToString();
                        if ((i["Sp_id"] != null) && (i["Sp_id"].Length > 0))
                            i["Sp_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.specly, int.Parse(i["Sp_id"]))["Sp_nazv"];
                        if ((i["P_id"] != null) && (i["P_id"].Length > 0))
                            i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];

                }
                Functional.Filtres(tags.ToArray(), "Выпущенных групп нет!");
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
            LabelKolvo.Text = GrypGrid.RowCount.ToString();
            //GrypSortirovka.SelectedIndex = 1;
            //GrypSortirovka.SelectedIndex = 0;
            GrypPoiskKyrs.SelectedIndex = -1;
            GrypPoiskSpecly.SelectedIndex = -1;
            GrypPoiskKlRyk.Text = "";
            GrypPoiskSpecly.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.specly, "Sp_nazv", "(select count(`Id`) from gryp g where g.Sp_id=specly.Id)=0", false).ToArray());
            this.GrypGrid.Sort(this.GrypGrid.Columns["Sp_id"], ListSortDirection.Ascending);
            
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
            this.GrypGrid.Sort(this.GrypGrid.Columns["Sp_id"], ListSortDirection.Ascending);
            LabelKolvo.Text = GrypGrid.RowCount.ToString();
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
                    Functional.Error("Вы не можете удалить группу, так как есть студенты в ней!");
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

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintGryp(GrypGrid, false));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintGryp(GrypGrid));
        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Вы действительно хотите перевести все группы на следующий курс?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        
                        if ((DateTime.Now.Month > 5) && (DateTime.Now.Month < 9))
                        {
                            if (par)
                            {
                                b = true;
                            }

                            par = false;
                        }
                        else
                        {
                            if (DateTime.Now.Month >= 9)
                            {
                                par = true;
                            }

                            b = false;
                        }

                        if (b)
                        {
                            Functional.Controller.Query("update gryp g set g.g_status=0 where g.g_kyrs=4;");
                            Functional.Controller.Query("update gryp g set g.g_kyrs=g.g_kyrs+1 where g.g_status=1;");
                            Functional.Controller.Query("update gryp g set g.P_id=null where g.G_status=0;");
                            Functional.Controller.Query("update stydent st set st.St_status=2 where (select g.Id from gryp g where g.G_status=0)=st.G_id;");

                            b = false;
                            par = false;
                        }
                        else
                        {
                            MessageBox.Show("Вы можете перевести группы на следующий курс только следующим летом!");
                        }
                        break;
                    }
                case DialogResult.No: break;
            }

            Actions();
        }

        private void BtnDoneGryp_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintGryp(GrypGrid, "1", true));
        }
    }
}
