using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.NopstationTeamTest.Domain;
using Nop.Plugin.Misc.NopstationTeamTest.Services;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Misc.NopstationTeamTest.Controllers
{
    [Area("Admin")]
    [Route("Admin/NopstationTeamTest/[action]")]
    public class NopstationTeamTestController : BasePluginController
    {
        private readonly IEmployeeService _employeeService;

        public NopstationTeamTestController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Configure()
        {
            var model = new Employee();
            return View("~/Plugins/Misc.NopstationTeamTest/Views/Configure.cshtml", model);
        }
        [HttpPost]
        public async Task<IActionResult> Configure(Employee model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Plugins/Misc.NopstationTeamTest/Views/Configure.cshtml", model);
            }

            /*   if (model.Profile != null && model.Profile.Length > 0)
               {
                   using (var memoryStream = new MemoryStream())
                   {
                       await model.Profile.CopyToAsync(memoryStream);
                       model.ProfilePicture = memoryStream.ToArray();
                   }
               }*/

            _employeeService.Log(model);
            return RedirectToAction("Configure");
        }

    }
}
