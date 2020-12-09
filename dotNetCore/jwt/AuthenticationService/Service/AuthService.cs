using AuthenticationService.Exceptions;
using AuthenticationService.Models;
using AuthenticationService.Repository;

namespace AuthenticationService.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;
        public AuthService(IAuthRepository _authRepository)
        {
            authRepository = _authRepository;
        }
        public bool LoginUser(User user)
        {
            //bool result = authRepository.LoginUser(user);
            //return result;
        
            if(user.UserId != null && user.Password != null)
            {
                bool result = authRepository.LoginUser(user);
                return result;
            }
            else
            {
                throw new UserAlreadyExistsException("Unauthorized");
            }
            //return false;
        }

        public bool RegisterUser(User user)
        {
            //var result = authRepository.CreateUser(user);
            //return result;
            var id = authRepository.IsUserExists(user.UserId);
            if (!id)
            {
                var result = authRepository.CreateUser(user);
                return result;
            }
            else
            {
                throw new UserAlreadyExistsException($"This userId {user.UserId} already in use");
            }
        }
    }
}
