using System.Linq;

namespace Assignment.Services
{
    public interface ILoadService
    {
        IQueryable<T> Load<T>() where T : class;
    }
}
