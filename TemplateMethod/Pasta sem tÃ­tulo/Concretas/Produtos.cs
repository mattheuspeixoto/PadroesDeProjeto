using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DPTemplateMethod
{
    /// <summary>
    /// Classe Concreta de Produtos
    /// </summary>
    class Produtos : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select codigo, nome, codigoCategoria " +
                        " from Produtos order by codigoCategoria, nome ";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Produtos");
        }

        public override void Processar()
        {
            Console.WriteLine("---- PRODUTOS ---- ");
            DataTable dataTable = dataSet.Tables["Produtos"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("Cat: " + row["codigoCategoria"] + 
                                    " - " + row["nome"] + " (Cod: " + row["codigo"] + ")");
            }
            Console.WriteLine();
        }
    }
}
