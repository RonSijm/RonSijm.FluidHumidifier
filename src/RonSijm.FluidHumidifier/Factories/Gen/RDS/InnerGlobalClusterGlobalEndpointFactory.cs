// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerGlobalClusterGlobalEndpointFactory(Action<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint>
{

    protected override Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint Create()
    {
        var globalEndpointResult = CreateGlobalEndpoint();
        factoryAction?.Invoke(globalEndpointResult);

        return globalEndpointResult;
    }

    private Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint CreateGlobalEndpoint()
    {
        var globalEndpointResult = new Humidifier.RDS.GlobalClusterTypes.GlobalEndpoint();

        return globalEndpointResult;
    }

} // End Of Class

public static class InnerGlobalClusterGlobalEndpointFactoryExtensions
{
}
