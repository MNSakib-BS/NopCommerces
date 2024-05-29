using Nop.Core;
using Nop.Services.Common;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.NopstationTeam;

public class NopstationTeamPlugin : BasePlugin,IMiscPlugin
{
    private readonly IWebHelper _webHelper;
    public NopstationTeamPlugin(IWebHelper webHelper)
    {
        _webHelper = webHelper;
        
    }
    public override Task InstallAsync()
    {
        return base.InstallAsync();
    }
    public override Task UninstallAsync() 
    { 
        return base.UninstallAsync();
    }
    public override string GetConfigurationPageUrl()
    {
        return _webHelper.GetStoreLocation() + "Admin/NopstationTeam/Configure";
    }

}
