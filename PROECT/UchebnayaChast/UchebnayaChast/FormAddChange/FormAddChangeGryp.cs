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

        string n, k, b, spec;

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
                ADComboSpecly.Items.Add(i[2]);
            }

            //saveindexes2 = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false);
            //ADComboKlRyk.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false).ToArray());
            saveindexes2 = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod, "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0");
            foreach (var i in saveindexes2)
            {
                ADComboKlRyk.Items.Add(i[1]);
            }
            ADComboKlRyk.Sorted = true;
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
                ADComboSpecly.Items.Add(i[2]);
            }
            ADComboSpecly.SelectedIndex =vara.IndexOf( vara.First(x => x[0] == privet["Sp_id"]));

            n = ADComboNumber.Text;
            k = ADComboKyrs.Text;
            b = ADComboBorn.Text;
            spec = ADComboSpecly.Text;

            ADComboKlRyk.DropDownStyle = ComboBoxStyle.DropDownList;
            //ADComboKlRyk.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0", false).ToArray());
            saveindexes2 = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod, "(select count(`Id`) from gryp g where g.P_id=prepod.Id)=0");
            if (privet["P_id"] != "")
                saveindexes2.Add(Functional.Controller.TakeRowById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"])));
            foreach (var i in saveindexes2)
            {
                ADComboKlRyk.Items.Add(i[1]);
            }
            ADComboKlRyk.Sorted = true;

            if (privet["P_id"] != "")
            {
                string s = ((Functional.Controller.Query(("select  p.P_fio from prepod p join gryp g on g.P_id=p.Id where g.Id=" + privet["Id"] + " limit 1;")))[0][0]);

                
                ADComboKlRyk.Text = s;
            }
            
            //ADComboKlRyk.SelectedIndex = saveindexes2.Count - 1;
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

            test.Add(delegate () { if (ADComboSpecly.SelectedIndex < 0) { Functional.Error("Выберите шифр!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboNumber.SelectedIndex < 0) { Functional.Error("Выберите Номер группы!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKyrs.SelectedIndex < 0) { Functional.Error("Выберите курс!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboBorn.SelectedIndex < 0) { Functional.Error("Выберите год образования группы!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboKlRyk.SelectedIndex < 0) { Functional.Error("Выберите кл. руководителя!"); return true; } else return false; });

            if (id == 0)
            {
                test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + vara[ADComboSpecly.SelectedIndex][0] + "' and G_number='" + ADComboNumber.Text + "' and G_kyrs='" + ADComboKyrs.Text + "' and G_born='" + ADComboBorn.Text + "'").Count != 0) { Functional.Error("Такая группа уже есть!"); return true; } else return false; });
            }
            else
            {
                test.Add(delegate () { if (((k!=ADComboKyrs.Text)||(n!=ADComboNumber.Text)||(b!=ADComboBorn.Text)||(spec!=ADComboSpecly.Text))&& (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + vara[ADComboSpecly.SelectedIndex][0] + "' and G_number='" + ADComboNumber.Text + "' and G_kyrs='" + ADComboKyrs.Text + "' and G_born='" + ADComboBorn.Text + "'").Count != 0)) { Functional.Error("Такая группа уже есть!"); return true; } else return false; });
            }
            int diapazon= Math.Abs((DateTime.Now.Year % 10) - (ADComboBorn.SelectedIndex + Convert.ToInt32(ADComboKyrs.Text))); ;
            if (DateTime.Now.Month>8)
            {
                diapazon--;
            }

            test.Add(delegate () { if (diapazon!=0) { Functional.Error("Данный год и курс невозможен на текущее время!"); return true; } else return false; });
            

            if (Functional.CheckTest(test.ToArray()))
            {
                string prepodavatel = Functional.Controller.Query("select p.Id from prepod p where p.P_fio='" + ADComboKlRyk.Text + "'")[0][0];

                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.gryp, new List<string> { vara[ADComboSpecly.SelectedIndex][0], ADComboKyrs.Text, ADComboNumber.Text, ADComboBorn.Text, prepodavatel,"1" });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.gryp, new List<string> { vara[ADComboSpecly.SelectedIndex][0], ADComboKyrs.Text, ADComboNumber.Text, ADComboBorn.Text, prepodavatel, "1" }, id.ToString());
                this.Close();
            }

        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
