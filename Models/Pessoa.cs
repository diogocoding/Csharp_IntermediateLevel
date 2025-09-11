using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_IntermediateLevel.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get //o get é executdo td vez que tentam ler o valor da propriedade Nome
            {
                return _nome.ToUpper();
            }

            set //o set é executado sempre que tentam atribuir algum valor a Nome
            {
                //value é o argumento que está recebendo o nome
                if (value == " ")
                {
                    //excesão que o código gera - a exceção interrompe o código
                    //o throw volta o programa e encerra
                    throw new ArgumentException("o nome não pode ser vazio");
                }
                //caso valor seja != de " " o _nome receberá a string
                else
                {
                    _nome = value;
                }
            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Valores negativos ou muito altos não são aceitos. Por favor, digite uma idade válida");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
        }
    }
}