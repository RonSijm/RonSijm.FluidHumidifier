// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMQuickSetup;

public class InnerConfigurationManagerConfigurationDefinitionFactory(Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition>
{

    protected override Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition Create()
    {
        var configurationDefinitionResult = CreateConfigurationDefinition();
        factoryAction?.Invoke(configurationDefinitionResult);

        return configurationDefinitionResult;
    }

    private Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition CreateConfigurationDefinition()
    {
        var configurationDefinitionResult = new Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition();

        return configurationDefinitionResult;
    }

} // End Of Class

public static class InnerConfigurationManagerConfigurationDefinitionFactoryExtensions
{
}
