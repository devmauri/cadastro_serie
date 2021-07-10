using System.Collections.Generic;

namespace Cadastro.Series
{
    public class SerieContainer
    {
        private List<Serie> series;
        public List<Serie> Series {get => this.series ; set => series = value;}
        private SerieService sc;
        public SerieContainer(){
            this.series = new List<Serie>();
            SerieContainer sd = this;
            sc = new SerieService(ref sd);
        } 
        
        public int Inserir(Serie nova){
            return sc.Inserir(nova);
        }

        public List<Serie> Listar(){
            return sc.Listar();
        }

        public Serie GetId(int id){
            return this.sc.GetId(id);
        }

        public void Excluir (int id){
            this.sc.Excluir(id);
        }

        public void Desativar(int id){
            this.sc.Desabilitar(id);
        }

        public bool  Atualizar(int id, Serie serie){
            return this.sc.Atualizar(id,serie);
        }
        
    }
}