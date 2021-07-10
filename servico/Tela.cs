using System;

namespace Cadastro.Series
{

    /// <summary>
    /// Utilizado para printar informações na tela.
    /// </summary>
    public class Tela
    {
        /// <summary>
        /// Escreve informações na tela com nova linha.
        /// </summary>
        /// <param name="print">Texto a ser impresso.</param>
        public void Escrever(string print)
        {
            Console.WriteLine(print);
        }

        public string LerLinha()
        {
            return Console.ReadLine();
        }

        public void Separar()
        {
            Console.WriteLine("================================================");
        }

        public void Separar(String print)
        {
            Escrever("");
            Separar();
            Escrever(print);
            Separar();
            Escrever("");
        }

        /// <summary>
        /// Fica até retornar um numero interio inserido pelo usuario
        /// </summary>
        /// <returns>Ineiro informado pelo usuario.</returns>
        public int ReadInt()
        {
            int result = 0;
            bool sair = false;
            while (!sair)
            {
                String temp = LerLinha().ToUpper();
                sair = int.TryParse(temp, out result);
                if (!sair)
                {
                    this.Escrever("Por favor informe um numero inteiro.");
                }
            }

            return result;
        }

        /// <summary>
        /// Printa Opção inválida na tela.
        /// </summary>
        /// <param name="opcao">Numero da opção.</param>
        internal void OpInvalida(int opcao)
        {
            this.Escrever("Por favor informe uma opção válida, opção " +
                opcao + " não encontrada.");
        }

        public void Limpar(){
            Console.Clear();
        }
    }
}