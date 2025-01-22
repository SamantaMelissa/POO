using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoAoPOO
{
    public class Cachorro
    {
        //Atributos:
            // Nome, raça, idade 
        // tipodeacesso tipodedado nomedoatributo;
        public string Nome;
        public string Raca;
        public int Idade;

        //Métodos:
            //Latir, Correr
        //tipodeacesso tipoderetorno nomedometodo(){}
        public void Latir(){
            Console.WriteLine($"O Cachorro {Nome} latiu.");
        }

        public void Correr(){
            Console.WriteLine($"O cachorro {Nome} correu.");
        }
    }


}