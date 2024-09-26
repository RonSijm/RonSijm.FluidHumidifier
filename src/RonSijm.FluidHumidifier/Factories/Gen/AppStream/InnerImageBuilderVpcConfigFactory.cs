// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerImageBuilderVpcConfigFactory(Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.ImageBuilderTypes.VpcConfig>
{

    protected override Humidifier.AppStream.ImageBuilderTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.AppStream.ImageBuilderTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.AppStream.ImageBuilderTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerImageBuilderVpcConfigFactoryExtensions
{
}
