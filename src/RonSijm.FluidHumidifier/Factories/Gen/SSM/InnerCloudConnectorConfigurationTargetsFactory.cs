// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerCloudConnectorConfigurationTargetsFactory(Action<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets> factoryAction = null) : SubResourceFactory<Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets>
{

    protected override Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets Create()
    {
        var configurationTargetsResult = CreateConfigurationTargets();
        factoryAction?.Invoke(configurationTargetsResult);

        return configurationTargetsResult;
    }

    private Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets CreateConfigurationTargets()
    {
        var configurationTargetsResult = new Humidifier.SSM.CloudConnectorTypes.ConfigurationTargets();

        return configurationTargetsResult;
    }

} // End Of Class

public static class InnerCloudConnectorConfigurationTargetsFactoryExtensions
{
}
