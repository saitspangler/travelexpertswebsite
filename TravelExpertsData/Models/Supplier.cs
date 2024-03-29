﻿using System;
using System.Collections.Generic;

namespace TravelExperts.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupName { get; set; }

    public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; } = new List<ProductsSupplier>();

    public virtual ICollection<SupplierContact> SupplierContacts { get; set; } = new List<SupplierContact>();
}
