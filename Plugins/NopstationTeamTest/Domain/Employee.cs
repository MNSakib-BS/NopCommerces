using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Nop.Core;

namespace Nop.Plugin.Misc.NopstationTeamTest.Domain
{
    public class Employee: BaseEntity
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
       // public IFormFile Profile { get; set; }
        public bool IsMVP { get; set; }
        public bool IsNopCommerceCertified { get; set; }
    }
}
