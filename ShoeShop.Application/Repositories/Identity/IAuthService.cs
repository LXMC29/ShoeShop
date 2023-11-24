using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Application.Models.Identity;

namespace ShoeShop.Application.Repositories.Identity
{
    public interface IAuthService
    {
        public Task<string> Login(LoginRequest loginRequest);
        public Task<string> Register(RegisterRequest registerRequest);
    }
}
