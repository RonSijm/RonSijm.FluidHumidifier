// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterNetworkingFactory(Action<Humidifier.PCS.ClusterTypes.Networking> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.Networking>
{

    protected override Humidifier.PCS.ClusterTypes.Networking Create()
    {
        var networkingResult = CreateNetworking();
        factoryAction?.Invoke(networkingResult);

        return networkingResult;
    }

    private Humidifier.PCS.ClusterTypes.Networking CreateNetworking()
    {
        var networkingResult = new Humidifier.PCS.ClusterTypes.Networking();

        return networkingResult;
    }

} // End Of Class

public static class InnerClusterNetworkingFactoryExtensions
{
}
