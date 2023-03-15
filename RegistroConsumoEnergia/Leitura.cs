﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroConsumoEnergia
{
    class Leitura{
        //atributos
        public string Casa { get; set; }
        public double Consumo { get; set; }
        public double Desconto{
            get { return Consumo * 0.2; }
        }

        //construtor
        public Leitura(string casa, double consumo){
            this.Casa = casa;
            this.Consumo = consumo;
        }

        //Sobrescrita de metodo
        public override bool Equals(object obj){
            Leitura leitura = obj as Leitura;
            if (leitura == null) return false;
            return (Casa.Equals(leitura.Casa));
        }

        public override int GetHashCode()
        {
            return new { Casa, Consumo }.GetHashCode();
        }
    }
}
