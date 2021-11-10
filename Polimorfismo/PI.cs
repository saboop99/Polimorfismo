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
        //Encapsulamento do VALORTOTALCOMTAXA
        public double VALORTOTALCOMTAXA { get; set; }

        //método construtor da classe PI herdando da classe Produto
        public PI(string nome, double preço, double taxa, double valorTotalcomTaxa) : base(nome, preço)
        {
            Nome = nome;
            Preço = preço;
            Taxa = taxa;
            VALORTOTALCOMTAXA = valorTotalcomTaxa;
        }

        //override para sobrescrever os valores da Etiqueta e retornar Nome, Preço, Taxa e VALORTOTALCOMTAXA
        public override string Etiqueta()
        {
            return Nome + " : R$ " + Preço +  " (Taxa: " + Taxa + ")" + "Valor total com taxa: " + VALORTOTALCOMTAXA;

        }
    }
}
