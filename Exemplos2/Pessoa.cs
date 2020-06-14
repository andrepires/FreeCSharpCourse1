//Referencias a outras bibliotecas de codigo
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Esse e um espaco de nomes (namespace).
/// Pense nisso como se fosse uma gaveta de um armario.
/// Basicamente serve para manter seus tipos de forma organizada
/// </summary>
namespace Exemplos2
{
    /// <summary>
    /// Define o tipo Pessoa
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; internal set; }
        public string Sobrenome { get; internal set; }
        public int Idade { get; internal set; }
    }
}