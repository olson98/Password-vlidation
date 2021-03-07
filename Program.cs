using System;

namespace Passwordvalidation
{
    class Validation
    {
        private string setpass, confirm, loginpass;
        private char Loginoption;

        public void Create()
        {
            Console.Write("Enter your new password: ");
            setpass = Console.ReadLine();
        }

        public void Confirm()
        {
            Console.Write("Re-enter your password to confirm: ");
            confirm = Console.ReadLine();
        }

        public void validateconfirmation()
        {
            if (confirm == setpass)
            {
                display1();
            }
            else
            {
                Console.Write("The password entered is not matching with the top password.");
            }
        }

        public void display1()
        {
            Console.Write("\n\nCongratulations!!, you have successfully set your password!!");
        }

        public void Ask()
        {
            Console.Write("\n\nDo you want to Login?(Y/N): ");
            Loginoption = Convert.ToChar(Console.ReadLine());
        }

        public void askcheck()
        {
            if (Loginoption == 'Y' || Loginoption == 'y')
            {
                login();
            }else if(Loginoption=='N'|| Loginoption == 'n')
            {
                Console.Write("Thank you for wasting my time :)");
            }
            else
            {
                Console.Write("Nah Nah we don't do this shit here!");
            }
        }

        public void notcontinue()
        {
            if(confirm != setpass)
            {
                Console.ReadLine();
            }
        }
        public void login()
        {
            Console.Write("Enter your password to login: ");
            loginpass = Console.ReadLine();
            if (loginpass == setpass)
            {
                Console.Write("You have successfully logged in!!");
            }
            else
            {
                Console.Write("Wrong password!");
            }
        }

        

        static void Main(string[] args)
        {
            Validation obj = new Validation();
            obj.Create();
            obj.Confirm();
            obj.validateconfirmation();
            obj.notcontinue();
            obj.Ask();
            obj.askcheck();
            Console.ReadLine();
        }
    }
}
