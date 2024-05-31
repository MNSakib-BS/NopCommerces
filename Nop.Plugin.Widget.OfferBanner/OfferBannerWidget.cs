using Nop.Core;
using Nop.Plugin.Widget.OfferBanner.Components;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widget.OfferBanner
{
    public class OfferBannerWidget : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;

        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(OfferBannerViewComponent);
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
