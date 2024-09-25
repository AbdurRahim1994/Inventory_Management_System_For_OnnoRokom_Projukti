using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model;

public partial class PurchaseMain
{
    public int PurchaseMainId { get; set; }

    public string Prno { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public int SupplierId { get; set; }

    public decimal Amount { get; set; }

    public decimal Vat { get; set; }

    public decimal Discount { get; set; }

    public decimal DiscountedAmount { get; set; }

    public decimal OtherCost { get; set; }

    public decimal ShippingCost { get; set; }

    public decimal NetAmount { get; set; }

    public string? Note { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
