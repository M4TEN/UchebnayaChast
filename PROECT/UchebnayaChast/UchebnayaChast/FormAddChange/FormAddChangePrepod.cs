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
    public partial class FormAddChangePrepod : Form
    {
        int id;
        List<string> saveindexes;


        public FormAddChangePrepod()
        {
            InitializeComponent();
            ADComboKategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKafedra.DropDownStyle = ComboBoxStyle.DropDownList;
            saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "Id", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false);
            ADComboKafedra.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "K_name", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false).ToArray());
        }

        public FormAddChangePrepod(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADFio.Text = privet["P_fio"];
            ADAdd.Text = "Изменить";
            this.Text = "Изменить преподавателя";
            id = int.Parse(privet["Id"]);
            ADComboKategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKafedra.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKafedra.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "K_name", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false).ToArray());
            //ADComboKategory.Items.AddRange(new string[]{ "1","2","3"});
            ADComboKategory.SelectedIndex = int.Parse(privet["P_kategory"]) - 1;
            saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "Id", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false);
            if (!string.IsNullOrEmpty(privet["K_id"]))
            {
                saveindexes.Add(privet["K_id"]);
                ADComboKafedra.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.kafedra, int.Parse(privet["K_id"]))["K_name"]);
                ADComboKafedra.SelectedIndex = saveindexes.IndexOf(saveindexes.First(x => x == privet["K_id"]));
            }
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADFio.Text.Length < 3) { Functional.Error("Слишком короткое ФИО, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKategory.SelectedIndex < 0) { Functional.Error("Выберите категорию!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKafedra.SelectedIndex < 0) { Functional.Error("Выберите кафедру!"); return true; } else return false; });

            if (Functional.CheckTest(test.ToArray()))
            {
                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.prepod, new List<string> { ADFio.Text, (Convert.ToInt32(ADComboKategory.SelectedIndex) + 1).ToString(), saveindexes[ADComboKafedra.SelectedIndex] });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.prepod, new List<string> { ADFio.Text, (Convert.ToInt32(ADComboKategory.SelectedIndex) + 1).ToString(), saveindexes[ADComboKafedra.SelectedIndex] }, id.ToString());
                this.Close();
            }
        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADFio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }
    }
}
