using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Dados_de_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel da classe
            Pessoa A;
            Pessoa B;

            //isntanciar a variavel
            A = new Pessoa();
            B = new Pessoa();

            //info para o meu usuario
            Console.WriteLine("Informe o nome da pessoa A");
            A.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da pessoa A");
            A.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o nome da pessoa B");
            B.nome = Console.ReadLine();
            Console.WriteLine("Informe aidade da passoa B");
            B.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //comparando a idade
            if(A.idade>B.idade)
            {
                Console.WriteLine("Pessoa mais velha:" + A.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha:" + B.nome);
            }
            Console.ReadKey();
        }

    }
}
