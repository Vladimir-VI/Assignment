using Assignment.Models;

namespace Assignment.Services
{
    public interface IUpdateService
    {
        void Update<T>(T e) where T : class, IHasID;
    }
}
