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
            Checkai();
            
            //LabelKolB.Text = kolvo.ToString();
            //LabelKolK.Text = (Convert.ToInt32(LabelKolS.Text) - kolvo).ToString();
        }

        public virtual void Checkai()
        {
            int[] mas = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < DispGrid.RowCount; i++)
            {
                switch (DispGrid["D_sem", i].Value.ToString())
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
                    case "4":
                        mas[3]++;
                        break;
                    case "5":
                        mas[4]++;
                        break;
                    case "6":
                        mas[5]++;
                        break;
                    case "7":
                        mas[6]++;
                        break;
                    case "8":
                        mas[7]++;
                        break;
                }
            }
            LabelKolvoVsego.Text = DispGrid.RowCount.ToString();
            LabelKolvo1.Text = (mas[0]).ToString();
            LabelKolvo2.Text = (mas[1]).ToString();
            LabelKolvo3.Text = (mas[2]).ToString();
            LabelKolvo4.Text = (mas[3]).ToString();
            LabelKolvo5.Text = (mas[4]).ToString();
            LabelKolvo6.Text = (mas[5]).ToString();
            LabelKolvo7.Text = (mas[6]).ToString();
            LabelKolvo8.Text = (mas[7]).ToString();
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
            this.DispGrid.Sort(this.DispGrid.Columns["D_shifr"], ListSortDirection.Ascending);
            Checkai();
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

        private void BtnFncChange_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(DispGrid))
            {
                OpenForm(new FormAddChangeDisp(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(Functional.GetId(DispGrid)))));
                Actions();
            }
        }

        private void BtnFncDelete_Click(object sender, EventArgs e)
        {
            if (Functional.RowTest(DispGrid, false))
            {
                if (Functional.Controller.GetAllFrom(SpecialSqlController.Tables.yspeh, "`P_id`=" + Functional.GetId(DispGrid)).Count == 0)
                {
                    Functional.Delete(DispGrid, SpecialSqlController.Tables.disp);
                    Actions();
                }
                else
                {
                    Functional.Error("Вы не можете удалить предмет, так как есть успеваемость с ним. \n Удалите успеваемости с этим предметом и всё будет нормик");
                }
            }
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintDisp(DispGrid, false));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrintDisp(DispGrid));
        }
    }
}
