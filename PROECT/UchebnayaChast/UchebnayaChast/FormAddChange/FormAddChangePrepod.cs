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
        List<List<string>> vara;

        string PFio;

        public FormAddChangePrepod()
        {
            InitializeComponent();
            ADComboKategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKafedra.DropDownStyle = ComboBoxStyle.DropDownList;
            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "Id", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false);
            //ADComboKafedra.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "K_name", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false).ToArray());
            vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.kafedra);
            foreach (var i in vara)
            {
                ADComboKafedra.Items.Add(i[1]);
            }
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
            //ADComboKafedra.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "K_name", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false).ToArray());
         
            ADComboKategory.SelectedIndex = int.Parse(privet["P_kategory"]) - 1;

            //ADComboKategory.Items.AddRange(new string[]{ "1","2","3"});
            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.kafedra, "Id", "(select count(`Id`) from prepod p where p.K_id=kafedra.Id)=0", false);
            //if (!string.IsNullOrEmpty(privet["K_id"]))
            //{
            //    saveindexes.Add(privet["K_id"]);
            //    ADComboKafedra.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.kafedra, int.Parse(privet["K_id"]))["K_name"]);
            //    ADComboKafedra.SelectedIndex = saveindexes.IndexOf(saveindexes.First(x => x == privet["K_id"]));
            //}

            if (!string.IsNullOrEmpty(privet["K_id"]))
            {
                //saveindexes.Add(privet["G_id"]);
                string s = ((Functional.Controller.Query(("select  k.K_name from prepod p join kafedra k on p.K_id=k.Id where p.Id=" + privet["Id"] + " limit 1;")))[0][0]);

                vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.kafedra);
                foreach (var i in vara)
                {
                    ADComboKafedra.Items.Add(i[1]);
                }
                for (int i = 0; i < ADComboKafedra.Items.Count; i++)
                    if (ADComboKafedra.Items[i].ToString() == s)
                    {
                        ADComboKafedra.SelectedIndex = i;
                    }
            }

            PFio = ADFio.Text;
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADFio.Text.Length < 3) { Functional.Error("Слишком короткое ФИО, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKategory.SelectedIndex < 0) { Functional.Error("Выберите категорию!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKafedra.SelectedIndex < 0) { Functional.Error("Выберите кафедру!"); return true; } else return false; });

            //if (Functional.CheckTest(test.ToArray()))
            //{
            //    if (id == 0)
            //        Functional.Controller.InsertIn(SpecialSqlController.Tables.prepod, new List<string> { ADFio.Text, (Convert.ToInt32(ADComboKategory.SelectedIndex) + 1).ToString(), saveindexes[ADComboKafedra.SelectedIndex] });
            //    else
            //        Functional.Controller.UpdateIn(SpecialSqlController.Tables.prepod, new List<string> { ADFio.Text, (Convert.ToInt32(ADComboKategory.SelectedIndex) + 1).ToString(), saveindexes[ADComboKafedra.SelectedIndex] }, id.ToString());
            //    this.Close();
            //}
            if (ADFio.Text != "")
                if (id == 0)
                    test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.prepod, "P_fio='" + ADFio.Text + "'").Count != 0) { Functional.Error("Такой преподаватель уже есть!"); return true; } else return false; });
                else
                {
                    if (PFio != ADFio.Text)
                        test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.prepod, "P_fio='" + ADFio.Text + "'").Count != 0) { Functional.Error("Такой преподаватель уже есть!"); return true; } else return false; });
                }

            if (Functional.CheckTest(test.ToArray()))
            {
                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.prepod, new List<string> { ADFio.Text, (Convert.ToInt32(ADComboKategory.SelectedIndex) + 1).ToString(), vara[ADComboKafedra.SelectedIndex][0] });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.prepod, new List<string> { ADFio.Text, (Convert.ToInt32(ADComboKategory.SelectedIndex) + 1).ToString(), vara[ADComboKafedra.SelectedIndex][0] }, id.ToString());
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
