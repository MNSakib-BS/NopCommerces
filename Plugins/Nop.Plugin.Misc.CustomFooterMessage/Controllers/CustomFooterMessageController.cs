using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.CustomFooterMessage.Models;
using Nop.Plugin.Misc.CustomFooterMessage.Sevices;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Misc.CustomFooterMessage.Controllers;
public class CustomFooterMessageController : BasePluginController
{
    private readonly IFooterMessageService _footerMessageService;

    public CustomFooterMessageController(IFooterMessageService footerMessageService)
    {
        _footerMessageService = footerMessageService;
    }

    public IActionResult Configure()
    {
        var model = new FooterMessageModel
        {
            Message = _footerMessageService.GetFooterMessage()
        };
        return View("~/Plugins/CustomFooterMessage/Views/Configure.cshtml", model);
    }

    [HttpPost]
    public IActionResult Configure(FooterMessageModel model)
    {
        if (!ModelState.IsValid)
            return Configure();

        _footerMessageService.SaveFooterMessage(model.Message);
        SuccessNotification("Settings saved successfully.");
        return Configure();
    }

    public IActionResult Display()
    {
        var message = _footerMessageService.GetFooterMessage();
        return View("~/Plugins/CustomFooterMessage/Views/Display.cshtml", message);
    }

    // Add the SuccessNotification method if it doesn't exist in BasePluginController
    protected void SuccessNotification(string message)
    {
        TempData["SuccessNotification"] = message;
    }
}