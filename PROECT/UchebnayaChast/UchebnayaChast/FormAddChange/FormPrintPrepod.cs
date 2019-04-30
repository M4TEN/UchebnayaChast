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
    public partial class FormPrintPrepod : Form
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

        public FormPrintPrepod()
        {
            InitializeComponent();
        }

        public FormPrintPrepod(DataGridView privet, bool wk = true)
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
                    PrepodGrid.Rows.Add(items);
                }
            else
                foreach (DataGridViewRow row in privet.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    PrepodGrid.Rows.Add(items);
                }

            PrepodCheck();
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
