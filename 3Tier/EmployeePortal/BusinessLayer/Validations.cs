using RepositoryLayer;
namespace BusinessLayer
{
    public static class Validations
    {
        public static bool ValidateEmail(string email)
        {
            AuthencationRepo _aobj = new AuthencationRepo();
            bool Flag = false;
            if (email.Contains("@") && email.Contains(".com") && _aobj.Register(email)) 
            {
                Flag = true;
            }
            return Flag;
        }

        public static bool ValidatePassword(string password)
        {
            int validConditions = 0;
            if (password.Length < 9)
            {
                return false;
            }
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateFirstName(string firstName)
        {
            if (firstName.Length > 0)
            {
                return true;
            }
            return false;
        }
        public static bool ValidateLastName(string lastName)
        {
            if (lastName.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}


