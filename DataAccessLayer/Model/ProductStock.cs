using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class ProductStock
{
    public int ProductStockId { get; set; }

    public string ProductCode { get; set; } = null!;

    public decimal Stock { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
