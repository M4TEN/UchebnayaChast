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
    public partial class FormPrintYspehKicked : Form
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

        public void SrBall()
        {
            int[] mas = new int[5] { 0, 0, 0, 0, 0 };
            int kolvo = 0;
            int kol = 0;
            for (int i = 0; i < YspehGrid.RowCount; i++)
            {
                kol += Convert.ToInt32(YspehGrid["Y_ball", i].Value);
                kolvo++;
                switch (YspehGrid["Y_ball", i].Value)
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
                }
            }
            LabelVsego.Text = kolvo.ToString();
            LabelKolvoSrBall.Text = (Convert.ToDouble(kol) / kolvo).ToString("#.##");
            LabelB1.Text = mas[0].ToString();
            LabelB2.Text = mas[1].ToString();
            LabelB3.Text = mas[2].ToString();
            LabelB4.Text = mas[3].ToString();
            LabelB5.Text = mas[4].ToString();
        }

        public FormPrintYspehKicked()
        {
            InitializeComponent();
            YspehPoiskSem.DropDownStyle = ComboBoxStyle.DropDownList;
            DispPoiskType.DropDownStyle = ComboBoxStyle.DropDownList;
            yznatimya();
            Actions();
        }

        public virtual void MainAction()
        {
            //List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            //tags.Add(delegate (Dictionary<string, string> row) { if ((Functional.Controller.Query("select st.St_status from stydent st where st.Id=" + row["St_id"])[0][0]).ToLower().Replace(" ", "").Contains("1".ToLower().Replace(" ", ""))) return false; else return true; });
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();

            Functional.GetData(SpecialSqlController.Tables.yspeh, delegate (ref List<Dictionary<string, string>> privet) {
                foreach (var i in privet)
                {

                    i["Y_data"] = Convert.ToDateTime(i["Y_data"]).ToShortDateString();
                    if ((i["St_id"] != null) && (i["St_id"].Length > 0))
                    {
                        i["Y_zach"] = Functional.Controller.Query("select st.St_zach from yspeh y join stydent st on Y.St_id=st.Id where st.Id=" + i["St_id"])[0][0].ToString();

                        i["Y_status"] = Functional.Controller.Query("select st.St_status from yspeh y join stydent st on Y.St_id=st.Id where st.Id=" + i["St_id"])[0][0].ToString();

                        i["St_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(i["St_id"]))["St_fio"];
                    }
                    if ((i["P_id"] != null) && (i["P_id"].Length > 0))
                        i["P_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(i["P_id"]))["P_fio"];
                    if ((i["D_id"] != null) && (i["D_id"].Length > 0))
                    {
                        i["Y_type"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(i["D_id"]))["D_type"];

                        i["D_sem"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(i["D_id"]))["D_sem"];
                    }
                    if ((i["D_id"] != null) && (i["D_id"].Length > 0))
                    {
                        i["D_id"] = Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(i["D_id"]))["D_name"];
                    }

                    tags.Add(delegate (Dictionary<string, string> row) { if (!row["Y_status"].ToLower().Replace(" ", "").Contains("1".ToLower().Replace(" ", ""))) return false; else return true; });

                }
            });
            Functional.Filtres(tags.ToArray(), "Успеваемости по исключённым студентам нет!");

            //Functional.Filtres(tags.ToArray(), "Успеваемости по учащимся студентам нет!");

        }

        public virtual void Actions()
        {
            MainAction();
            Functional.Print(ref YspehGrid);
            YspehPoiskDisp.Text = "";
            YspehPoiskPrepod.Text = "";
            YspehPoiskZach.Text = "";
            YspehPoiskStydent.Text = "";
            YspehPoiskSem.SelectedIndex = -1;
            DispPoiskType.SelectedIndex = -1;
            this.YspehGrid.Sort(this.YspehGrid.Columns["St_id"], ListSortDirection.Ascending);
            SrBall();
        }




        private void YspehPoiskZach_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void YspehPoiskPrepod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void YspehPoiskStydent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void YspehPoiskDisp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnScreen_Click(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(970, 450);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(Location.X + 5, Location.Y + 5, 0, 0, new Size(970, 450));

            printscreen.Save(b + DateTime.Now.Millisecond + DateTime.Now.Second + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void BtnFncSearch_Click(object sender, EventArgs e)
        {
            List<Functional.FiltrTag> tags = new List<Functional.FiltrTag>();
            if (YspehPoiskStydent.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["St_id"].ToLower().Replace(" ", "").Contains(YspehPoiskStydent.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (YspehPoiskPrepod.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["P_id"].ToLower().Replace(" ", "").Contains(YspehPoiskPrepod.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (YspehPoiskDisp.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["D_id"].ToLower().Replace(" ", "").Contains(YspehPoiskDisp.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (YspehPoiskSem.SelectedIndex > -1)
                tags.Add(delegate (Dictionary<string, string> row) { if (row["D_sem"].ToLower().Replace(" ", "").Contains(YspehPoiskSem.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (YspehPoiskZach.Text != "")
                tags.Add(delegate (Dictionary<string, string> row) { if (row["Y_zach"].ToLower().Replace(" ", "").Contains(YspehPoiskZach.Text.ToLower().Replace(" ", ""))) return false; else return true; });
            if (DispPoiskType.SelectedIndex > -1)
                tags.Add(delegate (Dictionary<string, string> row) { if (row["Y_type"].ToLower().Replace(" ", "").Contains(DispPoiskType.Text.ToLower().Replace(" ", ""))) return false; else return true; });

            MainAction();
            Functional.Filtres(tags.ToArray(), "Успеваемости с такими критериями нет");
            //PrepodSortirovka.SelectedIndex = 0;
            Functional.Print(ref YspehGrid);
            this.YspehGrid.Sort(this.YspehGrid.Columns["St_id"], ListSortDirection.Ascending);
            SrBall();
        }

        private void BtnFncDrop_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
