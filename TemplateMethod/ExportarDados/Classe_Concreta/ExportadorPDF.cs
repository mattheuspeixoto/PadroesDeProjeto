using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tm.Classe_Abstrata;

namespace Tm.Classe_Concreta {

    class ExportadorPDF : ExportadordeDados   {
        public override void ExportarDados(){
            Console.WriteLine("Exportando os dados para PDF");
        }

        public override  void FinalizarExportacao()
        {
            Console.WriteLine("Exportacao Finalizada Com Sucesso");

        }
    }
}