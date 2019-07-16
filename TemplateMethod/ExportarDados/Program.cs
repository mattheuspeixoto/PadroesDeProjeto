using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tm.Classe_Abstrata;
using Tm.Classe_Concreta;

namespace Tm{
    class Program{
        static void Main(string[] args) {

            ExportadordeDados exportador ;

            exportador= new ExportadorExcel();
            exportador.ExportarDadosFormatados();

            exportador= new ExportadorPDF();
            exportador.ExportarDadosFormatados();
            
        }
    }
}