// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerResponderGatewayListenerConfigFactory(Action<Humidifier.RTBFabric.ResponderGatewayTypes.ListenerConfig> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.ResponderGatewayTypes.ListenerConfig>
{

    protected override Humidifier.RTBFabric.ResponderGatewayTypes.ListenerConfig Create()
    {
        var listenerConfigResult = CreateListenerConfig();
        factoryAction?.Invoke(listenerConfigResult);

        return listenerConfigResult;
    }

    private Humidifier.RTBFabric.ResponderGatewayTypes.ListenerConfig CreateListenerConfig()
    {
        var listenerConfigResult = new Humidifier.RTBFabric.ResponderGatewayTypes.ListenerConfig();

        return listenerConfigResult;
    }

} // End Of Class

public static class InnerResponderGatewayListenerConfigFactoryExtensions
{
}
