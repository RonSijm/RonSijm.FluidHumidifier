// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AIOps;

public class InnerInvestigationGroupChatbotNotificationChannelFactory(Action<Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel> factoryAction = null) : SubResourceFactory<Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel>
{

    protected override Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel Create()
    {
        var chatbotNotificationChannelResult = CreateChatbotNotificationChannel();
        factoryAction?.Invoke(chatbotNotificationChannelResult);

        return chatbotNotificationChannelResult;
    }

    private Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel CreateChatbotNotificationChannel()
    {
        var chatbotNotificationChannelResult = new Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel();

        return chatbotNotificationChannelResult;
    }

} // End Of Class

public static class InnerInvestigationGroupChatbotNotificationChannelFactoryExtensions
{
}
