using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_de_Csharp
{
    class Program
    {

       
        static void Main(string[] args)
        {
    
        // Primeiro exercicio

        Console.WriteLine("Olá Mundo");

            // Segundo exercicio : Imprima o nome que o usuario digitou na tela

            Console.WriteLine("Digite seu nome: ");
          //  string nome = Console.ReadLine();
           // Console.WriteLine($"Seu Bem vindo {nome}");
            Console.ReadLine();

            //Terceiro Exercicio : intercale  alunos e bem vindos na tela
            string alunos = "ALUNOS 1";
            string bv = "Bem vindos";

            Console.WriteLine("Caros" + alunos +"sejam" + bv + "ao C#");
            Console.ReadLine();

            //Quarto Exercicio: faça as seguintes calculos 
            // soma de 2 com 3(2+3)...

            int soma;
            int numero1 = 2;
            int numero2 = 3;
            soma = numero1 + numero2;
            Console.WriteLine("A soma é " + soma);
            Console.ReadLine();

            //a divisao de 40 por 8 40/8...
            int divisao;
            int divi1 = 40;
            int divi2 = 8;
            divisao = divi1 / divi2;
            Console.WriteLine("A divisao é " + divisao);
            Console.ReadLine();

            //o resto da divisao de 15 por 4 15%8
            double resto;
            int num1 = 15;
            int num2 = 8;
            resto = num1 % num2;
            Console.WriteLine("O resto é\n " + resto);
            Console.ReadLine();

            //Quinto Exercicio 
            Casa CasaDoJoao = new Casa();
            CasaDoJoao.area = 5;
            Console.WriteLine(CasaDoJoao.area);
            Console.ReadLine();
        }
    }
}
