using System;
using fabiostefani.io.Muquirana.Core.DomainObjects;

namespace fabiostefani.io.Muquirana.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        
    }
}