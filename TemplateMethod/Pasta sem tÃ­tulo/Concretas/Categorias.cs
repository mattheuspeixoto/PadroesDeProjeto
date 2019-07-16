using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DPTemplateMethod
{
    /// <summary>
    /// Classe Concreta de Categorias
    /// </summary>
    class Categorias : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select codigo, nome from Categorias";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categorias");

        }

        public override void Processar()
        {
            Console.WriteLine("---- CATEGORIAS ---- ");
            DataTable dataTable = dataSet.Tables["Categorias"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("Cod: " + row["codigo"] + " - " + row["nome"]);
            }
            Console.WriteLine();
        }
    }
}
