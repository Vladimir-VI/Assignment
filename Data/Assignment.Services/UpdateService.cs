using Assignment.Data;
using Assignment.Models;
using System.Linq;

namespace Assignment.Services
{
    public class UpdateService : IUpdateService
    {
        private IAssignmentContext _context;

        public UpdateService(IAssignmentContext context)
        {
            _context = context;
        }

        public void Update<T>(T e) where T : class, IHasID
        {
            var item = _context.Set<T>().FirstOrDefault(i => i.Id == e.Id);
            if (item != null)
            {
                _context.Entry(item).CurrentValues.SetValues(e);
                _context.SaveChanges();
            }
        }
    }
}
