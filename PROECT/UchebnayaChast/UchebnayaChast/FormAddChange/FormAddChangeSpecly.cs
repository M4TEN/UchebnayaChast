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
    public partial class FormAddChangeSpecly : Form
    {
        int id;
        List<string> saveindexes;
        List<List<string>> vara;

        string SH;
        string SP;

        public FormAddChangeSpecly()
        {
            InitializeComponent();
            ADCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false);
            //ADCombo.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false).ToArray());
            vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod);
            foreach (var i in vara)
            {
                ADCombo.Items.Add(i[1]);
            }
            ADCombo.Sorted = true;

        }

        public FormAddChangeSpecly(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADName.Text = privet["Sp_name"];
            ADShifr.Text = privet["Sp_nazv"];

            SH = ADShifr.Text;
            SP = ADName.Text;

            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);
            ADCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            //ADCombo.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false).ToArray());
            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false);
            //if (!string.IsNullOrEmpty(privet["P_id"]))
            //{
            //    saveindexes.Add(privet["P_id"]);
            //    ADCombo.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"]))["P_fio"]);
            //    ADCombo.SelectedIndex = saveindexes.IndexOf(saveindexes.First(x => x == privet["P_id"]));
            //}
            vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.prepod);
            foreach (var i in vara)
            {
                ADCombo.Items.Add(i[1]);
            }
            ADCombo.Sorted = true;
            if (!string.IsNullOrEmpty(privet["P_id"]))
            {
                //saveindexes.Add(privet["G_id"]);
                string s = ((Functional.Controller.Query(("select  p.P_fio from prepod p join specly sp on sp.P_id=p.Id where sp.Id=" + privet["Id"] + " limit 1;")))[0][0]);

                //for (int i = 0; i < ADCombo.Items.Count; i++)
                //    if (ADCombo.Items[i].ToString() == s)
                //    {
                //        ADCombo.SelectedIndex = i;
                //    }
                ADCombo.Text = s;
            }
            
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADName.Text.Length < 3) { Functional.Error("Слишком короткое название, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (string.IsNullOrWhiteSpace(ADShifr.Text)) { Functional.Error("Слишком короткий Шифр, ну что вы!"); return true; } else return false; });
            test.Add(delegate () { if (ADCombo.SelectedIndex<0) { Functional.Error("Выберите заведующего!"); return true; } else return false; });
            if ((ADShifr.Text!=SH)&&(ADShifr.Text != ""))
            if (id == 0)
                test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.specly,"Sp_nazv='"+ADShifr.Text+"'").Count!=0) { Functional.Error("Выберите другой шифр, такой уже есть!"); return true; } else return false; });
            else
            {
                    if (SH!=ADShifr.Text)
                        test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_nazv='" + ADShifr.Text + "'").Count != 0) { Functional.Error("Выберите другой шифр, такой уже есть!"); return true; } else return false; });
                }
            if ((ADName.Text != SP)&&(ADName.Text != ""))
                if (id == 0)
                    test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_name='" + ADName.Text + "'").Count != 0) { Functional.Error("Выберите другое название специальности, такое уже есть!"); return true; } else return false; });
                else
                {
                    if (SP != ADShifr.Text)
                        test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_name='" + ADName.Text + "'").Count != 0) { Functional.Error("Выберите другое название специальности, такое уже есть!"); return true; } else return false; });
                }

            //if (Functional.CheckTest(test.ToArray()))
            //{
            //    if (id == 0)
            //        Functional.Controller.InsertIn(SpecialSqlController.Tables.specly, new List<string> { ADName.Text, ADShifr.Text, saveindexes[ADCombo.SelectedIndex] });
            //    else
            //        Functional.Controller.UpdateIn(SpecialSqlController.Tables.specly, new List<string> { ADName.Text, ADShifr.Text,saveindexes[ADCombo.SelectedIndex] }, id.ToString());
            //    this.Close();
            //}

            if (Functional.CheckTest(test.ToArray()))
            {
                string prepodavatel = Functional.Controller.Query("select p.Id from prepod p where p.P_fio='" + ADCombo.Text + "'")[0][0];

                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.specly, new List<string> { ADName.Text, ADShifr.Text, prepodavatel });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.specly, new List<string> { ADName.Text, ADShifr.Text, prepodavatel }, id.ToString());
                this.Close();
            }

        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void ADShifr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }
    }
}
