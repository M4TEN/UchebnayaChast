using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebnayaChast
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            PanelControlMainMenu.mainButtonEnable = ButtonEnable;

            PanelScroll.Height = BtnMainHome.Height;
            PanelScroll.Top = BtnMainHome.Top;
            ButtonEnable(false);
            PanelControlMainMenu.BringToFront();
        }


        public void ButtonEnable(bool b)
        {
            BtnMainHome.Enabled = b;
            BtnMainKafedra.Enabled = b;
            BtnMainPrepod.Enabled = b;
            BtnMainSpecly.Enabled = b;
            BtnMainStydent.Enabled = b;
            BtnMainYspeh.Enabled = b;
            BtnMainDisp.Enabled = b;
            BtnMainGryp.Enabled = b;
            if (b)
                PanelVisible.Visible = false;
            else
                PanelVisible.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMainStydent_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainStydent.Height;
            PanelScroll.Top = BtnMainStydent.Top;
            PanelControlStydent.BringToFront();

        }

        private void BtnMainHome_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainHome.Height;
            PanelScroll.Top = BtnMainHome.Top;
            PanelControlMainMenu.BringToFront();
        }

        private void BtnMainDisp_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainDisp.Height;
            PanelScroll.Top = BtnMainDisp.Top;
            PanelControlDisp.BringToFront();
        }

        private void BtnMainYspeh_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainYspeh.Height;
            PanelScroll.Top = BtnMainYspeh.Top;
            PanelControlYspeh.BringToFront();
        }

        private void BtnMainGryp_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainGryp.Height;
            PanelScroll.Top = BtnMainGryp.Top;
            PanelControlGryp.BringToFront();
        }

        private void BtnMainPrepod_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainPrepod.Height;
            PanelScroll.Top = BtnMainPrepod.Top;
            PanelControlPrepod.BringToFront();
        }

        private void BtnMainKafedra_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainKafedra.Height;
            PanelScroll.Top = BtnMainKafedra.Top;
            PanelControlKafedra.BringToFront();
        }

        private void BtnMainSpecly_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainSpecly.Height;
            PanelScroll.Top = BtnMainSpecly.Top;
            PanelControlSpecly.BringToFront();
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            PanelScroll.Height = BtnMainHome.Height;
            PanelScroll.Top = BtnMainHome.Top;
            PanelControlMainMenu.BringToFront();
            PanelControlMainMenu.PanelScrit.Visible = false;
            ButtonEnable(false);
        }
    }
}
