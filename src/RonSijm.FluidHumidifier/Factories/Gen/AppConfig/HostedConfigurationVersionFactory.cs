// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class HostedConfigurationVersionFactory(string resourceName = null, Action<Humidifier.AppConfig.HostedConfigurationVersion> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.HostedConfigurationVersion>(resourceName)
{

    protected override Humidifier.AppConfig.HostedConfigurationVersion Create()
    {
        var hostedConfigurationVersionResult = CreateHostedConfigurationVersion();
        factoryAction?.Invoke(hostedConfigurationVersionResult);

        return hostedConfigurationVersionResult;
    }

    private Humidifier.AppConfig.HostedConfigurationVersion CreateHostedConfigurationVersion()
    {
        var hostedConfigurationVersionResult = new Humidifier.AppConfig.HostedConfigurationVersion
        {
            GivenName = InputResourceName,
        };

        return hostedConfigurationVersionResult;
    }

} // End Of Class

public static class HostedConfigurationVersionFactoryExtensions
{
}
