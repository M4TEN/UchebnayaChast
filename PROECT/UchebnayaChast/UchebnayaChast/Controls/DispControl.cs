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
    public partial class DispControl : UserControl
    {
        public DispControl()
        {
            InitializeComponent();
            DispPoiskType.DropDownStyle = ComboBoxStyle.DropDownList;
            DispPoiskSem.DropDownStyle = ComboBoxStyle.DropDownList;
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
            DispPoiskType.SelectedIndex = -1;
            DispPoiskSem.SelectedIndex = -1;
            this.DispGrid.Sort(this.DispGrid.Columns["D_shifr"], ListSortDirection.Ascending);
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

        private void DispPoiskName_KeyPress(object sender, KeyPressEventArgs e)
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
            if (DispPoiskName.Text!="")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["D_name"].ToLower().Replace(" ", "").Contains(DispPoiskName.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (DispPoiskType.SelectedIndex>-1)
                tags.Add(delegate (Dictionary<string, string> row) { if (row["D_type"].ToLower().Replace(" ", "").Equals(DispPoiskType.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (DispPoiskSem.SelectedIndex > -1)
                tags.Add(delegate (Dictionary<string, string> row) { if (row["D_sem"].ToLower().Replace(" ", "").Equals(DispPoiskSem.Text.ToLower().Replace(" ", ""))) return false; else return true; });

            MainAction();
            Functional.Filtres(tags.ToArray(), "Дисциплины с такими критериями нет");
            //PrepodSortirovka.SelectedIndex = 0;
            Functional.Print(ref DispGrid);
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangeDisp());
            Actions();
        }
    }
}
