// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerCapabilityNetworkAccessFactory(Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> factoryAction = null) : SubResourceFactory<Humidifier.EKS.CapabilityTypes.NetworkAccess>
{

    protected override Humidifier.EKS.CapabilityTypes.NetworkAccess Create()
    {
        var networkAccessResult = CreateNetworkAccess();
        factoryAction?.Invoke(networkAccessResult);

        return networkAccessResult;
    }

    private Humidifier.EKS.CapabilityTypes.NetworkAccess CreateNetworkAccess()
    {
        var networkAccessResult = new Humidifier.EKS.CapabilityTypes.NetworkAccess();

        return networkAccessResult;
    }

} // End Of Class

public static class InnerCapabilityNetworkAccessFactoryExtensions
{
}
