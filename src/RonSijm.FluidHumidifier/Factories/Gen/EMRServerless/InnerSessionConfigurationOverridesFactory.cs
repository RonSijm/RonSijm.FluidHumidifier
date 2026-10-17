// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerSessionConfigurationOverridesFactory(Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides>
{

    protected override Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides Create()
    {
        var configurationOverridesResult = CreateConfigurationOverrides();
        factoryAction?.Invoke(configurationOverridesResult);

        return configurationOverridesResult;
    }

    private Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides CreateConfigurationOverrides()
    {
        var configurationOverridesResult = new Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides();

        return configurationOverridesResult;
    }

} // End Of Class

public static class InnerSessionConfigurationOverridesFactoryExtensions
{
}
