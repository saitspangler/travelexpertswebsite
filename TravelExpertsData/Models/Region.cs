﻿using System;
using System.Collections.Generic;

namespace TravelExperts.Models;

public partial class Region
{
    public string RegionId { get; set; } = null!;

    public string? RegionName { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
}
