using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class Clientes
    {
        // + => Moderador de acesso é PUBLICO
        public string nome;
        public string endereco;
        // # => Moderador de acesso é PROTEGIDO
        // - => Moderador de acesso PRIVADO
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total { get; protected set;}

        public virtual void Pagar_Imposto(float v){
            //valor informado da compra = 500
            this.valor = v;
            // imposto: 10%
            //verificar o valor do imposto?
            // (500*10)/100 = 50
            this.valor_imposto = this.valor * 10 / 100;
            //valor + valor do imposto = total
            this.total = this.valor + this.valor_imposto;
        }
        
    }
}