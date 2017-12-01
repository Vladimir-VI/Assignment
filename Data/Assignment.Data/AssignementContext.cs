using Assignment.Models;
using System.Data.Entity;
namespace Assignment.Data
{
    public class AssignmentContext : DbContext, IAssignmentContext
    { 
        public IDbSet<Event> Events { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
