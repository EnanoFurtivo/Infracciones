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
        private static string DBFileName = "Infracciones.accdb";

        public static void PonerPathBaseAccess(string path)
        {
            ConnectionString += path + @"\" + DBFileName;
        }
        public static List<Dictionary<string, string>> Recuperar(string tabla, string[] columnas = null, string[,] condiciones = null, string[] operadores = null)
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
                for (int i = 0; i < condiciones.Length; i++)
                {
                    query += (i != 0) ? (operadores[i-1]+" ") : "";
                    query += condiciones[i,0] + " = " + condiciones[i,1];
                }
            }

            Console.WriteLine(query);

            OleDbConnection Con = new OleDbConnection(ConnectionString);
            Con.Open();

            OleDbDataAdapter Da = new OleDbDataAdapter(query, Con);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            foreach (DataColumn columna in Ds.Tables[0].Columns)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict[columna.ColumnName] = fila.ItemArray[columna.Ordinal].ToString();
                    datos.Add(dict);
                }
            }

            Con.Close();
            Ds.Dispose();
            Da.Dispose();

            return datos;
        }
        public static void Registrar(string tabla, string[,] columnas)
        {
            string query = "INSERT INTO " + tabla;

            if (columnas != null)
            {
                query += "(";
                for (int i = 0; i < columnas.Length; i++)
                {
                    query += (i != 0) ? ", " : "";
                    query += columnas[i,0];
                }
                query += ") VALUES(";
                for (int i = 0; i < columnas.Length; i++)
                {
                    query += (i != 0) ? ", " : "";
                    query += columnas[i, 1];
                }
                query += ")";
            }

            Console.WriteLine(query);

            OleDbConnection Con = new OleDbConnection(ConnectionString);
            Con.Open();

            OleDbCommand Cmd = new OleDbCommand(query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close();
            Cmd.Dispose();
        }
        public static void Actualizar(string tabla, string[,] columnas, string[,] condiciones = null, string[] operadores = null)
        {
            string query = "UPDATE " + tabla;

            query += " SET ";
            for (int i = 0; i < columnas.Length; i++)
            {
                query += (i != 0) ? ", " : "";
                query += columnas[i,0] + " = " + columnas[i,1];
            }

            if (condiciones != null)
            {
                query += " WHERE ";
                for (int i = 0; i < condiciones.Length; i++)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condiciones[i, 0] + " = " + condiciones[i, 1];
                }
            }

            Console.WriteLine(query);

            OleDbConnection Con = new OleDbConnection(ConnectionString);
            Con.Open();

            OleDbCommand Cmd = new OleDbCommand(query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close();
            Cmd.Dispose();
        }
        public static void Eliminar(string tabla, string[,] condiciones, string[] operadores = null)
        {
            string query = "DELETE FROM " + tabla;

            if (condiciones != null)
            {
                query += " WHERE ";
                for (int i = 0; i < condiciones.Length; i++)
                {
                    query += (i != 0) ? (operadores[i - 1] + " ") : "";
                    query += condiciones[i, 0] + " = " + condiciones[i, 1];
                }
            }

            Console.WriteLine(query);

            OleDbConnection Con = new OleDbConnection(ConnectionString);
            Con.Open();

            OleDbCommand Cmd = new OleDbCommand(query, Con);
            Cmd.ExecuteNonQuery();

            Con.Close();
            Cmd.Dispose();
        }
    }
}
