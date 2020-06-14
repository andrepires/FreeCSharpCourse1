using System;

namespace Exemplos2
{
    class Program
    {
        /// <summary>
        /// Ponto de entrada do aplicativo.
        /// E onde o programa comeca a ser executado
        /// </summary>
        static void Main(string[] args)
        {
            //Cria um objeto do tipo Pessoa
            var pessoa = new Pessoa();
            //Imprime uma saudaçao na tela
            Console.WriteLine("Ola!");
            //Pede para o usuario digitar o nome
            Console.WriteLine("Por favor, digite seu primeiro nome:");
            var nome = Console.ReadLine();
            //Pede para o usuario digitar o sobrenome
            Console.WriteLine("Por favor digite seu sobrenome:");
            var sobrenome = Console.ReadLine();
            //Pede para o usuario digitar a idade
            Console.WriteLine("Agora digite sua idade:");
            var idade = Console.ReadLine();
            //Usa os dados informados para configurar o estado do objeto pessoa
            pessoa.Nome = nome;
            pessoa.Sobrenome = sobrenome;
            //Essa linha converte a idade do tipo texto para o tipo inteiro
            pessoa.Idade = Convert.ToInt32(idade);
            //Imprime a mensagem final de forma bacaninha :)
            Console.WriteLine("Prazer em conhecer {0} {1}. Voce disse que sua idade é {2}",
                pessoa.Nome, pessoa.Sobrenome, pessoa.Idade);

            Console.WriteLine("Agora digite um numero:");
            var x = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite um outro numero:");
            var y = Convert.ToDecimal(Console.ReadLine());

            var calculadora = new Calculadora(x, y);

            calculadora.ImprimirSoma();
            calculadora.ImprimirSubtracao();

            //Mantem o programa ativo e a espera que algo seja digitado
            //Quando o usuario digita algo, o program e finalizado
            Console.Read();
        }
    }
}
