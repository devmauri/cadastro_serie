using System;

namespace Cadastro.Series
{
    public class Menu
    {
        private Tela tela;
        public Menu()
        {
            tela = new Tela();
        }
        public void MostrarPrincipal()
        {
            tela.Separar("Informe a opção desejada:");

            tela.Escrever($"\t{(int)OpcoesPrincipais.Listar}- Listar séries");
            tela.Escrever($"\t{(int)OpcoesPrincipais.Inserir}- Inserir séries");
            tela.Escrever($"\t{(int)OpcoesPrincipais.Atualizar}- Atualizar séries");
            tela.Escrever($"\t{(int)OpcoesPrincipais.Excluir}- Excluir séries");
            tela.Escrever($"\t{(int)OpcoesPrincipais.Visualizar}- Consulta por ID");
            tela.Escrever($"\t{(int)OpcoesPrincipais.LimparTela}- Limpar Tela");
            tela.Escrever($"\t{(int)OpcoesPrincipais.Sair}- Sair");
            tela.Separar();
            tela.Escrever("Opcao:");
        }

    }
}