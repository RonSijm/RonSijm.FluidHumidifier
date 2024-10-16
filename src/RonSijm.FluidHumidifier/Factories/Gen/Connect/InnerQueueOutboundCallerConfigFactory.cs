// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQueueOutboundCallerConfigFactory(Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QueueTypes.OutboundCallerConfig>
{

    protected override Humidifier.Connect.QueueTypes.OutboundCallerConfig Create()
    {
        var outboundCallerConfigResult = CreateOutboundCallerConfig();
        factoryAction?.Invoke(outboundCallerConfigResult);

        return outboundCallerConfigResult;
    }

    private Humidifier.Connect.QueueTypes.OutboundCallerConfig CreateOutboundCallerConfig()
    {
        var outboundCallerConfigResult = new Humidifier.Connect.QueueTypes.OutboundCallerConfig();

        return outboundCallerConfigResult;
    }

} // End Of Class

public static class InnerQueueOutboundCallerConfigFactoryExtensions
{
}
