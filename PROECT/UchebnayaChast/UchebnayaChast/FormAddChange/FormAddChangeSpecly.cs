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

        public FormAddChangeSpecly()
        {
            InitializeComponent();
            ADCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false);
            ADCombo.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false).ToArray());
        }

        public FormAddChangeSpecly(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADName.Text = privet["Sp_name"];
            ADShifr.Text = privet["Sp_nazv"];
            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);
            ADCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ADCombo.Items.AddRange(Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "P_fio", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false).ToArray());
            saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from specly s where s.P_id=prepod.Id)=0", false);
            if (!string.IsNullOrEmpty(privet["P_id"]))
            {
                saveindexes.Add(privet["P_id"]);
                ADCombo.Items.Add(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"]))["P_fio"]);
                ADCombo.SelectedIndex = saveindexes.IndexOf(saveindexes.First(x => x == privet["P_id"]));
            }
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADName.Text.Length < 3) { Functional.Error("Слишком короткое название, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (string.IsNullOrWhiteSpace(ADShifr.Text)) { Functional.Error("Слишком короткий Шифр, ну что вы!"); return true; } else return false; });
            test.Add(delegate () { if (ADCombo.SelectedIndex<0) { Functional.Error("Выберите заведующего!"); return true; } else return false; });

            if (Functional.CheckTest(test.ToArray()))
            {
                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.specly, new List<string> { ADName.Text, ADShifr.Text, saveindexes[ADCombo.SelectedIndex] });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.specly, new List<string> { ADName.Text, ADShifr.Text,saveindexes[ADCombo.SelectedIndex] }, id.ToString());
                this.Close();
            }

        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
