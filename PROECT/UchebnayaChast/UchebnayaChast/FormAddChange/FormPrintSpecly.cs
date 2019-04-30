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
    public partial class FormPrintSpecly : Form
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

        public FormPrintSpecly()
        {
            InitializeComponent();
        }

        public FormPrintSpecly(DataGridView privet, bool wk = true)
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
                    SpeclyGrid.Rows.Add(items);
                }
            else
                foreach (DataGridViewRow row in privet.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    SpeclyGrid.Rows.Add(items);
                }

            LabelKolvo.Text = SpeclyGrid.RowCount.ToString();
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
    }
}
