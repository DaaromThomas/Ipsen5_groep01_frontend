using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class LoginService
    {
        private bool loggedIn = false;
        private bool isAdmin = false;

        public bool getLoggedIn(){
            return loggedIn;
        }

        public bool getIsAdmin(){
            return isAdmin;
        }

        public void setLoggedIn(bool value){
            this.loggedIn = value;
        }

        public void setIsAdmin(bool value){
            this.isAdmin = value;
        }

        public void ResetState()
        {
            loggedIn = false;
            isAdmin = false;
        }

    }
}