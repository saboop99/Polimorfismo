using System;
using System.Collections.Generic;
using System.Text;


//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Polimorfismo
{
    //criação da classe PI (produto importado) que herda da classe Produto
    class PI : Produto
    {
        //Encapsulamento da Taxa
        public double Taxa { get; set; }

        //método construtor da classe PI herdando da classe Produto
        public PI(string nome, double preço, double taxa) : base(nome, preço)
        {
            Nome = nome;
            Preço = preço;
            Taxa = taxa;
        }

        //override para sobrescrever os valores da Etiqueta e retornar Nome, Preço e Taxa
        public override string Etiqueta()
        {
            return Nome + " : R$ " + Preço + " (Taxa: " + Taxa + ")" + " Valor com a Taxa do produto: " + Taxa * Preço;

        }
    }
}
