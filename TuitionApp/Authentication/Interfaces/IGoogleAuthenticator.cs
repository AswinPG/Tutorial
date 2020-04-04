using System;
using System.Collections.Generic;
using System.Text;
using TuitionApp.Authentication.Models;

namespace TuitionApp.Authentication.Interfaces
{
    public interface IGoogleAuthenticator
    {
        void Login(Action<GoogleUser, string> OnLoginComplete);
        void Logout();
    }
}
