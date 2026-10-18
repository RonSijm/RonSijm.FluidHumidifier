// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerNetworkConnectorVpcEgressConfigurationFactory(Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration>
{

    protected override Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration Create()
    {
        var vpcEgressConfigurationResult = CreateVpcEgressConfiguration();
        factoryAction?.Invoke(vpcEgressConfigurationResult);

        return vpcEgressConfigurationResult;
    }

    private Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration CreateVpcEgressConfiguration()
    {
        var vpcEgressConfigurationResult = new Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration();

        return vpcEgressConfigurationResult;
    }

} // End Of Class

public static class InnerNetworkConnectorVpcEgressConfigurationFactoryExtensions
{
}
