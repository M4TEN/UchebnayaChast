using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;

namespace UchebnayaChast
{
   public class SpecialSqlController : SqlController
    {
        public SpecialSqlController() : base() { }

        public SpecialSqlController(string connectionString) : base(connectionString) { }

        public enum Tables
        {
            disp=0,gryp=1,kafedra=2,prepod,specly,stydent,yspeh
        }
 
        public List<string> ColumnsNames(MySqlCommand command)
        {
            command.Connection.Open();
           List<string> result = new List<string>();
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        result.Add(reader.GetName(i));

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                result.Clear();
            }
            command.Connection.Close();
            return result;
        }

        public List<string> GetColumnsNames(Tables table)
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString()+" limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return ColumnsNames(command);
            }
            else
                return new List<string>();
        }//возвр имена столбцов в табличке

        public List<List<string>> GetAllFrom(Tables table, string where)
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString() + " where " + where;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDate(command);
            }
            else
                return new List<List<string>>();
        }//возвращает всё в виде двумерного массива с условием

        public List<List<string>> GetAllFrom(Tables table)
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString() + " ";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDate(command);
            }
            else
                return new List<List<string>>();
        }//возвращает всё в виде двумерного массива без условия

        public List<Dictionary<string, string>> GetAllFromWithNames(Tables table,string where)
        {
            if (Connection != null)
            {
                string text = "select * from " + table.ToString()+" where ("+where+")";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDateWithNames(command);
            }
            else
                return new List<Dictionary<string, string>>();
        }//возвр всё с именами столбцов с условием

        public List<Dictionary<string, string>> GetAllFromWithNames(Tables table)
        {
            if (Connection != null)
            {
                string text = "select * from " + table.ToString() + " ";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDateWithNames(command);
            }
            else
                return new List<Dictionary<string, string>>();
        }//возвр всё с именами столбцов

        public List<string> GetColumn(Tables table,string columnName,bool isDictionary=true)
        {
            if (Connection != null)
            {
                string text = $"select {(isDictionary?"distinct":"")} `{columnName}` from " + table.ToString() + " ";
                MySqlCommand command = new MySqlCommand(text, Connection);
                var s=GetQueryDate(command);
                List<string> res = new List<string>();
                foreach(var i in s)
                {
                    res.Add(i[0]);
                }
                return res;
            }
            else
                return new List<string>();

        }

        public List<string> GetColumn(Tables table, string columnName,string where, bool isDictionary = true)
        {
            if (Connection != null)
            {
                string text = $"select {(isDictionary ? "distinct" : "")} `{columnName}` from " + table.ToString() + " where "+where;
                MySqlCommand command = new MySqlCommand(text, Connection);
                var s = GetQueryDate(command);
                List<string> res = new List<string>();
                foreach (var i in s)
                {
                    res.Add(i[0]);
                }
                return res;
            }
            else
                return new List<string>();

        }


        public bool InsertIn(Tables table,List<string> values,string startAfter="Id",bool removeLast=false)
        {
            if (Connection != null)
            {
                string columns = "(";
                string value= "(";
                List<string> names=   GetColumnsNames(table);  
                for (int i = 0; i <= names.IndexOf(startAfter); i++)
                {
                    names.RemoveAt(i);
                    i--;
                }
                if (removeLast)
                names.Remove(names.Last());
                if (names.Count <= 1)
                return false;
                for (int i = 0; i < names.Count; i++)
            {
                columns += "`" + names[i]+ "`";
                if (i != names.Count - 1)
                    columns += ",";
                else
                    columns += ")";
            }
                if (values.Count<names.Count-1)
                return false;
                for (int i = 0; i < values.Count; i++)
                {
                    int type = 0;
                    if (values[i] == null) type = 2;
                    if (type == 2)
                        value += "null";
                    else
                        value += "'" + values[i] + "'";

                    if (i != values.Count - 1)
                        value += ",";
                    else
                        value += ")";
                }
                string text = "Insert into " + "`"+table.ToString()+ "`" + " " + columns + " values" + value;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;

        }//вставляет данные в табл

        public bool UpdateIn(Tables table, List<string> values,string id)
        {
            if (Connection != null)
            {
                string value = "";
                List<string> names = GetColumnsNames(table);
                names.RemoveAt(0);
                if (names.Count <= 1)
                    return false;
                for (int i = 0; i < values.Count; i++)
                {
                    value += $"`{names[i]}`=";
                    int type = 0;
                    if (values[i] == null) type = 2;
                    if (type == 2)
                        value += "null";
                    else
                        value += "'" + values[i] + "'";

                    if (i != values.Count - 1)
                        value += ",";
                }
                string text = "UPDATE " + "`" + table.ToString() + "` set " +  value+" where Id="+id;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;

        }//обновляет данные

        public bool DeleteFrom(Tables table, int id)
        {
            if (Connection != null)
            {
                string text = "delete from " + "`" + table.ToString() + "`"+ " where Id=" + id;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }//удаляет по айди

        public bool DeleteFrom(Tables table, string where)
        {
            if (Connection != null)
            {
                string text = "delete from `"+table.ToString()+"` where("+where+")" ;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }//удаляет по условию

        public List<string> TakeRow(Tables table, string where)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where " + where + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count!=0)
                return result.First();
                else
                    return new List<string>();
            }
            else
                return new List<string>();
        }//берёт строку по условию 

        public Dictionary<string,string> TakeRowWithNames(Tables table, string where)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where " + where + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<Dictionary<string, string>> result = GetQueryDateWithNames(command);
                if (result.Count != 0)
                   return result.First();
                else
                    return new Dictionary<string, string>();
            }
            else
                return new Dictionary<string, string>();
        }//берёт строку по условию с именами

        public Dictionary<string, string> TakeRowWithNamesById(Tables table, int id)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where Id= '" + id + "' limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<Dictionary<string, string>> result = GetQueryDateWithNames(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new Dictionary<string, string>();
            }
            else
                return new Dictionary<string, string>();
        }//берёт строку по условию по айди с именами

        public List<string> TakeRowById(Tables table, int id)
        {

            if (Connection != null)
            {

                string text = "select * from "+table+" where Id='" + id + "' limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new List<string>();
            }
            else
                return new List<string>();
        }//берёт строку по условию с айди

        public int Maximum(Tables table, string columnname)
        {
            if (Connection != null)
            {
                string text = "select max(" + columnname + ") from " + table.ToString() + " ";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count > 0 && result[0].Count > 0)
                    try
                    {
                        return Convert.ToInt32(result[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }//max

        public int Minimum(Tables table, string columnname)
        {
            if (Connection != null)
            {
                string text = "select min(" + columnname + ") from " + table.ToString() + " ";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count > 0 && result[0].Count > 0)
                    try
                    {
                        return Convert.ToInt32(result[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }//min

        public bool UpdateCell(Tables table, string update, string where)
        {
            if (Connection != null)
            {
                string text = "Update " + "`" + table.ToString() + "`  SET " + update + " WHERE( " + where + " )";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);



            }
            else
                return false;
        }//обновляет одну ячейку в таблице
    }
}

