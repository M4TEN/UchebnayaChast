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
        //public virtual void Sortirovochka() { }
        public virtual void Sortirovochka()
        {
            this.PrepodGrid.Sort(this.PrepodGrid.Columns["P_fio"], ListSortDirection.Ascending);
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
            PrepodCheck();
        }

        public virtual void PrepodCheck()
        {
            int[] mas = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < PrepodGrid.RowCount; i++)
            {
                switch (PrepodGrid["P_kategory", i].Value.ToString())
                {
                    case "1":
                        mas[0]++;
                        break;
                    case "2":
                        mas[1]++;
                        break;
                    case "3":
                        mas[2]++;
                        break;
                }
            }
            LabelKolvoVsego.Text = PrepodGrid.RowCount.ToString();
            LabelKolvo1.Text = (mas[0]).ToString();
            LabelKolvo2.Text = (mas[1]).ToString();
            LabelKolvo3.Text = (mas[2]).ToString();
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
            this.PrepodGrid.Sort(this.PrepodGrid.Columns["P_fio"], ListSortDirection.Ascending);
            PrepodCheck();
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
                    if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.kafedra, "`P_id`=" + Functional.GetId(PrepodGrid)).Count == 0)
                    {
                        if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.specly, "`P_id`=" + Functional.GetId(PrepodGrid)).Count == 0)
                        {
                            if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.yspeh, "`P_id`=" + Functional.GetId(PrepodGrid)).Count == 0)
                            {
                                Functional.Delete(PrepodGrid, SpecialSqlController.Tables.prepod);
                                Actions();
                            }
                            else
                            {
                                Functional.Error("Вы не можете удалить преподавателя, так как есть успеваемость с его участием! \n Удалите эту успеваемость \n Либо передайте успеваемость дисциплины другому преподавателю");
                            }
                        }
                        else
                        {
                            Functional.Error("Вы не можете удалить преподавателя, так как есть специальности с его кураторством! \n Поменяйте куратора данной специальности \n Либо удалите данную специальность");
                        }
                    }
                    else
                    {
                        Functional.Error("Вы не можете удалить преподавателя, так как есть кафедры с его кураторством! \n Поменяйте куратора данной кафедры \n Либо удалите данную кафедру");
                    }
                }
                else
                {
                    Functional.Error("Вы не можете удалить преподавателя, так как есть группы с его кураторством! \n Поменяйте классного руководителя \n Либо распустите группу полностью");
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

        private void PrepodPoisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintPrepod(PrepodGrid, false));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintPrepod(PrepodGrid));
        }
    }
}
