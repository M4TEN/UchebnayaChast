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
        List<string> saveindexes;

        public FormAddChangeStydent()
        {
            InitializeComponent();

            ADComboGryp.DropDownStyle = ComboBoxStyle.DropDownList;
            ADComboBK.DropDownStyle = ComboBoxStyle.DropDownList;

            Functional.GetData(SpecialSqlController.Tables.stydent, delegate (ref List<Dictionary<string, string>> poka)
            {
                List<string> l = new List<string>();
                int k = 0;
                foreach (var i in poka)
                {
                    if ((i["G_id"] != null) && (i["G_id"].Length > 0))
                    {
                        string s = (Functional.Controller.Query(("select  sp.Sp_nazv from (stydent st join gryp g on st.g_id=g.Id) join specly sp on g.Sp_id=sp.Id where st.Id=" + i["Id"] + " limit 1;")))[0][0];
                        i["G_id"] = s + "-" + (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_kyrs"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_number"]) +
                        (Functional.Controller.TakeRowWithNamesById(SpecialSqlController.Tables.gryp, int.Parse(i["G_id"]))["G_born"]);
                    }
                    if (!l.Contains(i["G_id"]))
                    {
                        l.Add(i["G_id"]);
                        k++;
                    }
                }
                for (int i = 0; i < k; i++)
                    ADComboGryp.Items.Add(l[i]);
            });
        }

        public FormAddChangeStydent(Dictionary<string, string> privet)
        {
            
        }

        private void ADCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
