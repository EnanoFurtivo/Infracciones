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
                    query += condicion.Key + " = ";
                    query += (typeof(string) == condicion.Value.GetType()) ? "'" : "";
                    query += condicion.Value;
                    query += (typeof(string) == condicion.Value.GetType()) ? "'" : "";
                    i++;
                }
              /*  for (int i = 0; i < condiciones.Count; i++)
                {
                    query += (i != 0) ? (operadores[i-1]+" ") : "";
                    query += condiciones.get + " = '" + condiciones[i,1] + "'";
                }*/
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
                query += "(";
                for (int i = 0; i < columnas.GetLength(0); i++)
                {
                    query += (i != 0) ? ", " : "";
                    query += columnas[i,0];
                }
                query += ") VALUES(";
                for (int i = 0; i < columnas.GetLength(0); i++)
                {
                    query += (i != 0) ? ", " : "";
                    query += columnas[i, 1];
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
            string query = "UPDATE " + tabla;

            query += " SET ";
            for (int i = 0; i < columnas.GetLength(0); i++)
            {
                query += (i != 0) ? ", " : "";
                query += columnas[i,0] + " = " + columnas[i,1];
            }

            if (condiciones != null)
            {
                query += " WHERE ";
                for (int i = 0; i < condiciones.GetLength(0); i++)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condiciones[i, 0] + " = " + condiciones[i, 1];
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
                for (int i = 0; i < condiciones.GetLength(0); i++)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condiciones[i, 0] + " = " + condiciones[i, 1];
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
    }
}
