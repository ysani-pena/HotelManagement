﻿using System;
using System.Collections.Generic;

namespace HotelManagement6.Models
{
    public partial class Aspnetroleclaim
    {
        public int Id { get; set; }
        public string RoleId { get; set; } = null!;
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }

        public virtual Aspnetrole Role { get; set; } = null!;
    }
}
