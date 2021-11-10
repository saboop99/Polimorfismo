using System;
using System.Collections.Generic;
using System.Text;


//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Polimorfismo
{
    //criação da classe produto
    class Produto
    {
        //Encapsulamento do Nome
        public string Nome { get; set; }
        //Encapsulamento do Preço
        public double Preço { get; set; }
        //método construtor da classe Produto
        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }
        
        //criação da Etiqueta, que retorna o preço e o nome do produto
        public virtual string Etiqueta()
        {
            return Nome + ": R$ " + Preço;
        }
    }
}
