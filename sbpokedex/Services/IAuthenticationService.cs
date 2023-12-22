using System.IdentityModel.Tokens.Jwt;
using sbpokedex.DTOs;

namespace sbpokedex.Services
{
	public interface IAuthenticationService
	{
        Task<string> Register(RegisterReques request);
        Task<string> Login(LoginRequest request);
    }
}

