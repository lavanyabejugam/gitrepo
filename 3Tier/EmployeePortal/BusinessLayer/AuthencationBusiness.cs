using RepositoryLayer;
using DomainLayer.Models;

namespace BusinessLayer
{
    public class AuthencationBusiness
    {
        AuthencationRepo _authRepo;

        public AuthencationBusiness()
        {
            _authRepo = new AuthencationRepo();
        }

        public bool ValidateLogin(LoginModel loginModel)
        {
            return _authRepo.ValidateLogin(loginModel);
        }

        /*public bool Register(RegistrationModel registrationModel)
        {
            return _authRepo.Register(registrationModel);
        }*/
    }
}