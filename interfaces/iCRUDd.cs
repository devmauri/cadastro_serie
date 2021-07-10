using System.Collections.Generic;

namespace Cadastro.Series
{
    public interface iCRUDd<T>
    {
        List<T> Listar();
        T GetId(int id);
        /// <summary>
        /// Insere novo registro
        /// </summary>
        /// <param name="entidade">Registro a ser inserido</param>
        /// <returns>Retorna ID inserido ou -1 caso falha.</returns>        
        int Inserir(T entidade);        
        void Excluir(int id);        
        bool Atualizar(int id, T entidade);
        void Desabilitar(int id);
    }
}