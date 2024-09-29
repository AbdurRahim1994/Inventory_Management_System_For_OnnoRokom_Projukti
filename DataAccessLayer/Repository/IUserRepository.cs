using DataAccessLayer.ViewModel;
using Inventory_Mgmt.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IUserRepository
    {
        public void UserRegistration(UserRegistrationVM registration);
    }
}
