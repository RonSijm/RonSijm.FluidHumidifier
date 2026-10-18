// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterResourcesVpcConfigFactory(Action<Humidifier.EKS.ClusterTypes.ResourcesVpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ResourcesVpcConfig>
{

    protected override Humidifier.EKS.ClusterTypes.ResourcesVpcConfig Create()
    {
        var resourcesVpcConfigResult = CreateResourcesVpcConfig();
        factoryAction?.Invoke(resourcesVpcConfigResult);

        return resourcesVpcConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.ResourcesVpcConfig CreateResourcesVpcConfig()
    {
        var resourcesVpcConfigResult = new Humidifier.EKS.ClusterTypes.ResourcesVpcConfig();

        return resourcesVpcConfigResult;
    }

} // End Of Class

public static class InnerClusterResourcesVpcConfigFactoryExtensions
{
}
