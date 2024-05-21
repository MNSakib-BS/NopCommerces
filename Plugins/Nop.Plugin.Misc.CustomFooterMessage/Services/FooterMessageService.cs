using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Configuration;

namespace Nop.Plugin.Misc.CustomFooterMessage.Sevices;
public class FooterMessageService : IFooterMessageService
{
    private readonly ISettingService _settingService;
    public FooterMessageService(ISettingService settingService)
    {
        _settingService = settingService;
    }
    public string GetFooterMessage()
    {
        return _settingService.GetSettingByKey<string>("FooterMessage");
    }
    public void SaveFooterMessage(string message)
    {
        _settingService.SetSetting("FooterMessage", message);
    }
}
