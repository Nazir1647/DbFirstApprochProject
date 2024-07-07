using System;
using System.Collections.Generic;

namespace DbFirstApprochProject.Data.Models;

public partial class SubMenu
{
    public int Id { get; set; }

    public string? SubMenuName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public int? MenuId { get; set; }
}
