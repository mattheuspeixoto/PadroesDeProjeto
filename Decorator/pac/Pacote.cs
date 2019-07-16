﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPacotesViagem
{
    abstract class Pacote{
        private String desc;
        private Double preco;
        
        public Pacote(String desc, Double preco){
            this.desc = desc;
            this.preco = preco;
        }
        public String getDesc(){
            return desc;
        }
        public Double getPreco(){
            return preco;
        }	
    }
}
