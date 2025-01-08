// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterComputeConfigFactory(Action<Humidifier.EKS.ClusterTypes.ComputeConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ComputeConfig>
{

    protected override Humidifier.EKS.ClusterTypes.ComputeConfig Create()
    {
        var computeConfigResult = CreateComputeConfig();
        factoryAction?.Invoke(computeConfigResult);

        return computeConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.ComputeConfig CreateComputeConfig()
    {
        var computeConfigResult = new Humidifier.EKS.ClusterTypes.ComputeConfig();

        return computeConfigResult;
    }

} // End Of Class

public static class InnerClusterComputeConfigFactoryExtensions
{
}
