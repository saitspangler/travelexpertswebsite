﻿using System;
using System.Collections.Generic;

namespace TravelExperts.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProdName { get; set; } = null!;

    public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; } = new List<ProductsSupplier>();
}
