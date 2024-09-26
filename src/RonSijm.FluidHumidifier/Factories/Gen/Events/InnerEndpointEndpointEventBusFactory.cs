// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEndpointEndpointEventBusFactory(Action<Humidifier.Events.EndpointTypes.EndpointEventBus> factoryAction = null) : SubResourceFactory<Humidifier.Events.EndpointTypes.EndpointEventBus>
{

    protected override Humidifier.Events.EndpointTypes.EndpointEventBus Create()
    {
        var endpointEventBusResult = CreateEndpointEventBus();
        factoryAction?.Invoke(endpointEventBusResult);

        return endpointEventBusResult;
    }

    private Humidifier.Events.EndpointTypes.EndpointEventBus CreateEndpointEventBus()
    {
        var endpointEventBusResult = new Humidifier.Events.EndpointTypes.EndpointEventBus();

        return endpointEventBusResult;
    }

} // End Of Class

public static class InnerEndpointEndpointEventBusFactoryExtensions
{
}
