// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class SecurityConfigurationFactory(string resourceName = null, Action<Humidifier.EMR.SecurityConfiguration> factoryAction = null) : ResourceFactory<Humidifier.EMR.SecurityConfiguration>(resourceName)
{

    protected override Humidifier.EMR.SecurityConfiguration Create()
    {
        var securityConfigurationResult = CreateSecurityConfiguration();
        factoryAction?.Invoke(securityConfigurationResult);

        return securityConfigurationResult;
    }

    private Humidifier.EMR.SecurityConfiguration CreateSecurityConfiguration()
    {
        var securityConfigurationResult = new Humidifier.EMR.SecurityConfiguration
        {
            GivenName = InputResourceName,
        };

        return securityConfigurationResult;
    }

} // End Of Class

public static class SecurityConfigurationFactoryExtensions
{
}
