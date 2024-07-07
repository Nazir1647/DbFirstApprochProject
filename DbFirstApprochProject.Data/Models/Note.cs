using System;
using System.Collections.Generic;

namespace DbFirstApprochProject.Data.Models;

public partial class Note
{
    public int Id { get; set; }

    public string? MenuId { get; set; }

    public string? SubMenuId { get; set; }

    public string? HeaderData { get; set; }

    public string? ParagaraphData { get; set; }

    public string? Code { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public string? CodeLanguage { get; set; }
}
