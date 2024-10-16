// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerConfigurationTemplateConfigurationOptionSettingFactory(Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting>
{

    protected override Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting Create()
    {
        var configurationOptionSettingResult = CreateConfigurationOptionSetting();
        factoryAction?.Invoke(configurationOptionSettingResult);

        return configurationOptionSettingResult;
    }

    private Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting CreateConfigurationOptionSetting()
    {
        var configurationOptionSettingResult = new Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting();

        return configurationOptionSettingResult;
    }

} // End Of Class

public static class InnerConfigurationTemplateConfigurationOptionSettingFactoryExtensions
{
}
