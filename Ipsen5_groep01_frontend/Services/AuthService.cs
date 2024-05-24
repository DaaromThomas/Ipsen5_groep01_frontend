using Microsoft.AspNetCore.Components.Authorization;

namespace Ipsen5_groep01_frontend.Services
{
    public class AuthService
    {
        private bool _isLoggedIn = false;
        private string _role = string.Empty;

        public bool IsLoggedIn => _isLoggedIn;
        public string Role => _role;




        public void LogIn(string role)
        {
            _isLoggedIn = true;
            _role = role;

           
        }

        public void LogOut()
        {
            _isLoggedIn = false;
            _role = string.Empty;
        }

    }
}
