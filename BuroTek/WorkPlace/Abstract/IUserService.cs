using BuroTek.Model;

namespace BuroTek.WorkPlace.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(string TcNo);
        void Add(User user);
        void Update(User user);
    }
}
