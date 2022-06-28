using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class DatosBD
    {
        private static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        private static string DBFileName = "InfraccionesV2.0.accdb";

        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;
        private static DataSet Ds;

        public static void PonerPathBaseAccess(string path)
        {
            ConnectionString += path + @"\" + DBFileName;
        }
        public static List<Dictionary<string, string>> Recuperar(string tabla, string[] columnas = null, Dictionary<string, object> condiciones = null, string[] operadores = null)
        {
            List<Dictionary<string, string>> datos = new List<Dictionary<string, string>>();
            
            if (operadores == null) 
                operadores = new string[] { };

            string query = "SELECT ";
            
            if (columnas == null)
                query += "* ";
            else
            {
                for (int i = 0; i < columnas.Length; i++)
                {
                    query += (i != 0) ? ", " : "";
                    query += columnas[i];
                }
                query += " ";
            }

            query += "FROM " + tabla;
            
            if (condiciones != null)
            {
                query += " WHERE ";
                int i = 0;
                foreach(KeyValuePair<string, object> condicion in condiciones)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condicion.Key + " = " + EscapeValue(condicion.Value);
                    i++;
                }
            }

            Console.WriteLine(query);

            Con = new OleDbConnection(ConnectionString);
            Con.Open();

            Da = new OleDbDataAdapter(query, Con);
            Ds = new DataSet();
            Da.Fill(Ds);


            foreach (DataRow fila in Ds.Tables[0].Rows)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();

                foreach (DataColumn columna in Ds.Tables[0].Columns)
                    dict[columna.ColumnName] = fila.ItemArray[columna.Ordinal].ToString();
                
                datos.Add(dict);
            }

            Con.Close();
            Ds.Dispose();
            Da.Dispose();

            return datos;
        }
        public static void Registrar(string tabla, Dictionary<string, object> columnas)
        {
            string query = "INSERT INTO " + tabla;

            if (columnas != null)
            {
                int i = 0;

                query += "(";

                foreach (KeyValuePair<string, object> columna in columnas)
                {
                    query += (i != 0) ? ", " : "";
                    query += columna.Key;
                    i++;
                }

                query += ") VALUES(";

                i = 0;
                foreach (KeyValuePair<string, object> columna in columnas)
                {
                    query += (i != 0) ? ", " : "";
                    query += EscapeValue(columna.Value);
                    i++;
                }

                query += ")";
            }

            Console.WriteLine(query);

            Con = new OleDbConnection(ConnectionString);
            Con.Open();

            Cmd = new OleDbCommand(query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close();
            Cmd.Dispose();
        }
        public static void Actualizar(string tabla, Dictionary<string, object> columnas, Dictionary<string, object> condiciones = null, string[] operadores = null)
        {
            string query = "UPDATE " + tabla + " SET ";

            int i = 0;
            foreach (KeyValuePair<string, object> columna in columnas)
            {
                query += (i != 0) ? ", " : "";
                query += columna.Key + " = " + EscapeValue(columna.Value);
                i++;
            }

            if (condiciones != null)
            {
                query += " WHERE ";

                i = 0;
                foreach (KeyValuePair<string, object> condicion in condiciones)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condicion.Key + " = " + EscapeValue(condicion.Value);
                    i++;
                }

            }

            Console.WriteLine(query);

            Con = new OleDbConnection(ConnectionString);
            Con.Open();

            Cmd = new OleDbCommand(query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close();
            Cmd.Dispose();
        }
        public static void Eliminar(string tabla, Dictionary<string, object> condiciones, string[] operadores = null)
        {
            string query = "DELETE FROM " + tabla;

            if (condiciones != null)
            {
                query += " WHERE ";

                int i = 0;
                foreach (KeyValuePair<string, object> condicion in condiciones)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condicion.Key + " = " + EscapeValue(condicion.Value);
                    i++;
                }

            }

            Console.WriteLine(query);

            Con = new OleDbConnection(ConnectionString);
            Con.Open();

            Cmd = new OleDbCommand(query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close();
            Cmd.Dispose();
        }
        public static int GetUltimoId(string tabla, string columna)
        {
            string query = "SELECT MAX(" + columna + ") FROM " + tabla;

            Con = new OleDbConnection(ConnectionString);
            Con.Open();

            Da = new OleDbDataAdapter(query, Con);
            Ds = new DataSet();
            Da.Fill(Ds);

            DataRow filaDS = Ds.Tables[0].Rows[0];
            DataColumn columnaDS = Ds.Tables[0].Columns[columna];
            int id = int.Parse(Ds.Tables[0].Rows[0].ItemArray[columnaDS.Ordinal].ToString());

            Con.Close();
            Ds.Dispose();
            Da.Dispose();

            return id;
        }

        private static string EscapeValue(object value)
        {
            Type type = value.GetType();
            string result = "";

            if (type == typeof(string))
                result = "'" + (string)value + "'";
            else if (type == typeof(char))
                result = "'" + (char)value + "'";
            else if (type == typeof(DateTime))
            {
                DateTime dt = (DateTime)value;
                result = "#" + dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString() + "#";
            }
            else
                result = value.ToString();
            
            return result;
        }
    }
}
