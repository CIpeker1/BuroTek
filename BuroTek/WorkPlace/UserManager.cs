using BuroTek.Core.DataAccess;
using BuroTek.DataAccess;
using BuroTek.Model;
using BuroTek.WorkPlace.Abstract;

namespace BuroTek.WorkPlace
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(string TcNo)
        {
            return _userDal.Get(p => p.TcNo == TcNo);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
