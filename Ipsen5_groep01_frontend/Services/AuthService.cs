using Ipsen5_groep01_frontend.Abstract_Classes;
using Microsoft.JSInterop;

namespace Ipsen5_groep01_frontend.Services
{
    public class AuthService : Observable
    {
        private bool _isLoggedIn = false;
        private string _role = string.Empty;
        private string _jwtToken = "";
        public bool IsLoggedIn => _isLoggedIn;
        public string Role => _role;

        public void LogIn(string role)
        {
            _isLoggedIn = true;
            _role = role;
            this.notifyObservers();
        }

        public void LogOut()
        {
            _isLoggedIn = false;
            _role = string.Empty;
            this.notifyObservers();
        }

        public void CheckJwtToken()
        {
            try
            {
                // this._jwtToken = ProtectedSessionStorage.GetAsync<string>("UserName").Result.Value ?? "";
                Console.WriteLine(_jwtToken);
            }
            catch (JSException ex)
            {
                Console.WriteLine($"Error retrieving JWT token from session storage: {ex.Message}");
            }
        }

    }
}
