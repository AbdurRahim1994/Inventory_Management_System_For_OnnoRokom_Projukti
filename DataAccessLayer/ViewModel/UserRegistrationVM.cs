using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModel
{
    public class UserRegistrationVM
    {
        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string MobileNo { get; set; } = null!;

        public string? Address { get; set; }

        public string Password { get; set; } = null!;

        public string ConfirmPassword { get; set; } = null!;

        public string Salt { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
