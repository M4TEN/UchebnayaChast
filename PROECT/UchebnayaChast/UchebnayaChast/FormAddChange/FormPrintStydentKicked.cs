using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Drawing;

namespace UchebnayaChast.FormAddChange
{
    public partial class FormPrintStydentKicked : Form
    {
        string b = "";

        private void yznatimya()
        {
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            string s = (wi.Name);
            int poymal = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\\')
                {
                    poymal = i;
                }
            }

            for (int i = poymal; i < s.Length; i++)
            {
                b += s[i];
            }
            b = @"C:\Users" + b + @"\Desktop\";
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

        public FormPrintStydentKicked()
        {
            InitializeComponent();
            Actions();
            yznatimya();
        }

        public virtual void MainAction()
        {

            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();

            Functional.GetData(SpecialSqlController.Tables.stydent, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {
                    tags.Add(delegate (Dictionary<string, string> row) { if (!row["St_status"].ToLower().Replace(" ", "").Contains("1".ToLower().Replace(" ", ""))) return false; else return true; });

                    i["St_data"] = Convert.ToDateTime(i["St_data"]).ToShortDateString();
                    i["St_postyp"] = Convert.ToDateTime(i["St_data"]).ToShortDateString();
                    if (i["St_status"]=="0")
                    {
                        i["St_vipisk"] = "Отчислен";
                    }
                    else
                    {
                        if (i["St_status"] == "1")
                        {
                            i["St_vipisk"] = "Учится";
                        }
                        else
                            i["St_vipisk"] = "Выпущен";
                    }
                    if ((i["G_id"] != null) && (i["G_id"].Length > 0))
                    {
                        string s = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + i["Id"] + " limit 1;")))[0][0];
                        i["G_id"] = s + "-" + (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_kyrs"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_number"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_born"]);
                    }
                }
            });

            Functional.Filtres(tags.ToArray(), "Отчисленных студентов нет!");

            foreach (DataGridViewRow row in StydentGrid.Rows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    StydentGrid.Rows.Add(items);
                }
        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref StydentGrid);
            //PrepodSortirovka.SelectedIndex = 1;
            //PrepodSortirovka.SelectedIndex = 0;
            this.StydentGrid.Sort(this.StydentGrid.Columns["St_fio"], ListSortDirection.Ascending);
            LabelKolS.Text = StydentGrid.RowCount.ToString();
            LabelKolB.Text = (Functional.Controller.Query(("select count(st.Id) from stydent st where st.St_opl='Бюджет' and st.St_status!=1")))[0][0];
            LabelKolK.Text = (Functional.Controller.Query(("select count(st.Id) from stydent st where st.St_opl='Контракт' and st.St_status!=1")))[0][0];
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnScreen_Click(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(1020, 450);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(Location.X + 5, Location.Y + 5, 0, 0, new Size(1020, 450));

            printscreen.Save(b + DateTime.Now.Millisecond + DateTime.Now.Second + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void BtnRepairStydent_Click(object sender, EventArgs e)
        {
            if ((Functional.RowTest(StydentGrid)))
            {
                if (Functional.Controller.Query("select st.St_status from stydent st where st.Id=" + StydentGrid.CurrentRow.Cells[0].Value.ToString())[0][0] != "1")
                {
                    OpenForm(new FormAddChangeStydentKicked(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(Functional.GetId(StydentGrid)))));
                }
                else
                {
                    MessageBox.Show("Данный студент уже восстановлен! \n Обновите данные таблицы и перепроверьте информацию!", "Ошибочка", MessageBoxButtons.OK);
                }
            }
            
        }
    }
}
