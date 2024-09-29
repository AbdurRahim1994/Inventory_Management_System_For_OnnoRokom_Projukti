using DataAccessLayer.Model.Context;
using DataAccessLayer.Repository;
using DataAccessLayer.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Service
{
    public class UserRepository : IUserRepository
    {
		private readonly OnnoRokomInventoryContext _context;
        public UserRepository(OnnoRokomInventoryContext _context)
        {
            this._context = _context;
        }
        public void UserRegistration(UserRegistrationVM registration)
        {
            try
            {
                Model.User user = new Model.User()
                {
                    UserName = registration.UserName,
                    Email = registration.Email,
                    MobileNo = registration.MobileNo,
                    Address = registration.Address,
                    Password = registration.Password,
                    ConfirmPassword = registration.ConfirmPassword,
                    Salt = "registration.Salt",
                    CreatedDate = DateTime.Now
                };
                _context.Users.AddAsync(user);
                _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
