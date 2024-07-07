using System;
using System.Collections.Generic;

namespace DbFirstApprochProject.Data.Models;

public partial class HeaderMenu
{
    public int MenuId { get; set; }

    public string? MenuName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }
}
