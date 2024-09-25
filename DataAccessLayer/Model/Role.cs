using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
