using DataAccessLayer.Repository;
using DataAccessLayer.ViewModel;
using ServiceLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
        }
        public void UserRegistration(UserRegistrationVM registration)
        {
            _userRepository.UserRegistration(registration);
        }
    }
}
