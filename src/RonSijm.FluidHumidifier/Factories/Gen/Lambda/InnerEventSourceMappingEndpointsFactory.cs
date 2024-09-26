// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingEndpointsFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.Endpoints>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.Endpoints Create()
    {
        var endpointsResult = CreateEndpoints();
        factoryAction?.Invoke(endpointsResult);

        return endpointsResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.Endpoints CreateEndpoints()
    {
        var endpointsResult = new Humidifier.Lambda.EventSourceMappingTypes.Endpoints();

        return endpointsResult;
    }

} // End Of Class

public static class InnerEventSourceMappingEndpointsFactoryExtensions
{
}
