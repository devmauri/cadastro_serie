using System;

namespace Cadastro.Series
{
    partial class Program
    {
        private int Inserir()
        {
            tela.Limpar();
            tela.Separar("Inserir novo Registro.");

            Genero g = InformarGenero();

            tela.Escrever("Digite o Título da Série: ");
            string t = tela.LerLinha();

            tela.Escrever("Digite o Ano de Início da Série: ");
            int ano = tela.ReadInt();

            tela.Escrever("Digite a Descrição da Série: ");
            string d = tela.LerLinha();

            int id = this.sc.Inserir(new Serie(g, t, d, ano));

            if (id >= 0)
            {
                tela.Limpar();
                tela.Separar($"Serie {id} inserida com sucesso.");
            }
            return id;
        }

        private void Listar()
        {
            tela.Limpar();
            tela.Separar("Listando Series Cadastradas");
            var series = this.sc.Listar();
            if (series.Count <= 0)
            {
                tela.Escrever("Nenhuma Serie cadastrada!");
                return;
            }
            foreach (var serie in series)
            {
                tela.Escrever($"#ID {serie.Id}: - {serie.Titulo} {serie.Genero}");
            }
        }

        private void ConsultaId()
        {
            tela.Limpar();
            tela.Separar("Consultando por ID");
            tela.Escrever("Por favor informe o ID a ser consultado.");
            int id = tela.ReadInt();            

            Serie serie = ConsultaId(id);
            if ( serie == null)
            {                
                return;
            }
            tela.Escrever(serie.ToString());
        }

        private Serie ConsultaId(int id)
        {
            Serie serie = this.sc.GetId(id);
            if (serie == null)
            {
                tela.Escrever($"ID {id} não localizado.");
                return null;
            }
            return serie;
        }

        private void Excluir()
        {
            tela.Limpar();
            tela.Separar("Excluir Serie");
            tela.Escrever("Por favor informe o ID da serie a ser excluirdo.");
            int excluir = tela.ReadInt();

            Serie serie = ConsultaId(excluir);
            if ( serie == null)
            {                
                return;
            }
            tela.Escrever("Realmente quer excluir a serie abaixo ?");
            tela.Escrever(serie.ToString());
            tela.Escrever("1-Sim");
            tela.Escrever("2-Não");
            int res = tela.ReadInt();

            if(res==2){
                return;
            }
            this.sc.Excluir(excluir);
            
        }

        private void Desativar(){
            tela.Limpar();
            tela.Separar("Desativar Serie");
            tela.Escrever("Por favor informe o ID da serie a ser desativada.");
            int desativar = tela.ReadInt();

            Serie serie = ConsultaId(desativar);
            if ( serie == null)
            {                
                return;
            }
            tela.Escrever("Realmente quer desativar a serie abaixo ?");
            tela.Escrever(serie.ToString());
            tela.Escrever("1-Sim");
            tela.Escrever("2-Não");
            int res = tela.ReadInt();

            if(res==2){
                return;
            }
            this.sc.Desativar(desativar);
        }
        private void Atualizar()
        {
            tela.Limpar();
            tela.Separar("Atualizar dados da serie");
            tela.Escrever("Por favor informe o ID da serie a ser atualizada.");

            int idAtualizar = tela.ReadInt();

            Serie serie = ConsultaId(idAtualizar);
            if ( serie == null)
            {                
                return;
            }
            tela.Escrever("Dados atuais.");
            tela.Escrever(serie.ToString());

            Genero g = InformarGenero();

            tela.Escrever("Digite o Título da Série: ");
            string t = tela.LerLinha();

            tela.Escrever("Digite o Ano de Início da Série: ");
            int ano = tela.ReadInt();

            tela.Escrever("Digite a Descrição da Série: ");
            string d = tela.LerLinha();

            Serie s = new Serie(idAtualizar,g,t,d,ano);
            this.sc.Atualizar(s.Id,s);

        }

        private Genero InformarGenero(){
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                tela.Escrever($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            tela.Escrever("Digite o gênero entre as opções acima: ");
            return  (Genero)tela.ReadInt();
        }
    }
}