using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widget.OfferBanner.Models;
using Nop.Plugin.Widget.OfferBanner.Services;
using Nop.Services.Configuration;
using Nop.Services.Security;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Widget.OfferBanner.Controllers;
public class OfferBannerController : BasePluginController
{
    OfferBannerServices _offerBannerService;
    private IPermissionService _permissionService;
    private IStoreContext _storeContext;
    private ISettingService _settingService;

    public OfferBannerController(OfferBannerServices offerBannerService,
        IPermissionService permissionService,
        IStoreContext storeContext,
        ISettingService settingService)
    {
        _offerBannerService = offerBannerService;
        _permissionService = permissionService;
        _storeContext = storeContext;
        _settingService = settingService;
    }

    [AuthorizeAdmin]
    [Area("Admin")]
    public async Task<IActionResult> Configure()
    {
        if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
            return AccessDeniedView();

        var storeScope = await _storeContext.GetActiveStoreScopeConfigurationAsync();
        var offerBannerSettings = await _settingService.LoadSettingAsync<OfferBannerSettings>(storeScope);
        var model = new ConfigurationModel()
        {
            Message = offerBannerSettings.Message
        };

        return View(model);
    }

    [AuthorizeAdmin]
    [Area("Admin")]
    [HttpPost]
    public async Task<IActionResult> Configure(ConfigurationModel offerBannerSettingsModel)
    {
        if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
            return AccessDeniedView();

        var storeScope = await _storeContext.GetActiveStoreScopeConfigurationAsync();
        var offerBannerSettings = await _settingService.LoadSettingAsync<OfferBannerSettings>(storeScope);

        if (ModelState.IsValid)
        {
            offerBannerSettings.Message = offerBannerSettingsModel.Message;
            await _settingService.SaveSettingAsync(offerBannerSettings);
            return await Configure();
        }

        return BadRequest();
    }
}
