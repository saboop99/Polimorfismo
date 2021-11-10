using System;
using System.Collections.Generic;
using System.Globalization;


//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de uma nova lista Produto
            List<Produto> list = new List<Produto>();
            //pedir ao usuário para entrar com a quantidade de produtor
            Console.WriteLine("Entre com o número de produtos: ");
            //conversão do valor digitado para int
            int n = int.Parse(Console.ReadLine());

            //utilização do for, condicional para passar por todos os elementos da lista
            for (int i = 1; i <= n; i++)
            {
                //mostrar na tela o número do Produto (Produto #1) de acordo com a condicional do for (i)
                Console.WriteLine($"Produto #{i}:");  
                //pedir ao usuário para digitar o Nome do produto
                Console.Write("Nome do produto: ");
                //guardar o que foi digitado na variavel nome
                string nome = Console.ReadLine();
                //pedir ao usuário para digitar o preço do produtor
                Console.Write("Preço do produto: ");
                //conversão do valor digitado para double a armazenamento na variavel preço
                double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //pedir ao usuário para digitar se o produto é Comum, Usado ou Importado usando apenas os caracteres iniciais de cada um (C/U/I)
                Console.WriteLine("Comum, Usado ou Importado (C/U/I)? ");
                //conversão do que foi digitado para char e armazenamento na variável ch
                char ch = char.Parse(Console.ReadLine());
               
                //condicional caso o usuário digite C
                if (ch == 'C')
                {
                    //adição de uma nova lista com as variavéis nome e preço
                    list.Add(new Produto(nome, preço));
                }

                //condicional caso o usuário digite U
                else if (ch == 'U')
                {
                    //pedir ao usuário para digitar o dia, o mês e o ano de fabricação do produtor
                    Console.WriteLine("Fabricado (DD/MM/AA): ");
                    //conversão do que foi digitado para DateTime e armazenamento na variável data
                    DateTime data = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //adição de uma nova lista com as variavéis nome, preço e data
                    list.Add(new PU(nome, preço, data));
                }

                //condicional caso o usuário digite I
                else if (ch == 'I')
                {
                    //pedir ao usuário para digitar o valor da Taxa de alfândega
                    Console.Write("Taxa de alfândega: ");
                    //conversão do que foi digitado para double e armazenamento do valor na variável taxa
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //operação cujo resultado é adicionado na variavel valorTotalcomTaxa
                    double valorTotalcomTaxa = preço + (preço * taxa / 100);
                    //adição de uma nova lista com as variavéis nome, preço, taxa e o valorTotalcomTaxa
                    list.Add(new PI(nome, preço, taxa, valorTotalcomTaxa));
                }

                //pular uma linha
                Console.WriteLine();

                //Escrever na tela para podermos saber que se trata das etiquetas dos produtos
                Console.WriteLine("Etiquetas: ");

                //utilização do foreach para passar por todos os elementos da lista
                foreach (Produto produto in list)
                {
                    //Escrever na tela a Etiqueta dos produtos conforme adicionados
                    Console.WriteLine(produto.Etiqueta());
                }
                //pular uma linha
                Console.WriteLine();
            }
        }
    }
}
