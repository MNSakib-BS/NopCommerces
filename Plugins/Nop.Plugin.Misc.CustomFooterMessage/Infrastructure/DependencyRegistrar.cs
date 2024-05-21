using Nop.Core.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Configuration;

using Nop.Plugin.Misc.CustomFooterMessage.Sevices;

namespace Nop.Plugin.Misc.CustomFooterMessage.Infrastructure;
public class DependencyRegistrar : IDependencyRegistrar
{
    public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
    {
        services.AddScoped<IFooterMessageService, FooterMessageService>();
    }
    public int Order => 1;
}
