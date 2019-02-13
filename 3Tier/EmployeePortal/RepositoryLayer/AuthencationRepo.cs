using DomainLayer.Models;
using System.Linq;

namespace RepositoryLayer
{
    public class AuthencationRepo
    {
        public bool ValidateLogin(LoginModel loginModel)
        {
            return DataSource._userList.Any(m => m.Email == loginModel.Email &&
             m.Password == loginModel.Password);
        }

       public bool Register(string email)
        {
            if (!DataSource._userList.Any(m => m.Email == email))
            {
                
                return true;
            }

            return false;
        }
    }
}
