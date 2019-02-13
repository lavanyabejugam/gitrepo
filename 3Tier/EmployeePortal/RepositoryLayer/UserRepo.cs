using DomainLayer.Enums;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer
{
    public class UserRepo
    {

        public List<UserModel> GetUserDetails(int role)
        {
            if (role == 1)
            {
                return DataSource._userList.Where(m => m.IsStudent).ToList();
            }
            else
            {
                return DataSource._userList.Where(m => !m.IsStudent).ToList();

            }
        }
        public void SetUserDetails(RegistrationModel robj)
        {
            DataSource._userList.Add(new UserModel(robj.FirstName, robj.LastName, robj.Email, robj.Password, robj.IsStudent));
        }
    }
}
