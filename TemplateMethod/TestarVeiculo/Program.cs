using System;
using tm2.Enumerador;
using tm2.Abstrato;
using tm2.Concreto;

namespace tm2{
  class Program{
     static void Main(string[] args){
      
        TestarVeiculo veiculo;
        
//Procura pelo nome 
      System.Console.WriteLine("Digite o nome do veiculo: ");
      string nome=Console.ReadLine();
        
        try{
            Transporte t = Enum.Parse<Transporte>(nome);
            switch(t){

                case Transporte.aviao:
                     veiculo = new Aviao();
                     veiculo.testarVeiculo();
                     break;

                case Transporte.caminhao:
                     veiculo = new Caminhao();
                     veiculo.testarVeiculo();
                     break;

                case Transporte.carro:
                     veiculo = new Carro();
                     veiculo.testarVeiculo();
                     break;

                case Transporte.moto:
                     veiculo = new Moto();
                     veiculo.testarVeiculo();
                     break;     

            }
/*
            if(t==Transporte.aviao){
                veiculo = new Aviao();
                veiculo.testarVeiculo();
            }else if(t==Transporte.caminhao){
                veiculo = new Caminhao();
                veiculo.testarVeiculo();
            }else if(t==Transporte.carro){
                veiculo = new Carro();
                veiculo.testarVeiculo();
            }else if(t==Transporte.moto){
                veiculo = new Moto();
                veiculo.testarVeiculo();
            }
                */
        }catch(Exception e){
            System.Console.WriteLine("Veiculo nao Encontrado");
           
        }                      

        }}}
    
