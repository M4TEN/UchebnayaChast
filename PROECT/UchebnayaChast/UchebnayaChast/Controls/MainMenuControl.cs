using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebnayaChast
{
    public partial class MainMenuControl : UserControl
    {
        string passWord = "";

        public Action<bool> mainButtonEnable; // Поле для хранения делегата - сделаем его публичным
        private void MainButtonEnable(bool buttonEnable) // Метод для удобства
            => mainButtonEnable?.Invoke(buttonEnable);

        public MainMenuControl()
        {
            InitializeComponent();

            this.Load += delegate
            {
                passWord = "";
            };
            BtnEnter.Click += delegate
            {
                if (TXTPass.Text != passWord)
                {
                    string result = string.Format("Не верный пароль!");
                    MessageBox.Show(result, "Error!");
                    MainButtonEnable(false);
                    return;
                }
                else
                {
                    string result = string.Format("{0}\n{1}", "Пароль верный!", "Продолжаем работу.");
                    MessageBox.Show(result, "You are lucky!");
                    PanelScrit.Visible = true;
                    MainButtonEnable(true);
                }
                TXTPass.Clear();
            };
        }

    }
}
