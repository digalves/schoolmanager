using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface IRepository<T>
    {
        Task Adicionar(T entity);
    }
}
