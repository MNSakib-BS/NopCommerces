using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Controllers;
using Nop.Plugin.Misc.NopstationTeam.Models;

namespace Nop.Plugin.Misc.NopstationTeam.Controllers
{
    [Area("Admin")]
    [Route("Admin/NopstationTeam/[action]")]
    public class NopstationTeamController : BasePluginController
    {
        [HttpGet]
        public IActionResult Configure()
        {
            var model = new Employee();
            return View("~/Plugins/Misc.NopstationTeam/Views/Configure.cshtml", model);
        }

        [HttpPost]
        public IActionResult Configure(Employee model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Plugins/Misc.NopstationTeam/Views/Configure.cshtml", model);
            }

            //db tee jabee
            return RedirectToAction("Configure");
        }
    }
}
