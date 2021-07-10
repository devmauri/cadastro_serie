using System;

namespace Cadastro.Series
{
    /// <summary>
    ///Cadantro de series sem persistencia de dados.
    /// </summary>
    partial class Program
    {
        private Tela tela;
        private SerieContainer sc;
        static void Main(string[] args)
        {
            //é mais recomendável trabalhar com métodos de um objeto 
            //do que com recursos estáticos. Dessa forma o Main servirá
            //apenas como chamada ao programa.
            var CS = new Program();
            if (args.Length > 1)
            {
                CS.tela.Escrever("Programa não aceita argumentos em sua inicialização.");
            }
            CS.Loop();

        }

        /// <summary>
        /// Inicializa variáveis e instancia Program
        /// </summary>
        public Program()
        {
            tela = new Tela();
            sc = new SerieContainer();
        }

        /// <summary>
        /// Dá inicio de fato ao programa e 
        /// fica no loop Menu principal
        /// </summary>
        private void Loop()
        {
            Menu menu = new Menu();

            bool sair = false;
            int opcao = -1;
            while (!sair)
            {
                menu.MostrarPrincipal();
                opcao = tela.ReadInt();
                tela.Limpar();
                if (!OpcaoValida(opcao))
                {
                    tela.Escrever("Opção inválida: " + opcao);
                    continue;
                }
                MostraOpcao(opcao);


                if (opcao == 0)
                {
                    sair = true;
                }
            }
        }

        private bool OpcaoValida(int opcao)
        {
            return (opcao >= 0 || opcao <= 9);
        }

        private void MostraOpcao(int opcao)
        {
            switch (opcao)
            {
                case (int)OpcoesPrincipais.Atualizar:
                    this.Atualizar();
                    break;

                case (int)OpcoesPrincipais.Excluir:
                    this.Excluir();
                    break;

                case (int)OpcoesPrincipais.Inserir:
                    this.Inserir();
                    break;

                case (int)OpcoesPrincipais.Listar:
                    this.Listar();
                    break;

                case (int)OpcoesPrincipais.Visualizar:
                    this.ConsultaId();
                    break;

                case (int)OpcoesPrincipais.LimparTela:
                    tela.Limpar();
                    break;

                default:
                    tela.OpInvalida(opcao);
                    break;
            }
        }

        ~Program()
        {
            this.tela.Escrever("Até mais e obrigado pela preferencia!");
        }
    }
}
