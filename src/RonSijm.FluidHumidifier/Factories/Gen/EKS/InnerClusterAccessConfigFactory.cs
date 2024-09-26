// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterAccessConfigFactory(Action<Humidifier.EKS.ClusterTypes.AccessConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.AccessConfig>
{

    protected override Humidifier.EKS.ClusterTypes.AccessConfig Create()
    {
        var accessConfigResult = CreateAccessConfig();
        factoryAction?.Invoke(accessConfigResult);

        return accessConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.AccessConfig CreateAccessConfig()
    {
        var accessConfigResult = new Humidifier.EKS.ClusterTypes.AccessConfig();

        return accessConfigResult;
    }

} // End Of Class

public static class InnerClusterAccessConfigFactoryExtensions
{
}
