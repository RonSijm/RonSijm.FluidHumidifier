// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConfigurationPolicySecurityControlsConfigurationFactory(Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration>
{

    protected override Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration Create()
    {
        var securityControlsConfigurationResult = CreateSecurityControlsConfiguration();
        factoryAction?.Invoke(securityControlsConfigurationResult);

        return securityControlsConfigurationResult;
    }

    private Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration CreateSecurityControlsConfiguration()
    {
        var securityControlsConfigurationResult = new Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration();

        return securityControlsConfigurationResult;
    }

} // End Of Class

public static class InnerConfigurationPolicySecurityControlsConfigurationFactoryExtensions
{
}
