using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm.Classe_Abstrata{
    abstract class ExportadordeDados {
        public void LerDados() {
            Console.WriteLine("Lendo dados SQL");
          }
        public void FormatarDados(){
            Console.WriteLine("Formatando os dados conforme o tipo");
          }

             //Varia de acordo com o tipo de arquivo escolhido 
            //operacao gancho
        public abstract void ExportarDados();

        public abstract void FinalizarExportacao();
        
        //Metodo a ser utilizado pelo Cliente
         public void ExportarDadosFormatados(){
            this.LerDados();
            this.FormatarDados();
            this.ExportarDados();
            this.FinalizarExportacao();

        }



    }
}
