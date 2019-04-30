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
    public partial class FormPrintGryp : Form
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

        public FormPrintGryp()
        {
            InitializeComponent();
        }

        public FormPrintGryp(DataGridView privet, string s, bool b = true)
        {
            InitializeComponent();
            yznatimya();
            GrypGrid.Columns["P_id"].Visible = false;
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            Functional.GetData(SpecialSqlController.Tables.gryp, delegate (ref List<Dictionary<string, string>> poka) {
                foreach (var i in poka)
                {
                    tags.Add(delegate (Dictionary<string, string> row) { if (row["G_status"].ToLower().Replace(" ", "").Contains("0".ToLower().Replace(" ", ""))) return false; else return true; });
                    i["G_stydentov"] = Functional.Controller.Query("select count(st.Id) from gryp g join stydent st on st.G_id=g.Id where g.Id=" + i["Id"]+" and st.St_status!=0;")[0][0].ToString();
                    
                    i["G_b"] = Functional.Controller.Query("select count(st.Id) from gryp g join stydent st on st.G_id=g.Id where g.Id=" + i["Id"] + " and st.St_opl='Бюджет'")[0][0].ToString();
                    i["G_k"] = Functional.Controller.Query("select count(st.Id) from gryp g join stydent st on st.G_id=g.Id where g.Id=" + i["Id"] + " and st.St_opl='Контракт'")[0][0].ToString();
                    if ((i["Sp_id"] != null) && (i["Sp_id"].Length > 0))
                        i["Sp_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.specly, int.Parse(i["Sp_id"]))["Sp_nazv"];
                    if ((i["P_id"] != null) && (i["P_id"].Length > 0))
                        i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];

                }
                Functional.Filtres(tags.ToArray(), "Выпущенных групп нет!");
            });
            Functional.Print(ref GrypGrid);
            LabelKolvo.Text = GrypGrid.RowCount.ToString();
            this.GrypGrid.Sort(this.GrypGrid.Columns["Sp_id"], ListSortDirection.Ascending);
        }

        public FormPrintGryp(DataGridView privet, bool wk = true)
        {
            InitializeComponent();
            yznatimya();
            GrypGrid.Columns["P_id"].Visible = true;

            if (wk)
                foreach (DataGridViewRow row in privet.Rows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    GrypGrid.Rows.Add(items);
                }
            else
                foreach (DataGridViewRow row in privet.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    GrypGrid.Rows.Add(items);
                }

            LabelKolvo.Text = GrypGrid.RowCount.ToString();
        }

        private void BtnScreen_Click(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(1020, 450);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(Location.X + 5, Location.Y + 5, 0, 0, new Size(1020, 450));

            printscreen.Save(b + DateTime.Now.Millisecond + DateTime.Now.Second + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
