using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Configuration;


namespace Nop.Plugin.Widget.OfferBanner.Services
{
    public class OfferBannerServices
    {
        private ISettingService _settingService;
        private OfferBannerSettings _offerBannerSettings;
        public OfferBannerServices(ISettingService settingService)
        {
            _settingService = settingService;
            _offerBannerSettings = new OfferBannerSettings();  
            
        }
        public async Task<string> GetMessageAsync()
        {
            if (_offerBannerSettings.Message is null)
            {
                var key = _settingService.GetSettingKey(_offerBannerSettings, obs => obs.Message);
                _offerBannerSettings.Message = await _settingService.GetSettingByKeyAsync<string>(key);
            }

            return _offerBannerSettings.Message;
        }

        public async Task SetMessageAsync(string message)
        {
            var key = _settingService.GetSettingKey(_offerBannerSettings, obs => obs.Message);
            await _settingService.SetSettingAsync(key, message);
        }
    }
}
