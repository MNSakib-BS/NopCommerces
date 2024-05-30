using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Nop.Core;

namespace Nop.Plugin.Misc.NopstationTeamTest.Domain
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        /*public IFormFile Profile { get; set; }
        public byte[] ProfilePicture { get; set; }*/ // Add this line
        public bool IsMVP { get; set; }
        public bool IsNopCommerceCertified { get; set; }
    }

}
