using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_IntermediateLevel.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] linhas, int quantidadeDeLinhas) LerArquivo(string caminho)
        {
            try //retorno para caso a tentativa seja bem sucedida
            {
                string[] linhas = File.ReadAllLines(caminho);

                //retornar se a leitura foi feita (bool)
                //retornar as linhas lidas (array)
                //retornar a quantidade de linhas (int)
                return (true, linhas, linhas.Count());
            }
            catch (Exception) //retorno para caso a tentativa não seja bem sucedida
            {
                return (false, new string[0], 0);
            }

        }
    }
}