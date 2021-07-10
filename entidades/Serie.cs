using System;


namespace Cadastro.Series
{
    public class Serie : Base
    {
        //Encapsulamento explicito - com parâmetro + metodo anônimo.
        private Genero genero;
        private string titulo,descricao;
        public Genero Genero { get => genero; set => genero = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        //Encapsulamento explicito com parâmetro + metodo.
        private int ano;
        public int Ano { get {return ano;} set {this.ano = value;}}
        private bool ativa;
        public bool Ativa { get{return ativa;}set{this.ativa = value;}}

        /// <summary>
        /// Gera nova série.
        /// </summary>
        /// <param name="genero">Genero da série. Atentar Enumerador.</param>
        /// <param name="titulo">Título da série.</param>
        /// <param name="descricao">Drecição livre</param>
        /// <param name="ano">Ano de lançamento.</param>
        public Serie(Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = GeraId();
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Ativa = true;
        }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Ativa = true;
        }

        /// <summary>
        /// Reescrito adequando aos atributos.
        /// </summary>
        /// <returns>Atributos enfileirados separos por 
        /// nova linha e terminando com caracter *</returns>
        public override string ToString()
        {
            string retorno = "";
            retorno += "\tGênero: " + this.Genero.ToString() + Environment.NewLine;
            retorno += "\tTitulo: " + this.Titulo + Environment.NewLine;
            retorno += "\tDescrição: " + this.Descricao + Environment.NewLine;
            retorno += "\tAno de Início: " + this.Ano + Environment.NewLine;
            retorno += "\tAtiva: " + this.Ativa;
            return retorno;
        }

    }
}