using Windows.UI.Notifications;

namespace AutoProxy.Services
{
    public static class NotificationService
    {
        public static void SendNotify(string title, string text = "")
        {
            var templateType = ToastTemplateType.ToastText02;
            var content = ToastNotificationManager.GetTemplateContent(templateType);
            var textNodes = content.GetElementsByTagName("text");
            textNodes[0].AppendChild(content.CreateTextNode(title));
            textNodes[1].AppendChild(content.CreateTextNode(text));
            var notifier = ToastNotificationManager.CreateToastNotifier("Microsoft.Windows.Computer");
            notifier.Show(new ToastNotification(content));
        }
    }
}
