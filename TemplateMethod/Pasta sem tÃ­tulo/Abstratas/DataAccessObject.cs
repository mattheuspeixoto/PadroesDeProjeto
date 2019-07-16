using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DPTemplateMethod
{
    /// <summary>
    /// Classe Abstrata de Acesso a Dados
    /// </summary>
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public void Conectar()
        {
            //connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            //                    "Data Source=F:\\GoogleDrive\\Aulas\\FAMETRO\\MAP\\Cadeira\\Implementacao\\Pratica\\TemplateMethod\\bd.mdb; " +
            //                    "Persist Security Info=False;";
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=C:\\map\\bd.mdb; " +
                                "Persist Security Info=False;";
        }

        public abstract void Select();

        public abstract void Processar();

        public void Desconectar()
        {
            connectionString = "";
        }

        // O próprio 'Template Method'
        public void RodarConsulta()
        {
            Conectar();
            Select();
            Processar();
            Desconectar();
        }

    }
}
