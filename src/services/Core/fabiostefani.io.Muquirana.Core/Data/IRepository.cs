using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using fabiostefani.io.Muquirana.Core.DomainObjects;

namespace fabiostefani.io.Muquirana.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);        

        void Adicionar(T objeto);
        void Atualizar(T objeto);


    }
}