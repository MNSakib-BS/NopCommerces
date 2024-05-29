using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Nop.Plugin.Misc.NopstationTeam.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public IFormFile Profile { get; set; }
        public bool IsMVP { get; set; }
        public bool IsNopCommerceCertified { get; set; }
    }
}
