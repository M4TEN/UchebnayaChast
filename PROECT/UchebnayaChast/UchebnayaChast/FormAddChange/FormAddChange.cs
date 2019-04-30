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
    public partial class FormAddChangeKafedra : Form
    {

        int id;
        List<string> saveindexes;

        string KName;

        public FormAddChangeKafedra()
        {
            InitializeComponent();
            ADCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from kafedra k where k.P_id=prepod.Id)=0", false);
            ADCombo.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from kafedra k where k.P_id=prepod.Id)=0", false).ToArray());
            ADCombo.Sorted = true;

        }


        public FormAddChangeKafedra(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADName.Text = privet["K_name"];
            ADNomer.Text = privet["K_nomer"];
            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);
            ADCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ADCombo.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from kafedra k where k.P_id=prepod.Id)=0", false).ToArray());
            saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from kafedra k where k.P_id=prepod.Id)=0", false);
            if (!string.IsNullOrEmpty(privet["P_id"]))
            {
                saveindexes.Add(privet["P_id"]);
                ADCombo.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"]))["P_fio"]);
                string s = ((Functional.Controller.Query(("select  p.P_fio from prepod p join kafedra k on k.P_id=p.Id where k.Id=" + privet["Id"] + " limit 1;")))[0][0]);

                //ADCombo.SelectedIndex = saveindexes.IndexOf(saveindexes.First(x => x == privet["P_id"]));
                ADCombo.Sorted = true;
                ADCombo.Text = s;
            }

            KName = ADName.Text; 
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADName.Text.Length < 3) { Functional.Error("Слишком короткое название, думайте лучше!"); return true; } else return false; });
            //test.Add(delegate () { if (ADNomer.Text.Any(x=>!int.TryParse(x.ToString(),out int b))) { Functional.Error("Слишком короткий номер, ну что вы!"); return true; } else return false; });
            test.Add(delegate () { if ((ADNomer.TextLength) < 10) { Functional.Error("Слишком короткий номер, ну что вы!"); return true; } else return false; });
            test.Add(delegate () { if (ADCombo.SelectedIndex < 0) { Functional.Error("Выберите заведующего!"); return true; } else return false; });
            if (ADName.Text != "")
            if ((id == 0))
                    test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.kafedra, "K_name='" + ADName.Text + "'").Count != 0) { Functional.Error("Такая кафедра уже есть!"); return true; } else { return false; } });
            else
                if (KName != ADName.Text)
                    test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.kafedra, "K_name='" + ADName.Text + "'").Count != 0) { Functional.Error("Такая кафедра уже есть!"); return true; } else { return false; } });

            //string prepodavatel = Functional.Controller.Query("select p.Id from prepod p where p.P_fio='"+ADCombo.Text+"'")[0][0];

            if (Functional.CheckTest(test.ToArray()))
            {
                string prepodavatel = Functional.Controller.Query("select p.Id from prepod p where p.P_fio='" + ADCombo.Text + "'")[0][0];

                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.kafedra, new List<string> { ADName.Text, ADNomer.Text, prepodavatel });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.kafedra, new List<string> { ADName.Text, ADNomer.Text, prepodavatel }, id.ToString());
                this.Close();
            }
        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADNomer_Click(object sender, EventArgs e)
        {
            ADNomer.Clear();
            ADNomer.SelectionStart = 0;
        }

        private void ADName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void ADNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
