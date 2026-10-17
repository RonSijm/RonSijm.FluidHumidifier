// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory(Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration>
{

    protected override Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration Create()
    {
        var ipamScopeExternalAuthorityConfigurationResult = CreateIpamScopeExternalAuthorityConfiguration();
        factoryAction?.Invoke(ipamScopeExternalAuthorityConfigurationResult);

        return ipamScopeExternalAuthorityConfigurationResult;
    }

    private Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration CreateIpamScopeExternalAuthorityConfiguration()
    {
        var ipamScopeExternalAuthorityConfigurationResult = new Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration();

        return ipamScopeExternalAuthorityConfigurationResult;
    }

} // End Of Class

public static class InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactoryExtensions
{
}
