// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerServerlessClusterVpcConfigFactory(Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ServerlessClusterTypes.VpcConfig>
{

    protected override Humidifier.MSK.ServerlessClusterTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.MSK.ServerlessClusterTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.MSK.ServerlessClusterTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerServerlessClusterVpcConfigFactoryExtensions
{
}
