//References to other libraries
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// This is a namespace. Think of it as the drawers of your wardrobe.
/// It serves as a way to keep your types organised.
/// </summary>
namespace Exemplos1
{
    /// <summary>
    /// Define o tipo Pessoa.
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; internal set; }
        public string Sobrenome { get; internal set; }
        public int Idade { get; internal set; }
    }
}