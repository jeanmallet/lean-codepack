namespace Leanwork.CodePack
{
    /// <summary>
    /// Interface para gerenciador de cache
    /// </summary>
    public interface ICacheManager
    {
        /// <summary>
        /// Obt�m um item do cache
        /// </summary>
        /// <typeparam name="T">Item</typeparam>
        /// <param name="key">Chave</param>
        /// <returns>Item em cache</returns>
        T Get<T>(string key);

        /// <summary>
        /// Seta um objeto em cache
        /// </summary>
        /// <param name="key">Chave</param>
        /// <param name="data">Dados</param>
        /// <param name="cacheTime">Dura��o</param>
        void Set(string key, object data, int cacheTime);

        /// <summary>
        /// Verifica se j� existe um cache setado para uma determinada chave
        /// </summary>
        /// <param name="key">Chave</param>
        /// <returns>Est� em cache ou n�o</returns>
        bool IsSet(string key);

        /// <summary>
        /// Remove um item do cache para determinada chave
        /// </summary>
        /// <param name="key">Chave</param>
        void Remove(string key);

        /// <summary>
        /// Remove itens do cache seguindo um determinado padr�o de chave
        /// </summary>
        /// <param name="pattern"></param>
        void RemoveByPattern(string pattern);

        /// <summary>
        /// Esvazia o cache
        /// </summary>
        void Clear();
    }
}
