// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderNetworkBandwidthGbpsRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.NetworkBandwidthGbpsRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.NetworkBandwidthGbpsRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.NetworkBandwidthGbpsRequest Create()
    {
        var networkBandwidthGbpsRequestResult = CreateNetworkBandwidthGbpsRequest();
        factoryAction?.Invoke(networkBandwidthGbpsRequestResult);

        return networkBandwidthGbpsRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.NetworkBandwidthGbpsRequest CreateNetworkBandwidthGbpsRequest()
    {
        var networkBandwidthGbpsRequestResult = new Humidifier.ECS.CapacityProviderTypes.NetworkBandwidthGbpsRequest();

        return networkBandwidthGbpsRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderNetworkBandwidthGbpsRequestFactoryExtensions
{
}
