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
    public partial class FormAddChangeStydentKicked : Form
    {
        int id;
        List<List<string>> saveindexes;
        List<List<string>> vara;
        List<string> l;

        string Fio;
        string Zach;

        public FormAddChangeStydentKicked()
        {
            InitializeComponent();
        }

        public FormAddChangeStydentKicked(Dictionary<string, string> privet)
        {
            InitializeComponent();
            ADComboBK.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypN.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypK.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypB.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypShifr.DropDownStyle = ComboBoxStyle.DropDownList;

            ADFio.Text = privet["St_fio"];
            ADTown.Text = privet["St_town"];
            ADAdres.Text = privet["St_adres"];
            ADNomer.Text = privet["St_nomer"];
            ADZach.Text = "";
            ADComboBK.Text = "Контракт";

            Fio = privet["St_fio"];
            Zach = privet["St_zach"];

            DateTime data = DateTime.ParseExact((Convert.ToDateTime(privet["St_data"]).ToString("dd.MM.yyyy")), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //CnrData.SetDate(Convert.ToDateTime(data));
            CnrData.SelectionStart = data;
            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);
            CnrData.MaxDate = DateTime.Now.AddYears(-14);
            CnrData.MinDate = DateTime.Now.AddYears(-35);
            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.gryp, "Id", "(select count(`Id`) from stydent st where st.G_id=gryp.Id)=0", false);
            //saveindexes = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + privet["Id"] + " limit 1;")))[0];
            if (!string.IsNullOrEmpty(privet["G_id"]))
            {
                //saveindexes.Add(privet["G_id"]);
                //string s = ((Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);

                vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.specly);
                foreach (var i in vara)
                {
                    ADComboGrypShifr.Items.Add(i[2]);
                }
                //for (int i = 0; i < ADComboGrypShifr.Items.Count; i++)
                //    if (ADComboGrypShifr.Items[i].ToString() == s)
                //    {
                //        ADComboGrypShifr.SelectedIndex = i;
                //    }
                //saveindexes= Functional.Controller.GetAllFrom(SpecialSqlController.Tables.gryp);

                //s = ((Functional.Controller.Query(("select g.G_number from stydent st join gryp g on st.G_id=G.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                //for (int i = 0; i < ADComboGrypN.Items.Count; i++)
                //    if (ADComboGrypN.Items[i].ToString() == s)
                //    {
                //        ADComboGrypN.SelectedIndex = i;
                //    }

                //s = ((Functional.Controller.Query(("select g.G_kyrs from stydent st join gryp g on st.G_id=G.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                //for (int i = 0; i < ADComboGrypK.Items.Count; i++)
                //    if (ADComboGrypK.Items[i].ToString() == s)
                //    {
                //        ADComboGrypK.SelectedIndex = i;
                //    }

                //s = ((Functional.Controller.Query(("select g.G_born from stydent st join gryp g on st.G_id=G.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                //for (int i = 0; i < ADComboGrypB.Items.Count; i++)
                //    if (ADComboGrypB.Items[i].ToString() == s)
                //    {
                //        ADComboGrypB.SelectedIndex = i;
                //    }

                ADComboGrypK.SelectedIndex = 0;

                if ((DateTime.Now.Month>0)&&(DateTime.Now.Month<6))
                {
                    ADComboGrypB.SelectedIndex = (Convert.ToInt32(DateTime.Now.Year.ToString())) % 10 - 1;
                }
                else
                {
                    ADComboGrypB.SelectedIndex = Convert.ToInt32(DateTime.Now.Year.ToString()) % 10;
                }
            }

        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADFio.Text.Length < 3) { Functional.Error("Слишком короткое ФИО, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADTown.Text.Length < 1) { Functional.Error("Слишком краткое название у города, такой существует?"); return true; } else return false; });
            test.Add(delegate () { if (ADAdres.Text.Length < 10) { Functional.Error("Слишком короткий адрес, хмм"); return true; } else return false; });
            test.Add(delegate () { if (ADNomer.Text.Length < 10) { Functional.Error("Слишком короткий номер, допишите циферки, пожалуйста :)"); return true; } else return false; });
            test.Add(delegate () { if (ADZach.Text.Length < 7) { Functional.Error("Слишком короткий номер зачётки, такое неприемлимо!"); return true; } else return false; });

            test.Add(delegate () { if (ADComboGrypShifr.SelectedIndex < 0) { Functional.Error("Выберите Шифр!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboGrypK.SelectedIndex < 0) { Functional.Error("Выберите курс!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboGrypN.SelectedIndex < 0) { Functional.Error("Выберите Номер группы!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboGrypB.SelectedIndex < 0) { Functional.Error("Выберите !"); return true; } else return false; });
            if (ADComboGrypShifr.SelectedIndex>-1)
            {
                string s = Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_nazv='" + ADComboGrypShifr.Text + "'")[0];
                test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + s + "' and G_kyrs='" + ADComboGrypK.Text + "' and G_number='" + ADComboGrypN.Text + "' and G_born='" + ADComboGrypB.Text + "'").Count == 0) { Functional.Error("Такой группы нет, \n Либо создайте такую группу! \n Либо переопределите студента в другую группу!"); return true; } else { return false; } });
            }
            if (Zach != ADZach.Text)
                test.Add(delegate ()
                {
                    if (Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_zach='" + ADZach.Text + "'").Count != 0)
                    {
                        Functional.Error("Такая зачётка уже есть!");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });

            //Надо добавить первой ячейкой группу G_id
            if (Functional.CheckTest(test.ToArray()))
            {
                string s = Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_nazv='" + ADComboGrypShifr.Text + "'")[0];

                string derzhi = Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + s + "' and G_kyrs='" + ADComboGrypK.Text + "' and G_number='" + ADComboGrypN.Text + "' and G_born='" + ADComboGrypB.Text + "'")[0];
                string god = (((DateTime.Now.Year) / 10) * 10 + Convert.ToInt32(ADComboGrypB.Text)).ToString();
                if (DateTime.Now.Month < 7)
                    god = (Convert.ToInt32(god) + 1).ToString() + "0101";
                else
                    god += "0901";
                if (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + s + "' and G_kyrs='" + ADComboGrypK.Text + "' and G_number='" + ADComboGrypN.Text + "' and G_born='" + ADComboGrypB.Text + "'")[6] != "0")
                {
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.stydent, new List<string> { derzhi, ADFio.Text, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADTown.Text, ADAdres.Text, god, ADNomer.Text, ADZach.Text, ADComboBK.Text, "1" }, id.ToString());
                    Functional.Controller.Query("delete from yspeh where yspeh.St_id=" + id.ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Нельзя добавить студента в выпущенную группу", "Ошибка", MessageBoxButtons.OK);
                }
                
            }

        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
