using BuroTek.Core.DataAccess;
using BuroTek.Core.Utilities.Results;
using BuroTek.DataAccess;
using BuroTek.Entities.Models;
using BuroTek.WorkPlace.Abstract;
using IResult = BuroTek.Core.Utilities.Results.IResult;

namespace BuroTek.WorkPlace
{
    public class UserManager : IUserService
    {
        //IUserDal _userDal;

        //public IResult Add(User user)
        //{
        //    _userDal.Add(user);
        //    return new SuccessResult("Kullanıcı ekleme başarılı");
        //}

        //public IDataResult<List<User>> GetAll()
        //{
        //    return new SuccessDataResult<List<User>>(_userDal.GetAll(),"Kullanıcılar eklendi");
        //}

        //public IDataResult<User> GetById(string TcNo)
        //{
        //    return new SuccessDataResult<User>(_userDal.Get(u => u.TcNo == TcNo));
        //}

        //public IResult Update(User user)
        //{
        //    _userDal.Update(user);
        //    return new SuccessResult("Kullanıcı başarıyla güncellendi");
        //}
    }
}
