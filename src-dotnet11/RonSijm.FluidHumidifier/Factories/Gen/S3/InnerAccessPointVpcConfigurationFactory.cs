// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerAccessPointVpcConfigurationFactory(Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.AccessPointTypes.VpcConfiguration>
{

    protected override Humidifier.S3.AccessPointTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.S3.AccessPointTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.S3.AccessPointTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerAccessPointVpcConfigurationFactoryExtensions
{
}
