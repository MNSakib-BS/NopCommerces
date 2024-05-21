namespace Nop.Plugin.Misc.CustomFooterMessage.Sevices;

public interface IFooterMessageService
{
    string GetFooterMessage();
    void SaveFooterMessage(string message);
}