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
    public partial class PrepodControl : UserControl
    {
        public PrepodControl()
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
            Functional.GetData(SpecialSqlController.Tables.prepod, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    if ((i["K_id"] != null) && (i["K_id"].Length > 0))
                        i["K_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.kafedra, int.Parse(i["K_id"]))["K_name"];
                }
            });


        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref PrepodGrid);
            //PrepodSortirovka.SelectedIndex = 1;
            //PrepodSortirovka.SelectedIndex = 0;
            PrepodPoisk.Text = "";
            this.PrepodGrid.Sort(this.PrepodGrid.Columns["P_fio"], ListSortDirection.Ascending);
        }

        //private void PrepodSortirovka_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    {
        //        switch (PrepodSortirovka.SelectedIndex)
        //        {
        //            case 0:
        //                Functional.Sort("P_fio", 1);
        //                break;
        //            case 1:
        //                Functional.Sort("P_fio", -1);
        //                break;
        //        }
        //        Functional.Print(ref PrepodGrid);
        //    }
        //}

        private void BtnFncSearch_Click(object sender, EventArgs e)
        {
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { if (row["P_fio"].ToLower().Replace(" ", "").Contains(PrepodPoisk.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            MainAction();
            Functional.Filtres(tags.ToArray(), "Преподавателя с такими критериями нет");
            //PrepodSortirovka.SelectedIndex = 0;
            Functional.Print(ref PrepodGrid);
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void BtnFncAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAddChangePrepod());
            Actions();
        }

        private void BtnFncDelete_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(PrepodGrid, false))
            {
                if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.gryp, "`P_id`=" + Functional.GetId(PrepodGrid)).Count == 0)
                {
                    Functional.Delete(PrepodGrid, SpecialSqlController.Tables.prepod);
                    Actions();
                }
                else
                {
                    Functional.Error("Вы не можете удалить преподавателя, так как есть группы с его кураторством!");
                }
            }
        }

        private void BtnFncChange_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(PrepodGrid))
            {
                OpenForm(new FormAddChangePrepod(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(Functional.GetId(PrepodGrid)))));
                Actions();
            }
        }

    }
}
