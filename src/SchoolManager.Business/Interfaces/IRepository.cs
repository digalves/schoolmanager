using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface IRepository<T>
    {
        Task Adicionar(T entity);
        Task<List<T>> ObterTodas();
        Task<T> ObterPorId(Guid id);
        Task<int> Salvar();
    }
}
