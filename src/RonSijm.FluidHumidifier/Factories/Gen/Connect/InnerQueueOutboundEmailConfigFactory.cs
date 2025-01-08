// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQueueOutboundEmailConfigFactory(Action<Humidifier.Connect.QueueTypes.OutboundEmailConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QueueTypes.OutboundEmailConfig>
{

    protected override Humidifier.Connect.QueueTypes.OutboundEmailConfig Create()
    {
        var outboundEmailConfigResult = CreateOutboundEmailConfig();
        factoryAction?.Invoke(outboundEmailConfigResult);

        return outboundEmailConfigResult;
    }

    private Humidifier.Connect.QueueTypes.OutboundEmailConfig CreateOutboundEmailConfig()
    {
        var outboundEmailConfigResult = new Humidifier.Connect.QueueTypes.OutboundEmailConfig();

        return outboundEmailConfigResult;
    }

} // End Of Class

public static class InnerQueueOutboundEmailConfigFactoryExtensions
{
}
