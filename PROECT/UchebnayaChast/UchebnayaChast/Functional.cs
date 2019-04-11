using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebnayaChast
{
    static class Functional
    {
        static public SpecialSqlController Controller=new SpecialSqlController();

        static public List<Dictionary<string, string>> DataList = new List<Dictionary<string, string>>();

        public delegate void Additional(ref List<Dictionary<string, string>> data);

        public delegate bool FiltrTag(Dictionary<string, string> row);

        public delegate bool TestValid();

        public delegate bool AdditionalDelete(string[] s);

        public delegate Dictionary<string, string> CreateRow(Dictionary<string, string> row);

        static public void Sort(string parametr, int flag)
        {
            if (DataList == null || DataList.Count == 0)
                return;
            bool again = false;
            int n;
            bool isNumber = Int32.TryParse(DataList.First()[parametr], out n);
            {
                try
                {
                    for (int i = 0; i < DataList.Count; i++)
                        for (int j = 0; j < DataList.Count - 1; j++)
                        {
                            bool test;
                            if (isNumber)
                                test = ((Convert.ToInt32(DataList[j][parametr]) > Convert.ToInt32(DataList[j + 1][parametr]) && flag == 1) || (Convert.ToInt32(DataList[j][parametr]) < Convert.ToInt32(DataList[j + 1][parametr]) && flag == -1));
                            else
                                test = (DataList[j][parametr].CompareTo(DataList[j + 1][parametr]) == flag);
                            if (test)
                            {
                                Dictionary<string, string> t = DataList[j];
                                DataList[j] = DataList[j + 1];
                                DataList[j + 1] = t;
                            }
                        }
                }
                catch
                {
                    if (isNumber)
                        isNumber = false;
                    else
                        return;
                    again = true;
                }
            } while (again) ;

        }

        static public void Filtres(FiltrTag[] filtrs, string sms="Данных нет")
        {
            for (int i = 0; i < DataList.Count; i++)
            {
                bool test = false;
                for (int j = 0; j < filtrs.Count(); j++)
                    test = test || filtrs[j](DataList[i]);
                if (test)
                {
                    DataList.RemoveAt(i);
                    i--;
                }

            }
            if (DataList.Count == 0)
                Error(sms);
        }

        static public void Error(string text)
        {
            MessageBox.Show(text);
        }

        static public void Print(ref DataGridView view)
        {
            view.Rows.Clear();
            for (int j = 0; j < DataList.Count; j++)
            {
                view.Rows.Add();
                foreach (var l in DataList[j])
                {
                    //   if (l.Key != "Enable"&&l.Key!="CanTake")
                    view.Rows[view.RowCount - 1].Cells[l.Key].Value = l.Value;
                }
            }
        }

        static public void GetData(SpecialSqlController.Tables table, Additional additional = null)
        {
            DataList = Controller.GetAllFromWithNames(table);
            if (additional != null)
            {
                additional(ref DataList);
            }
        }

        static public string GetId(DataGridView view)
        {
            return (view[0, view.SelectedRows[0].Index] as DataGridViewCell).Value.ToString();
        }

        static public bool RowTest(DataGridView view, bool withMessage = true)
        {
            if (view.SelectedRows.Count > 0)
                return true;
            else
            {
                if (withMessage)
                    Error("Строка не выбрана");
                return false;
            }
        }

        //FORMA

        public static bool CheckTest(TestValid[] tests)
        {
            bool result = false;
            foreach (var t in tests)
            {
                result = result || t();
                if (result) break;
            }
            return !result;
        }

        public static void Delete (DataGridView grid, SpecialSqlController.Tables table, string question= "Вы действительно хотите удалить?")
        {
            if (RowTest(grid))
            {
                DialogResult a = MessageBox.Show(question, "Удалить", MessageBoxButtons.OKCancel);
                if (a == DialogResult.OK)
                    Controller.DeleteFrom(table, int.Parse(GetId(grid)));
            }
        }
    }
}
