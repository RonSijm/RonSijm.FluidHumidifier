// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeConnections;

public class InnerHostVpcConfigurationFactory(Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeConnections.HostTypes.VpcConfiguration>
{

    protected override Humidifier.CodeConnections.HostTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.CodeConnections.HostTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.CodeConnections.HostTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerHostVpcConfigurationFactoryExtensions
{
}
