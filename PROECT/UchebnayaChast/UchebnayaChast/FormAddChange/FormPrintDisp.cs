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
    public partial class FormPrintDisp : Form
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

        public FormPrintDisp()
        {
            InitializeComponent();
        }

        public FormPrintDisp(DataGridView privet, bool wk = true)
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
                    DispGrid.Rows.Add(items);
                }
            else
                foreach (DataGridViewRow row in privet.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    DispGrid.Rows.Add(items);
                }

            Checkai();
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
