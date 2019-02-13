using DomainLayer.Models;
using System;
using BusinessLayer;
using DomainLayer.Enums;

namespace ConApp
{
    class Authentication
    {
        AuthencationBusiness _authBusiness;
        LoginModel _lmobj;
        RegistrationModel _robj;
        UserBusiness _ubobj;
        public Authentication()
        {
            _authBusiness = new AuthencationBusiness();
            _lmobj = new LoginModel();
            _robj = new RegistrationModel();
            _ubobj = new UserBusiness();
        }

        internal void Login()
        {
        Label1: Console.Write("EmailId : ");
            _lmobj.Email = Console.ReadLine();
         Console.Write("Password : ");
            _lmobj.Password = Console.ReadLine();
            if (_authBusiness.ValidateLogin(_lmobj))
            {
                Console.WriteLine("Enter 1 to see students information");
                Console.WriteLine("Enter 2 to see other than student information");
                
                int type = Convert.ToInt32(Console.ReadLine());
                var Info = _ubobj.GetUserDetails(type);
                for(int idx = 0; idx < Info.Count; idx++)
                {
                    Console.WriteLine(Info[idx]);
                }
                
            }
            else
            {
                Console.WriteLine("Password does not match ");
                goto Label1;
            }
            
        }


    

        internal void Register()
        {
        Label1: Console.Write("FirstName: ");
            _robj.FirstName = Console.ReadLine();
            if (Validations.ValidateFirstName(_robj.FirstName))
            {
            Label2: Console.Write("LastName: ");
                _robj.LastName = Console.ReadLine();
                if (Validations.ValidateLastName(_robj.LastName))
                {
                Label3: Console.Write("EmailId: ");
                    _robj.Email = Console.ReadLine();
                    if (Validations.ValidateEmail(_robj.Email))
                    {
                    Label4: Console.WriteLine("Your Password must contain atleast one captial letter, atleastone small letter and atleast one number");
                        Console.Write("Password: ");
                        _robj.Password = "";
                        do
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                            {
                                _robj.Password += key.KeyChar;
                                Console.Write("*");
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine();
                                break;
                            }
                        } while (true);
                        if (Validations.ValidatePassword(_robj.Password))
                        {
                            Console.WriteLine("Type of registration");
                            Console.WriteLine("Enter 1 to regsiter as a student");
                            Console.WriteLine("Enter 2 to register as other");
                            int x = Convert.ToInt32(Console.ReadLine());
                            if(x==1)
                            {
                                _robj.IsStudent = true;
                            }
                            else
                            {
                                _robj.IsStudent= false;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Enter valid Password");
                            goto Label4;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter valid EmailId - your emailId must contain @ and .com or entered emailid already exist");
                        goto Label3;
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid LastName - Length of LastName must be greater than zero");
                    goto Label2;
                }
            }
            else
            {
                Console.WriteLine("Enter valid FirstName - Length of FirstName must be greater than zero");
                goto Label1;
            }

            _ubobj.SetUserDetails(_robj);
        }
    }
}
