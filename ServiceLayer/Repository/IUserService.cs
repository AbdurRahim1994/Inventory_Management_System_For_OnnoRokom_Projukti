using DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Repository
{
    public interface IUserService
    {
        public void UserRegistration(UserRegistrationVM registration);
    }
}
