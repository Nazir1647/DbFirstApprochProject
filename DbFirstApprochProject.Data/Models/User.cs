using System;
using System.Collections.Generic;

namespace DbFirstApprochProject.Data.Models;

public partial class User
{
    public int Uid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? Guid { get; set; }

    public DateTime? CreateDate { get; set; }
}
