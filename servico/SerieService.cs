using System.Collections.Generic;

namespace Cadastro.Series
{
    public class SerieService : iCRUDd<Serie>
    {
        private List<Serie> rBD;

        /// <summary>
        /// Necessida de uma referencia para a base de dados ou conexão.
        /// </summary>
        /// <param name="BD">Base de dados.</param>
        public SerieService(ref SerieContainer BD)
        {
            this.rBD = BD.Series;
        }
        public bool Atualizar(int id, Serie entidade)
        {
            if (id != entidade.Id && GetId(entidade.Id) != null)
                return false;

            this.Excluir(id);
            this.Inserir(entidade);
            return true;
        }

        public void Desabilitar(int id)
        {
            this.GetId(id).Ativa = false;
        }

        public void Excluir(int id)
        {
            rBD.Remove(this.GetId(id));
        }

        public int Inserir(Serie entidade)
        {
            rBD.Add(entidade);
            return entidade.Id;
        }

        public List<Serie> Listar()
        {
            return rBD;
        }

        public Serie GetId(int id)
        {
            if (!rBD.Exists(item => item.Id == id))
            {
                return null;
            }
            return rBD.Find(item => item.Id == id);
        }
    }
}