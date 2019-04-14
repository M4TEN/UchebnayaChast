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

        public FormAddChangeKafedra()
        {
            InitializeComponent();
        }


        public FormAddChangeKafedra(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADName.Text = privet["K_name"];
            ADNomer.Text = privet["K_nomer"];
            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADName.Text.Length < 3) { Functional.Error("Слишком короткое название, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADNomer.Text.Any(x=>!int.TryParse(x.ToString(),out int b))) { Functional.Error("Слишком короткий номер, ну что вы!"); return true; } else return false; });
            if (Functional.CheckTest(test.ToArray()))
            {
                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.kafedra, new List<string> { ADName.Text, ADNomer.Text });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.kafedra, new List<string> { ADName.Text, ADNomer.Text }, id.ToString());
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
    }
}
