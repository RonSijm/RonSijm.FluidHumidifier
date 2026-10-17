// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderNetworkInterfaceCountRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.NetworkInterfaceCountRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.NetworkInterfaceCountRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.NetworkInterfaceCountRequest Create()
    {
        var networkInterfaceCountRequestResult = CreateNetworkInterfaceCountRequest();
        factoryAction?.Invoke(networkInterfaceCountRequestResult);

        return networkInterfaceCountRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.NetworkInterfaceCountRequest CreateNetworkInterfaceCountRequest()
    {
        var networkInterfaceCountRequestResult = new Humidifier.ECS.CapacityProviderTypes.NetworkInterfaceCountRequest();

        return networkInterfaceCountRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderNetworkInterfaceCountRequestFactoryExtensions
{
}
