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
    public partial class FormAddChangeStydent : Form
    {
        int id;
        List<List<string>> saveindexes;
        List<List<string>> vara;
        List<string> l;

        string Fio;
        string Zach;
        DateTime postyp;

        public FormAddChangeStydent()
        {
            InitializeComponent();

            ADComboGrypShifr.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboBK.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypN.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypK.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboGrypB.DropDownStyle = ComboBoxStyle.DropDownList;

            vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.specly);
            foreach (var i in vara)
            {
                ADComboGrypShifr.Items.Add(i[2]);
            }
            CnrData.MaxDate = DateTime.Now.AddYears(-14);
            CnrData.MinDate = DateTime.Now.AddYears(-35);
        }

        public FormAddChangeStydent(Dictionary<string, string> privet)
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
            ADZach.Text = privet["St_zach"];
            ADComboBK.Text = privet["St_opl"];
            postyp = DateTime.ParseExact((Convert.ToDateTime(privet["St_postyp"]).ToString("dd.MM.yyyy")), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);


            Fio = privet["St_fio"];
            Zach = privet["St_zach"];

            DateTime data = DateTime.ParseExact((Convert.ToDateTime(privet["St_data"]).ToString("dd.MM.yyyy")), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //CnrData.SetDate(Convert.ToDateTime(data));
            CnrData.SelectionStart=data;
            CnrData.MaxDate = DateTime.Now.AddYears(-14);
            CnrData.MinDate = DateTime.Now.AddYears(-35);

            ADAdd.Text = "Изменить";
            this.Text = "Изменить кафедру";
            id = int.Parse(privet["Id"]);

            //saveindexes = Functional.Controller.GetColumn(SpecialSqlController.Tables.gryp, "Id", "(select count(`Id`) from stydent st where st.G_id=gryp.Id)=0", false);
            //saveindexes = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + privet["Id"] + " limit 1;")))[0];
            if (!string.IsNullOrEmpty(privet["G_id"]))
            {
                //saveindexes.Add(privet["G_id"]);
                string s =((Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                
                vara = Functional.Controller.GetAllFrom(SpecialSqlController.Tables.specly);
                foreach (var i in vara)
                {
                        ADComboGrypShifr.Items.Add(i[2]);
                }
                for (int i=0; i< ADComboGrypShifr.Items.Count;i++)
                if (ADComboGrypShifr.Items[i].ToString() == s)
                {
                    ADComboGrypShifr.SelectedIndex = i;
                }
                //saveindexes= Functional.Controller.GetAllFrom(SpecialSqlController.Tables.gryp);

                s = ((Functional.Controller.Query(("select g.G_number from stydent st join gryp g on st.G_id=G.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                for (int i = 0; i < ADComboGrypN.Items.Count; i++)
                    if (ADComboGrypN.Items[i].ToString() == s)
                    {
                        ADComboGrypN.SelectedIndex = i;
                    }

                s = ((Functional.Controller.Query(("select g.G_kyrs from stydent st join gryp g on st.G_id=G.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                for (int i = 0; i < ADComboGrypK.Items.Count; i++)
                    if (ADComboGrypK.Items[i].ToString() == s)
                    {
                        ADComboGrypK.SelectedIndex = i;
                    }

                s = ((Functional.Controller.Query(("select g.G_born from stydent st join gryp g on st.G_id=G.Id where st.Id=" + privet["Id"] + " limit 1;")))[0][0]);
                for (int i = 0; i < ADComboGrypB.Items.Count; i++)
                    if (ADComboGrypB.Items[i].ToString() == s)
                    {
                        ADComboGrypB.SelectedIndex = i;
                    }
            }

        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            string s;
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADFio.Text.Length < 3) { Functional.Error("Слишком короткое ФИО, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADTown.Text.Length < 1) { Functional.Error("Слишком краткое название у города, такой существует?"); return true; } else return false; });
            test.Add(delegate () { if (ADAdres.Text.Length < 10) { Functional.Error("Слишком короткий адрес, хмм"); return true; } else return false; });
            test.Add(delegate () { if (ADNomer.Text.Length < 10) { Functional.Error("Слишком короткий номер, допишите циферки, пожалуйста :)"); return true; } else return false; });
            test.Add(delegate () { if (ADZach.Text.Length < 7) { Functional.Error("Слишком короткий номер зачётки, такое неприемлимо!"); return true; } else return false; });

            test.Add(delegate () { if (ADComboGrypShifr.SelectedIndex < 0) { Functional.Error("Выберите Шифр!"); return true; } else return false; s = Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_nazv='" + ADComboGrypShifr.Text + "'")[0]; });
            test.Add(delegate () { if (ADComboGrypK.SelectedIndex < 0) { Functional.Error("Выберите курс!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboGrypN.SelectedIndex < 0) { Functional.Error("Выберите Номер группы!"); return true; } else return false; });
            test.Add(delegate () { if (ADComboGrypB.SelectedIndex < 0) { Functional.Error("Выберите !"); return true; } else return false; });

            if (ADComboGrypShifr.SelectedIndex > -1)
            {
                s = Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_nazv='" + ADComboGrypShifr.Text + "'")[0];
                test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + s + "' and G_kyrs='" + ADComboGrypK.Text + "' and G_number='" + ADComboGrypN.Text + "' and G_born='" + ADComboGrypB.Text + "'").Count == 0) { Functional.Error("Такой группы нет, \n Либо создайте такую группу! \n Либо переопределите студента в другую группу!"); return true; } else { return false; } });
            }

            if (id == 0)
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
            else
            {

                test.Add(delegate ()
                {
                    if ((Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_zach='" + ADZach.Text + "'").Count != 0)&& (Zach != ADZach.Text))
                    {           
                            Functional.Error("Такая зачётка уже есть!");
                            return true;
                    }
                    else
                    {
                        return false;
                    }
                });
            }

            //Надо добавить первой ячейкой группу G_id
            if (Functional.CheckTest(test.ToArray()))
            {

                s = Functional.Controller.TakeRow(SpecialSqlController.Tables.specly, "Sp_nazv='" + ADComboGrypShifr.Text + "'")[0];
                string derzhi = Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + s + "' and G_kyrs='" + ADComboGrypK.Text + "' and G_number='" + ADComboGrypN.Text + "' and G_born='" + ADComboGrypB.Text + "'")[0];
                string god = (((DateTime.Now.Year) / 10) * 10 + Convert.ToInt32(ADComboGrypB.Text)).ToString();
                
                if (Functional.Controller.TakeRow(SpecialSqlController.Tables.gryp, "Sp_id='" + s + "' and G_kyrs='" + ADComboGrypK.Text + "' and G_number='" + ADComboGrypN.Text + "' and G_born='" + ADComboGrypB.Text + "'")[6] != "0")
                {
                    if (id == 0)
                    {
                        if (DateTime.Now.Month < 7)
                            god = (Convert.ToInt32(god) + 1).ToString() + "0101";
                        else
                            god += "0901";
                        Functional.Controller.InsertIn(SpecialSqlController.Tables.stydent, new List<string> { derzhi, ADFio.Text, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADTown.Text, ADAdres.Text, god, ADNomer.Text, ADZach.Text, ADComboBK.Text, "1" });
                    }
                    else
                        Functional.Controller.UpdateIn(SpecialSqlController.Tables.stydent, new List<string> { derzhi, ADFio.Text, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADTown.Text, ADAdres.Text, Convert.ToDateTime(postyp).ToString("yyyyMMdd"), ADNomer.Text, ADZach.Text, ADComboBK.Text, "1" }, id.ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Нельзя добавить студента в выпущенную группу", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void ADFio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void ADTown_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ADZach_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
