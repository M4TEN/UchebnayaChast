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
    public partial class FormAddChangeGryp : Form
    {
        int id;
        List<string> saveindexes;
        List<List<string>> saveindexes2;
        List<List<string>> vara;
        public FormAddChangeGryp()
        {
            InitializeComponent();
            ADComboBorn.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboSpecly.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKyrs.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKlRyk.DropDownStyle = ComboBoxStyle.DropDownList;

            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.specly, "Id", "(select count(`Id`) from gryp g where g.Sp_id=specly.Id)=0", false);
            //ADComboSpecly.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.specly, "Sp_name").ToArray());
            vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.specly);
            foreach(var i in vara)
            {
                ADComboSpecly.Items.Add(i[1]);
            }

            //saveindexes2 = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false);
            //ADComboKlRyk.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false).ToArray());
            saveindexes2 = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod, "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0");
            foreach (var i in saveindexes2)
            {
                ADComboKlRyk.Items.Add(i[1]);
            }
        }

        public FormAddChangeGryp(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADComboBorn.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboKyrs.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboNumber.DropDownStyle = ComboBoxStyle.DropDownList;

            ADComboBorn.Text = privet["G_born"];
            ADComboKyrs.Text = privet["G_kyrs"];
            ADComboNumber.Text = privet["G_number"];
            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);

            ADComboSpecly.DropDownStyle = ComboBoxStyle.DropDownList;
            //ADComboSpecly.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.specly, "Sp_name", "(select count(`Id`) from gryp g where g.Sp_id=specly.Id)=0", false).ToArray());
            vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.specly);
            foreach (var i in vara)
            {
                ADComboSpecly.Items.Add(i[1]);
            }
            ADComboSpecly.SelectedIndex =vara.IndexOf( vara.First(x => x[0] == privet["Sp_id"]));

            ADComboKlRyk.DropDownStyle = ComboBoxStyle.DropDownList;
            //ADComboKlRyk.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false).ToArray());
            saveindexes2 = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod, "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0");
            saveindexes2.Add(Functional.Controller.TakeRowById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"])));
            foreach (var i in saveindexes2)
            {
                ADComboKlRyk.Items.Add(i[1]);
            }
            ADComboKlRyk.SelectedIndex = saveindexes2.Count - 1;
            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false);
            //if (!string.IsNullOrEmpty(privet["P_id"]))
            //{
            //    saveindexes.Add(privet["P_id"]);
            //    ADComboKlRyk.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"]))["P_fio"]);
            //    ADComboKlRyk.SelectedIndex = saveindexes.IndexOf(saveindexes.First(x => x == privet["P_id"]));
            //}
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();

            test.Add(delegate () { if (ADComboSpecly.SelectedIndex < 0) { Functional.Error("Выберите специальность!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboNumber.SelectedIndex < 0) { Functional.Error("Выберите Номер группы!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKyrs.SelectedIndex < 0) { Functional.Error("Выберите курс!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboBorn.SelectedIndex < 0) { Functional.Error("Выберите год образования группы!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKlRyk.SelectedIndex < 0) { Functional.Error("Выберите кл. руководителя!"); return true; } else return false; });
            test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + vara[ADComboSpecly.SelectedIndex][0] + "' and G_number='" + ADComboNumber.Text + "' and G_kyrs='" + ADComboKyrs.Text + "' and G_born='" + ADComboBorn.Text + "'").Count != 0) { Functional.Error("Такая группа уже есть!"); return true; } else return false; });

            if (Functional.CheckTest(test.ToArray()))
            {
                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.gryp, new List<string> { vara[ADComboSpecly.SelectedIndex][0], ADComboNumber.Text, ADComboKyrs.Text, ADComboBorn.Text, saveindexes2[ADComboKlRyk.SelectedIndex][0] });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.gryp, new List<string> { vara[ADComboSpecly.SelectedIndex][0], ADComboNumber.Text, ADComboKyrs.Text, ADComboBorn.Text, saveindexes2[ADComboKlRyk.SelectedIndex][0] }, id.ToString());
                this.Close();
            }

        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
