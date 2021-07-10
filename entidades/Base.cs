namespace Cadastro.Series
{
    public abstract class Base
    {
        /// <summary>
        /// id unico, será incremental.
        /// </summary>
        private static int idInc = 0;
        /// <summary>
        /// Retorna Id unico.
        /// </summary>
        /// <value></value>       
        public int Id { get => id; set => id = value; }
        private int id ;
        /// <summary>
        /// Gera um ID incremental e unico.
        /// </summary>
        /// <returns>Número do ID unico.</returns>
        public int GeraId()
        {
            return idInc++;
        }

    }
}