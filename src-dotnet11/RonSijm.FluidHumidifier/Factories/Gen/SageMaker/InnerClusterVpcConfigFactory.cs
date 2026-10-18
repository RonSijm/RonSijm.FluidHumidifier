// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterVpcConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.ClusterTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerClusterVpcConfigFactoryExtensions
{
}
