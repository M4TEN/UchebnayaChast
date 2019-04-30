using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchebnayaChast.FormAddChange;
using System.Security.Principal;
using System.Drawing;

namespace UchebnayaChast.FormAddChange
{
    public partial class FormPrint : Form
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
            LabelKolvoSrBall.Text = (Convert.ToDouble(kol) / kolvo).ToString("#.##");
            LabelB1.Text = mas[0].ToString();
            LabelB2.Text = mas[1].ToString();
            LabelB3.Text = mas[2].ToString();
            LabelB4.Text = mas[3].ToString();
            LabelB5.Text = mas[4].ToString();
        }

        public FormPrint()
        {
            InitializeComponent();
        }

        public FormPrint(DataGridView privet,bool wk=true)
        {
            InitializeComponent();
            yznatimya();
            if (wk)
                foreach (DataGridViewRow row in privet.Rows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    YspehGrid.Rows.Add(items);
                }
            else
                foreach (DataGridViewRow row in privet.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    YspehGrid.Rows.Add(items);
                }
            SrBall();
        }

        private void BtnScreen_Click(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(1020, 450);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(Location.X+5, Location.Y+5, 0, 0, new Size(1020, 450));

            printscreen.Save(b + DateTime.Now.Millisecond + DateTime.Now.Second + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
