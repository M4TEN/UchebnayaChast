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
    public partial class KafedraControl : UserControl
    {
        public KafedraControl()
        {
            InitializeComponent();
            //KafedraSortirovka.DropDownStyle = ComboBoxStyle.DropDownList;
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
            Functional.GetData(SpecialSqlController.Tables.kafedra);
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref KafedraGrid);
            //KafedraSortirovka.SelectedIndex = 1;
            //KafedraSortirovka.SelectedIndex = 0;
            KafedraPoisk.Text = "";
            this.KafedraGrid.Sort(this.KafedraGrid.Columns["K_name"], ListSortDirection.Ascending);
        }
        //private void KafedraSortirovka_SelectedIndexChanged(object sender, EventArgs e)
        //            {
        //                switch (KafedraSortirovka.SelectedIndex)
        //                {
        //                    case 0:
        //            Functional.Sort("K_name", 1);
        //                        break;
        //                    case 1:
        //            Functional.Sort("K_name", -1);
        //                        break;
        //                }
        //    Functional.Print(ref KafedraGrid);
        //            }

        private void BtnFncSearch_Click(object sender, EventArgs e)
        {
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { if (row["K_name"].ToLower().Replace(" ", "").Contains(KafedraPoisk.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            MainAction();
            Functional.Filtres(tags.ToArray(), "Кафедр(-ы) с такими критериями нет");
            //KafedraSortirovka.SelectedIndex = 0;
            Functional.Print(ref KafedraGrid);
        }


        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangeKafedra());
            Actions();
        }

        private void BtnFncChange_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(KafedraGrid))
            {
                OpenForm(new FormAddChangeKafedra(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.kafedra, int.Parse(Functional.GetId(KafedraGrid)))));
                Actions();
            }
        }

        private void BtnFncDelete_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(KafedraGrid, false))
            {
                if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod, "`K_id`=" + Functional.GetId(KafedraGrid)).Count == 0)
                {
                    Functional.Delete(KafedraGrid, SpecialSqlController.Tables.kafedra);
                    Actions();
                }
                else
                {
                    Functional.Error("Вы не можете удалить эту хрень :)");
                }
            }
        }

        private void KafedraPoisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }
    }
}
