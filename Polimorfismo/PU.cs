using System;
using System.Collections.Generic;
using System.Text;


//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Polimorfismo
{
    //criação da classe PU (produto usado) que herda da classe Produto
    class PU : Produto
    {
        //Encapsulamento da Data
        public DateTime Data { get; set; }

        //método construtor da classe PU herdando da classe Produto
        public PU(string nome, double preco, DateTime data) : base(nome, preco)
        {
            Nome = nome;
            Preço = preco;
            Data = data;
        }

        //override para sobrescrever os valores da Etiqueta e retornar Nome, Preço e Data de fabricação
        public override string Etiqueta()
        {
            return Nome + " (usado) : R$ " + Preço + " (fabricado no dia: " + Data + ")";
        }
    }
}
