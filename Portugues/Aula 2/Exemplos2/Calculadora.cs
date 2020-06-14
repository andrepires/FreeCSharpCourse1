//Referencias a outras bibliotecas de codigo
using System;

/// <summary>
/// Esse e um espaco de nomes (namespace).
/// Pense nisso como se fosse uma gaveta de um armario.
/// Basicamente serve para manter seus tipos de forma organizada
/// </summary>
namespace Exemplos2
{
    /// <summary>
    /// Define o tipo Calculadora
    /// </summary>
    public class Calculadora
    {
        //Define duas propriedades numericas e fracionaveis
        public decimal X { get; set; }
        public decimal Y { get; set; }

        //Esse e o metodo construtor padrao
        public Calculadora()
        {
            //E nao esta fazendo nada especial, podendo ser removido
        }

        //Este e um construtor customizado
        //Note o uso de parametros de entrada
        public Calculadora(decimal x, decimal y)
        {
            //Pega os valores dos parametros de entrada
            //e joga para as propriedades X e Y.
            //Dessa forma os valores podem ser usados posteriormente por outras operacoes
            X = x;
            Y = y;
        }

        //Define um metodo personalizado que realiza algumas tarefas
        internal void ImprimirSoma()
        {
            //Define uma variavel para armazenar a soma de X e Y
            //Note o uso do operado aritmetico +
            var soma = X + Y;
            //Imprime a soma
            Console.WriteLine("A soma de X e Y é: {0}", soma);
        }

        //Define outro metodo para executar outras operacoes
        internal void ImprimirSubtracao()
        {
            //Note o uso do operador aritmetico -
            var subtracao = X - Y;
            //Imprime a subtracao
            Console.WriteLine("A subtracao de Y em X é: {0}", subtracao);
        }
    }
}