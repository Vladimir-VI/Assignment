using Assignment.Data;
using System.Linq;

namespace Assignment.Services
{
    public class LoadService  : ILoadService
    {
        private IAssignmentContext _context;
        public LoadService(IAssignmentContext context)
        {
            _context = context;
        }
        public IQueryable<T> Load<T>() where T : class
        {
            return _context.Set<T>();
        }
    }
}
