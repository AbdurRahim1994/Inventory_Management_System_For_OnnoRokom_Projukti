using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class SalesDetail
{
    public int SalesDetailId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public string? Uom { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
