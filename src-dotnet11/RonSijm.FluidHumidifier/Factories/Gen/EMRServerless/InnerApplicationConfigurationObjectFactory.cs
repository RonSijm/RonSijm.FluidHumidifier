// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationConfigurationObjectFactory(Action<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject Create()
    {
        var configurationObjectResult = CreateConfigurationObject();
        factoryAction?.Invoke(configurationObjectResult);

        return configurationObjectResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject CreateConfigurationObject()
    {
        var configurationObjectResult = new Humidifier.EMRServerless.ApplicationTypes.ConfigurationObject();

        return configurationObjectResult;
    }

} // End Of Class

public static class InnerApplicationConfigurationObjectFactoryExtensions
{
}
