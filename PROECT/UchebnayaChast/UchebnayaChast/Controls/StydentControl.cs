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
    public partial class StydentControl : UserControl
    {

        public StydentControl()
        {
            InitializeComponent();
            Actions();
            StydentPoiskGryp.DropDownStyle= ComboBoxStyle.DropDownList;
            StydentPoiskGod.DropDownStyle= ComboBoxStyle.DropDownList;
            StydentPoiskBK.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();

            Functional.GetData(SpecialSqlController.Tables.stydent, delegate (ref List<Dictionary<string, string>> poka)
            {
                
                int k = 0;
                int k2 = 0;
                foreach (var i in poka)
                {
                    tags.Add(delegate (Dictionary<string, string> row) { if (row["St_status"].ToLower().Replace(" ", "").Contains("1".ToLower().Replace(" ", ""))) return false; else return true; });
                        if ((i["G_id"] != null) && (i["G_id"].Length > 0))
                        {
                            string s = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + i["Id"] + " limit 1;")))[0][0];
                            i["G_id"] = s + "-" + (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_kyrs"]) +
                            (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_number"]) +
                            (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_born"]);
                        }
                    //if (i["St_status"] == "1")
                    //{
                    //    if (!l.Contains(i["G_id"]))
                    //    {
                    //        l.Add(i["G_id"]);
                    //        k++;
                    //    }
                    //}
                    //if (i["St_status"] == "1")
                    //{
                    //    if (!g.Contains(Convert.ToDateTime(i["St_data"]).ToString("yyyy")))
                    //    {
                    //        g.Add(Convert.ToDateTime(i["St_data"]).ToString("yyyy"));
                    //        k2++;
                    //    }
                    //}
                }
                Functional.Filtres(tags.ToArray(), "Отчисленных студентов нет!");

                //for (int i=0;i<k;i++)
                //    StydentPoiskGryp.Items.Add(l[i]);
                //for (int i = 0; i < k2; i++)
                //    StydentPoiskGod.Items.Add(g[i]);
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
            List<string> l = new List<string>();
            List<string> g = new List<string>();
            
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();

            Functional.GetData(SpecialSqlController.Tables.stydent, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    tags.Add(delegate (Dictionary<string, string> row) { if (row["St_status"].ToLower().Replace(" ", "").Contains("1".ToLower().Replace(" ", ""))) return false; else return true; });

                    i["St_data"] = Convert.ToDateTime(i["St_data"]).ToShortDateString();
                    i["St_postyp"] = Convert.ToDateTime(i["St_postyp"]).ToShortDateString();
                        if ((i["G_id"] != null) && (i["G_id"].Length > 0))
                        {
                            string s = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + i["Id"] + " limit 1;")))[0][0];
                            i["G_id"] = s + "-" + (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_kyrs"]) +
                            (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_number"]) +
                            (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_born"]);
                        }
                    if (i["St_status"] == "1")
                    {
                        if (!l.Contains(i["G_id"]))
                        {
                            l.Add(i["G_id"]);
                            StydentPoiskGryp.Items.Add(i["G_id"]);
                        }
                    }
                    if (i["St_status"] == "1")
                    {
                        if (!g.Contains(Convert.ToDateTime(i["St_data"]).ToString("yyyy")))
                        {
                            g.Add(Convert.ToDateTime(i["St_data"]).ToString("yyyy"));
                            StydentPoiskGod.Items.Add(Convert.ToDateTime(i["St_data"]).ToString("yyyy"));
                        }
                    }
                }
            });
            StydentPoiskGryp.Sorted = true;
            StydentPoiskGod.Sorted = true;
            Functional.Filtres(tags.ToArray(), "Учащихся студентов нет!");

        }

        public virtual void Actions()
        {
            StydentPoiskGryp.Items.Clear();
            StydentPoiskGod.Items.Clear();
            MainAction();
            Functional.Print(ref StydentGrid);
            //PrepodSortirovka.SelectedIndex = 1;
            //PrepodSortirovka.SelectedIndex = 0;
            StydentPoiskFio.Text = "";
            StydentPoiskZach.Text = "";
            StydentPoiskBK.SelectedIndex = -1;
            StydentPoiskGryp.SelectedIndex = -1;
            StydentPoiskGod.SelectedIndex = -1;
            this.StydentGrid.Sort(this.StydentGrid.Columns["St_fio"], ListSortDirection.Ascending);
            LabelKolS.Text = StydentGrid.RowCount.ToString();
            LabelKolB.Text = (Functional.Controller.Query(("select count(st.Id) from stydent st where st.St_opl='Бюджет' and st.St_status=1")))[0][0];
            LabelKolK.Text = (Functional.Controller.Query(("select count(st.Id) from stydent st where st.St_opl='Контракт' and st.St_status=1")))[0][0];
        }

        private void StydentPoiskFio_KeyPress(object sender, KeyPressEventArgs e)
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
            if (StydentPoiskFio.Text!="")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["St_fio"].ToLower().Replace(" ", "").Contains(StydentPoiskFio.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (StydentPoiskBK.SelectedIndex>-1)
                tags.Add(delegate (Dictionary<string, string> row) { if (row["St_opl"].ToLower().Replace(" ", "").Contains(StydentPoiskBK.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (StydentPoiskGryp.SelectedIndex > -1)
                tags.Add(delegate (Dictionary<string, string> row) { if (row["G_id"].ToLower().Replace(" ", "").Contains(StydentPoiskGryp.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (StydentPoiskGod.SelectedIndex > -1)
                tags.Add(delegate (Dictionary<string, string> row) { if (Convert.ToDateTime(row["St_data"]).ToString("yyyy").ToLower().Replace(" ", "").Contains(StydentPoiskGod.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (StydentPoiskZach.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["St_zach"].ToLower().Replace(" ", "").Contains(StydentPoiskZach.Text.ToLower().Replace(" ", ""))) return false; else return true; });

            MainAction();
            Functional.Filtres(tags.ToArray(), "Студента с такими критериями нет");
            Functional.Print(ref StydentGrid);
            this.StydentGrid.Sort(this.StydentGrid.Columns["St_fio"], ListSortDirection.Ascending);
            LabelKolS.Text = StydentGrid.RowCount.ToString();
            int kolvo = 0;
            for (int i=0; i<StydentGrid.RowCount;i++)
            {
                if (StydentGrid["St_opl", i].Value.ToString() == "Бюджет")
                {
                    kolvo++;
                }
            }
            LabelKolB.Text = kolvo.ToString();
            LabelKolK.Text = (Convert.ToInt32(LabelKolS.Text) - kolvo).ToString();
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangeStydent());
            Actions();
        }

        private void BtnFncChange_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(StydentGrid))
            {
                OpenForm(new FormAddChangeStydent(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(Functional.GetId(StydentGrid)))));
                Actions();
            }
        }

        private void BtnFncDelete_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(StydentGrid))
            {
                DialogResult dr = MessageBox.Show("Вы уверены, что хотите отчислить этого студента?",
                          "Отчисление", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {

                            Dictionary<string, string> l = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(Functional.GetId(StydentGrid)));

                            Functional.Controller.UpdateIn(SpecialSqlController.Tables.stydent, new List<string> { l["G_id"], l["St_fio"], Convert.ToDateTime(l["St_data"]).ToString("yyyyMMdd"), l["St_town"], l["St_adres"], Convert.ToDateTime(l["St_postyp"]).ToString("yyyyMMdd"), l["St_nomer"], l["St_zach"], l["St_opl"], "0" }, l["Id"]);
                            break;
                        }
                    case DialogResult.No: break;
                }
                Actions();
            }
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintStydent(StydentGrid, false));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintStydent(StydentGrid));
        }

        private void BtnStydKicked_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintStydentKicked());
        }

        private void StydentPoiskZach_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
