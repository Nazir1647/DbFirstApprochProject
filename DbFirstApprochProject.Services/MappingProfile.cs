using AutoMapper;
using DbFirstApprochProject.Data.Models;
using DbFirstApprochProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApprochProject.Services
{
    /// <summary>
    /// Automapper configuration.
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
		/// Initializes a new instance of the <see cref="MappingProfile"/> class.
		/// </summary>
        public MappingProfile()
        {
            
            CreateMap<HeaderMenuVM, HeaderMenu>();
            CreateMap<HeaderMenu, HeaderMenuVM>();
           
        }
    }
}
