using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TuitionApp.Authentication.Models;

namespace TuitionApp.Authentication.Interfaces
{
    public interface IFireBaseAuthenticator
    {
        Task<AppUser> LoginWithGoogle(string idTok, string accesTok);

    }
}
