using System;

namespace AccountsManagerLib
{
    public class AccountsManager
    {
        public string Login(string userId, string password)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("User Id or Password cannot be empty");
            }

            if (userId == "user_11" && password == "secret@user11")
            {
                return "Welcome user_11!!!";
            }

            if (userId == "user_22" && password == "secret@user22")
            {
                return "Welcome user_22!!!";
            }

            return "Invalid user id/password";
        }
    }
}