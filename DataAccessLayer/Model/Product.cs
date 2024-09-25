using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public string? Uom { get; set; }

    public string UserEmail { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
