using DomainLayer.Enums;
using DomainLayer.Models;
using System.Collections.Generic;
using RepositoryLayer;

namespace BusinessLayer
{
    public class UserBusiness
    {
        UserRepo _userRepo;

        public UserBusiness()
        {
            _userRepo = new UserRepo();
        }
        public void SetUserDetails(RegistrationModel robj)
        {
            _userRepo.SetUserDetails(robj);
        }
     
        public List<UserModel> GetUserDetails(int role)
        {
            return _userRepo.GetUserDetails(role);
        }
    }
}
