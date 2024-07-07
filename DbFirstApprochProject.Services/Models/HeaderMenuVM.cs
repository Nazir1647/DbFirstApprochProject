using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApprochProject.Services.Models
{
    public class HeaderMenuVM
    {
        public int MenuId { get; set; }

        public string? MenuName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public string? CreatedByName { get; set; }
    }
}
