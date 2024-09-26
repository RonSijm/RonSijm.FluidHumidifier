// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanChatChannelFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.ChatChannel> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.ChatChannel>
{

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.ChatChannel Create()
    {
        var chatChannelResult = CreateChatChannel();
        factoryAction?.Invoke(chatChannelResult);

        return chatChannelResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.ChatChannel CreateChatChannel()
    {
        var chatChannelResult = new Humidifier.SSMIncidents.ResponsePlanTypes.ChatChannel();

        return chatChannelResult;
    }

} // End Of Class

public static class InnerResponsePlanChatChannelFactoryExtensions
{
}
