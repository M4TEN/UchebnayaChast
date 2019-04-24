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
            StydentPoiskBK.DropDownStyle = ComboBoxStyle.DropDownList;

            Functional.GetData(SpecialSqlController.Tables.stydent, delegate (ref List<Dictionary<string, string>> poka)
            {
                List<string> l=new List<string>();
                int k = 0;
                foreach (var i in poka)
                {
                    if ((i["G_id"] != null) && (i["G_id"].Length > 0))
                    {
                        string s = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + i["Id"] + " limit 1;")))[0][0];
                        i["G_id"] = s + "-" + (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_kyrs"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_number"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_born"]);
                    }
                    if (!l.Contains(i["G_id"]))
                    {
                        l.Add(i["G_id"]);
                        k++;
                    }
                }
                for (int i=0;i<k;i++)
                StydentPoiskGryp.Items.Add(l[i]);
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

            Functional.GetData(SpecialSqlController.Tables.stydent, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    i["St_data"] = Convert.ToDateTime(i["St_data"]).ToShortDateString();
                    i["St_postyp"] = Convert.ToDateTime(i["St_data"]).ToShortDateString();
                    if ((i["G_id"] != null) && (i["G_id"].Length > 0))
                    {
                        string s=(Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id="+i["Id"]+" limit 1;")))[0][0];
                        i["G_id"] =s+ "-" + (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_kyrs"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_number"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_born"]);
                    }
                }
            });
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref StydentGrid);
            //PrepodSortirovka.SelectedIndex = 1;
            //PrepodSortirovka.SelectedIndex = 0;
            StydentPoiskFio.Text = "";
            StydentPoiskBK.SelectedIndex = -1;
            StydentPoiskGryp.SelectedIndex = -1;
            this.StydentGrid.Sort(this.StydentGrid.Columns["G_id"], ListSortDirection.Ascending);
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
            MainAction();
            Functional.Filtres(tags.ToArray(), "Студента с такими критериями нет");
            Functional.Print(ref StydentGrid);
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
    }
}
