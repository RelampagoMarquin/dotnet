using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exOO {
    public class Lampada
    {
        private Boolean ligada;
        private double potencia;

        public Lampada(){
            this.ligada = false;
            this.potencia = 10;
        }
        public void ligar(){
            this.ligada = true;
        }

        public void desligar(){
            this.ligada = false;
        }

        public Boolean estaLigada(){
            return this.ligada;
        }
    }

    class Programa{
        static void Main(){
            Lampada l = new Lampada();
            l.ligar();
            Console.WriteLine(l.estaLigada());
        }
    }
}