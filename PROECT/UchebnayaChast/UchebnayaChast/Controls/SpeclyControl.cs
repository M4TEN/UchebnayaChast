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
    public partial class SpeclyControl : UserControl
    {
        public SpeclyControl()
        {
            InitializeComponent();
            //SpeclySortirovka.DropDownStyle = ComboBoxStyle.DropDownList;
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
            Functional.GetData(SpecialSqlController.Tables.specly, delegate(ref List<Dictionary<string,string>> privet) {
                foreach(var i in privet)
                {
                    if ((i["P_id"]!=null)&&(i["P_id"].Length>0))
                    i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];
                }
            });
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref SpeclyGrid);
            //SpeclySortirovka.SelectedIndex = 1;
            //SpeclySortirovka.SelectedIndex = 0;
            SpeclyPoisk.Text = "";
            this.SpeclyGrid.Sort(this.SpeclyGrid.Columns["Sp_name"], ListSortDirection.Ascending);
        }

        //private void SpeclySortirovka_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    {
        //        switch (SpeclySortirovka.SelectedIndex)
        //        {
        //            case 0:
        //                Functional.Sort("Sp_name", 1);
        //                break;
        //            case 1:
        //                Functional.Sort("Sp_name", -1);
        //                break;
        //        }
        //        Functional.Print(ref SpeclyGrid);
        //    }
        //}

        private void BtnFncSearch_Click(object sender, EventArgs e)
        {
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { if (row["Sp_name"].ToLower().Replace(" ", "").Contains(SpeclyPoisk.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            MainAction();
            Functional.Filtres(tags.ToArray(), "Специальности с такими критериями нет");
            //SpeclySortirovka.SelectedIndex = 0;
            Functional.Print(ref SpeclyGrid);
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangeSpecly());
            Actions();
        }

        private void BtnFncChange_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(SpeclyGrid))
            {
                OpenForm(new FormAddChangeSpecly(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.specly, int.Parse(Functional.GetId(SpeclyGrid)))));
                Actions();
            }
        }

        private void BtnFncDelete_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(SpeclyGrid, false))
            {
                if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.gryp, "`Sp_id`=" + Functional.GetId(SpeclyGrid)).Count == 0)
                {
                    Functional.Delete(SpeclyGrid, SpecialSqlController.Tables.specly);
                    Actions();
                }
                else
                {
                    Functional.Error("Вы не можете удалить это, так как есть группы с данной специальностью!");
                }
            }
        }

        private void SpeclyPoisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }
    }
}
