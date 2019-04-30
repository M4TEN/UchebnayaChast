using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebnayaChast.FormAddChange
{
    public partial class FormAddChangeDisp : Form
    {
        int id;

        string DName, DSem, DShifr;

        public FormAddChangeDisp()
        {
            InitializeComponent();
            ADComboSem.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public FormAddChangeDisp(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADShifr.Text = privet["D_shifr"];
            ADName.Text = privet["D_name"];
            ADNorm.Text = privet["D_norm"];
            ADLab.Text = privet["D_lab"];
            ADComboSem.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboType.DropDownStyle = ComboBoxStyle.DropDownList;

            ADComboSem.SelectedIndex = Convert.ToInt32(privet["D_sem"]) - 1;
            ADComboType.Text = privet["D_type"];
            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);

            DName = ADName.Text;
            DSem = ADComboSem.Text;
            DShifr = ADShifr.Text;
        }

        private void ADShifr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ADName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void ADNorm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ADLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADShifr.Text.Length < 3) { Functional.Error("Слишком короткий Шифр, думайте лучше!"); return true; } else return false; });
            //test.Add(delegate () { if (ADNomer.Text.Any(x=>!int.TryParse(x.ToString(),out int b))) { Functional.Error("Слишком короткий номер, ну что вы!"); return true; } else return false; });
            test.Add(delegate () { if ((ADName.TextLength) < 2) { Functional.Error("Слишком короткое название дисциплины, ну что вы!"); return true; } else return false; });
            //test.Add(delegate () { if ((ADNorm.TextLength) < 1) { Functional.Error("Может быть напишите сколько часов лекции?"); return true; } else return false; });
            test.Add(delegate () { if ((ADNorm.TextLength) < 1)
                {
                    Functional.Error("Напишите сколько часов лекции преподаётся!"); return true;
                }
                else
                {
                    if (Convert.ToInt32(ADNorm.Text) % 2 == 1)
                    {
                        Functional.Error("Количество лекций не может быть нечётным числом!"); return true;
                    }
                    else
                        return false;
                }
            });

            test.Add(delegate () { if ((ADLab.TextLength) < 1) { Functional.Error("Может быть напишите кол-во лабораторных?"); return true; } else return false; });
            test.Add(delegate () { if ((ADComboSem.SelectedIndex) < 0) { Functional.Error("Выберите семестр!"); return true; } else return false; });
            test.Add(delegate () { if ((ADComboType.SelectedIndex) < 0) { Functional.Error("Выберите тип оценивания предмета!"); return true; } else return false; });

            if ((ADName.Text != "") && (ADComboSem.SelectedIndex > -1) && (ADShifr.Text != ""))
            {
                if (id == 0)
                    test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.disp, "D_name='" + ADName.Text + "' and D_sem=" + ADComboSem.Text).Count != 0) { Functional.Error("Такая дисциплина уже есть!"); return true; } else return false; });
                else
                {
                    if ((DName != ADName.Text) || (DSem != ADComboSem.Text) || (DShifr != ADShifr.Text))
                        test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.disp, "D_name='" + ADName.Text + "' and D_sem=" + ADComboSem.Text).Count != 0) { Functional.Error("Такая дисциплина уже есть!"); return true; } else return false; });
                }
            }

            if (Functional.CheckTest(test.ToArray()))
            {
                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.disp, new List<string> { ADShifr.Text, ADName.Text,ADNorm.Text,ADLab.Text,ADComboSem.Text, ADComboType.Text});
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.disp, new List<string> { ADShifr.Text, ADName.Text, ADNorm.Text, ADLab.Text, ADComboSem.Text, ADComboType.Text }, id.ToString());
                this.Close();
            }
        }
    }
}
