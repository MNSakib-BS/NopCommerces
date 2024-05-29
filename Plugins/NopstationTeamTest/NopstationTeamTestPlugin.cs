using Microsoft.Extensions.DependencyInjection;
using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Services.Common;
using Nop.Services.Plugins;
using System;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.NopstationTeamTest
{
    public class NopstationTeamTestPlugin : BasePlugin, IMiscPlugin
    {
        private readonly IWebHelper _webHelper;
        /*private readonly IServiceProvider _serviceProvider;*/

        public NopstationTeamTestPlugin(IWebHelper webHelper)
        {
            _webHelper = webHelper;
           // _serviceProvider = serviceProvider;
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
            return _webHelper.GetStoreLocation() + "Admin/NopstationTeamTest/Configure";
        }
    }
}
