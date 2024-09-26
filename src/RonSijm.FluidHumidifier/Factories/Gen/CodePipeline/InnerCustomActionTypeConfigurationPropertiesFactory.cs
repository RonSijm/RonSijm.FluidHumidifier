// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerCustomActionTypeConfigurationPropertiesFactory(Action<Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties>
{

    protected override Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties Create()
    {
        var configurationPropertiesResult = CreateConfigurationProperties();
        factoryAction?.Invoke(configurationPropertiesResult);

        return configurationPropertiesResult;
    }

    private Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties CreateConfigurationProperties()
    {
        var configurationPropertiesResult = new Humidifier.CodePipeline.CustomActionTypeTypes.ConfigurationProperties();

        return configurationPropertiesResult;
    }

} // End Of Class

public static class InnerCustomActionTypeConfigurationPropertiesFactoryExtensions
{
}
