using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManeger : IUserService
    {
        IUserDal _userDal;

        public UserManeger(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
           return _userDal.GetClaims(user);
        }

        void IUserService.Add(User user) => _userDal.Add(user);

       void IUserService.GetByMail(string email) => _userDal.Get(filter: u => u.Email == email);


    }
}
