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
    public partial class GrypControl : UserControl
    {
        public GrypControl()
        {
            InitializeComponent();
            //GrypSortirovka.DropDownStyle = ComboBoxStyle.DropDownList;
            GrypPoiskSpecly.DropDownStyle = ComboBoxStyle.DropDownList;
            GrypPoiskKyrs.DropDownStyle = ComboBoxStyle.DropDownList;
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
            MainAction();
            Functional.Filtres(tags.ToArray(), "Группы с такими критериями нет");
            //GrypSortirovka.SelectedIndex = 0;
            Functional.Print(ref GrypGrid);
        }
    }
}
