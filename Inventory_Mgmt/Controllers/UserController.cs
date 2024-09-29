using DataAccessLayer.Model.Context;
using DataAccessLayer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Repository;

namespace Inventory_Mgmt.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly OnnoRokomInventoryContext _context;
        public UserController(IUserService _userService, OnnoRokomInventoryContext _context)
        {
            this._userService = _userService;
            this._context = _context;
        }

        [HttpGet]
        public ActionResult UserRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegistration([FromBody]UserRegistrationVM registration)
        {
            var data = _context.Users.Where(x => x.Email == registration.Email).FirstOrDefault();
            if(data is not null)
            {
                return Json("1");
            }
            else
            {
                _userService.UserRegistration(registration);
                return Json("2");

            }
        }
        
        [HttpPost]
        public IActionResult UserLogin([FromBody] UserLoginVM login)
        {
            var user = _context.Users.Where(x => x.Email == login.Email && x.Password == login.Password).FirstOrDefault();
            if(user is null)
            {
                return Json("1");
            }
            else
            {
                return RedirectToAction(nameof(UserRegistration));
            }
        }
    }
}
