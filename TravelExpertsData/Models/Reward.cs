using System;
using System.Collections.Generic;

namespace TravelExperts.Models;

public partial class Reward
{
    public int RewardId { get; set; }

    public string? RwdName { get; set; }

    public string? RwdDesc { get; set; }

    public virtual ICollection<CustomersReward> CustomersRewards { get; set; } = new List<CustomersReward>();
}
