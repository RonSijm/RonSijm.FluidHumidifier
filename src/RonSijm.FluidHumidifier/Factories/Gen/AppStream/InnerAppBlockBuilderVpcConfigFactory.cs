// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerAppBlockBuilderVpcConfigFactory(Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig>
{

    protected override Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerAppBlockBuilderVpcConfigFactoryExtensions
{
}
