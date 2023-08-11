using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LR1
{
    //[Serializable]
    public class User
    {
        public string Login;
        public string Password;
        public bool IsBlocked;
        public bool IsLimited;
        public bool IsFirstEntry;


        public User(string login, string password, bool isBlocked, bool isLimited, bool isFirstEntry)
        {
            Login = login;
            Password = password;
            IsBlocked = isBlocked;
            IsLimited = isLimited;
            IsFirstEntry = isFirstEntry;
        }

        public User(string login)
        {
            Login = login;
            Password = "";
            IsBlocked = false;
            IsLimited = true;
            IsFirstEntry = true;
        }

        public bool HasAccess(string password)
        {
            return Password == password;
        }
        public static bool IsCorrectPassword(string password)
        {
            bool isUpper = false;
            bool isLower = false;

            foreach (char symb in password) {
                if (Char.IsUpper(symb))
                {
                    isUpper = true;
                }
                else if (Char.IsLower(symb))
                {
                    isLower = true;
                }
                if (isLower && isUpper)
                {
                    return true;
                }
            }
            return false;
        }
        public override bool Equals(Object obj)
        {
            User userObj = obj as User;
            if (userObj == null)
                return false;
            else
                return Login.ToLower().Equals(userObj.Login.ToLower());
        }

        public override int GetHashCode()
        {
            return this.Login.ToLower().GetHashCode();
        }

    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new AuthorizeForm());
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
