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
    public partial class FormAddChangeYspeh : Form
    {
        int id;
        List<string> saveindexesFio;
        List<string> saveindexesPrepod;
        List<string> saveindexesDisp;
        List<string> saveindexesBall;

        string stFio, stZach, dName, semType;

        public FormAddChangeYspeh()
        {
            InitializeComponent();
            ADBall.DropDownStyle = ComboBoxStyle.DropDownList;
            ADSem.DropDownStyle = ComboBoxStyle.DropDownList;
            CnrData.MaxDate = DateTime.Now;
            CnrData.MinDate = DateTime.Now.AddYears(-1);
            CnrData.SelectionStart = DateTime.Now;
        }
        //студент дисциплина семестр
        public FormAddChangeYspeh(Dictionary<string, string> privet)
        {
            InitializeComponent();
            
            ADBall.DropDownStyle = ComboBoxStyle.DropDownList;
            ADSem.DropDownStyle = ComboBoxStyle.DropDownList;

            ADAdd.Text = "Изменить";
            this.Text = "Изменить успеваемость";
            id = int.Parse(privet["Id"]);

            if (!string.IsNullOrEmpty(privet["St_id"]))
            {
                ADZach.Text = (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(privet["St_id"]))["St_zach"]);
            }

            saveindexesFio = Functional.Controller.GetColumn(SpecialSqlController.Tables.stydent, "Id", "(select count(`Id`) from yspeh y where y.St_id=stydent.Id)=0", false);
            if (!string.IsNullOrEmpty(privet["St_id"]))
            {
                saveindexesFio.Add(privet["St_id"]);
                ADFio.Text=(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.stydent, int.Parse(privet["St_id"]))["St_fio"]);
            }

            saveindexesPrepod = Functional.Controller.GetColumn(SpecialSqlController.Tables.prepod, "Id", "(select count(`Id`) from yspeh y where y.P_id=prepod.Id)=0", false);
            if (!string.IsNullOrEmpty(privet["P_id"]))
            {
                saveindexesPrepod.Add(privet["P_id"]);
                ADPrepod.Text = (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.prepod, int.Parse(privet["P_id"]))["P_fio"]);
            }

            saveindexesDisp = Functional.Controller.GetColumn(SpecialSqlController.Tables.disp, "Id", "(select count(`Id`) from yspeh y where y.D_id=disp.Id)=0", false);
            if (!string.IsNullOrEmpty(privet["D_id"]))
            {
                saveindexesDisp.Add(privet["D_id"]);
                ADDisp.Text = (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(privet["D_id"]))["D_name"]);
            }

            DateTime data = DateTime.ParseExact((Convert.ToDateTime(privet["Y_data"]).ToString("dd.MM.yyyy")), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            CnrData.SelectionStart = data;
            CnrData.MaxDate = DateTime.Now;
            CnrData.MinDate = DateTime.Now.AddYears(-1);

            ADBall.SelectedIndex = int.Parse(privet["Y_ball"]) - 1;
            ADSem.SelectedIndex= int.Parse(Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.disp, int.Parse(privet["D_id"]))["D_sem"]) - 1;

            stFio = ADFio.Text;
            dName = ADDisp.Text;
            semType = ADSem.Text;
            stZach = ADZach.Text;
        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {
            List<Functional.TestValid> test = new List<Functional.TestValid>();
            test.Add(delegate () { if (ADFio.Text.Length < 3) { Functional.Error("Слишком короткое ФИО студента, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADPrepod.Text.Length < 3) { Functional.Error("Слишком короткое ФИО препода, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADDisp.Text.Length < 3) { Functional.Error("Слишком короткое названеие дисциплины, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADZach.Text.Length < 7) { Functional.Error("Слишком короткий номер у зачётки, думайте лучше!"); return true; } else return false; });
            test.Add(delegate () { if (ADSem.SelectedIndex < 0) { Functional.Error("Выберите семестр!"); return true; } else return false; });
            test.Add(delegate () { if (ADBall.SelectedIndex < 0) { Functional.Error("Выберите оценку за !"); return true; } else return false; });

            test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_fio='"+ADFio.Text + "' and St_zach="+ADZach.Text).Count == 0) { Functional.Error("Такого студента нет! \n Зачислите такого студента и возвращайтесь!"); return true; } else { return false; } });
            test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.prepod, "P_fio='"+ADPrepod.Text + "'").Count == 0) { Functional.Error("Такого преподавателя нет! \n Наймите такого преподавателя и возвращайтесь"); return true; } else { return false; } });
            test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.disp, "D_name='"+ADDisp.Text + "' and D_sem="+ADSem.Text).Count == 0) { Functional.Error("Такой дисциплины нет! \n Добавьте такую дисциплину и возвращайтесь!"); return true; } else { return false; } });


            if ((ADFio.Text != "") && (ADDisp.Text != "") && (ADSem.SelectedIndex > -1)&&(ADZach.Text!="")) 
            {
                string IdOfMan;
                string IdOfDisp;
                if (Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_zach=" + ADZach.Text).Count != 0)
                    IdOfMan = Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_zach=" + ADZach.Text)[0];
                else
                    IdOfMan = "-1";

                if (Functional.Controller.TakeRow(SpecialSqlController.Tables.disp, "D_name='" + ADDisp.Text + "'and D_sem=" + ADSem.Text).Count != 0)
                    IdOfDisp = Functional.Controller.TakeRow(SpecialSqlController.Tables.disp, "D_name='" + ADDisp.Text + "'and D_sem=" + ADSem.Text)[0];
                else
                    IdOfDisp = "-1";

                if (id == 0)
                    test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.yspeh, "St_id=" + IdOfMan + " and D_id='" + IdOfDisp + "'").Count != 0) { Functional.Error("Такая успеваемость уже есть! \n Либо поменяйте студента \n Либо поменяйте дисциплину \n Либо поменяйте семестр!"); return true; } else { return false; } });
                else
                {
                    test.Add(delegate ()
                    {
                        if (((stFio != ADFio.Text) || (dName != ADDisp.Text) || (semType != ADSem.Text)|| (stZach!=ADZach.Text))&&(Functional.Controller.TakeRow(SpecialSqlController.Tables.yspeh, "St_id=" + IdOfMan + " and D_id='" + IdOfDisp + "'").Count != 0))
                        {
                            Functional.Error("Такая успеваемость студента уже есть! \n Либо поменяйте студента \n Либо поменяйте дисциплину \n Либо поменяйте семестр!"); return true;
                        }
                        else
                        {
                            return false;
                        }
                    });
                }
            }

            test.Add(delegate () { if (Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_zach=" + ADZach.Text + " and St_status!=1").Count != 0) { Functional.Error("Добавлять успеваемость студента, который уже отчислен либо выпущен НЕЛЬЗЯ!"); return true; } else { return false; } });

            int monthik = Convert.ToInt32(CnrData.SelectionRange.Start.ToString("MM"));
            test.Add(delegate () { if (!((monthik >= 1 && monthik <= 9 && Convert.ToInt32(ADSem.Text) % 2 == 0) || ((monthik >= 9 && monthik <= 12)||(monthik==1) && Convert.ToInt32(ADSem.Text) % 2 == 1))) { Functional.Error("Невозможно чтоб "+ADSem.Text+"-й семестр находился в "+monthik+ " месяце! \n Либо меняйте месяц \n Либо меняйте семестр"); return true; } else { return false; } });


            if (Functional.CheckTest(test.ToArray()))
            {
                string stydentFio = Functional.Controller.TakeRow(SpecialSqlController.Tables.stydent, "St_zach=" + ADZach.Text)[0];
                string prepodFio = Functional.Controller.TakeRow(SpecialSqlController.Tables.prepod, "P_fio='" + ADPrepod.Text+ "'")[0];
                string dispName = Functional.Controller.TakeRow(SpecialSqlController.Tables.disp, "D_name='" + ADDisp.Text+ "' and D_sem="+ADSem.Text)[0];

                if (id == 0)
                    Functional.Controller.InsertIn(SpecialSqlController.Tables.yspeh, new List<string> { stydentFio, prepodFio, dispName, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADBall.Text });
                else
                    Functional.Controller.UpdateIn(SpecialSqlController.Tables.yspeh, new List<string> { stydentFio, prepodFio, dispName, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADBall.Text }, id.ToString());

                //if (id == 0)
                //    Functional.Controller.InsertIn(SpecialSqlController.Tables.yspeh, new List<string> { stydentFio, prepodFio, dispFio, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADBall.Text });
                //else
                //    Functional.Controller.UpdateIn(SpecialSqlController.Tables.yspeh, new List<string> { stydentFio, prepodFio, dispFio, Convert.ToDateTime(CnrData.SelectionRange.Start).ToString("yyyyMMdd"), ADBall.Text }, id.ToString());


                this.Close();
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

        private void ADZach_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void ADPrepod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }

        private void ADDisp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 32)
            {
                e.Handled = true;
            }
        }
    }
}
