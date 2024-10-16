// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerVirtualClusterEksInfoFactory(Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo>
{

    protected override Humidifier.EMRContainers.VirtualClusterTypes.EksInfo Create()
    {
        var eksInfoResult = CreateEksInfo();
        factoryAction?.Invoke(eksInfoResult);

        return eksInfoResult;
    }

    private Humidifier.EMRContainers.VirtualClusterTypes.EksInfo CreateEksInfo()
    {
        var eksInfoResult = new Humidifier.EMRContainers.VirtualClusterTypes.EksInfo();

        return eksInfoResult;
    }

} // End Of Class

public static class InnerVirtualClusterEksInfoFactoryExtensions
{
}
