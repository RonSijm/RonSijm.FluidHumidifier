// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerAccessPointVpcConfigurationFactory(Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.AccessPointTypes.VpcConfiguration>
{

    protected override Humidifier.S3Express.AccessPointTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.S3Express.AccessPointTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.S3Express.AccessPointTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerAccessPointVpcConfigurationFactoryExtensions
{
}
