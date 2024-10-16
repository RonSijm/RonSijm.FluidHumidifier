// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerEnvironmentOptionSettingFactory(Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting>
{

    protected override Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting Create()
    {
        var optionSettingResult = CreateOptionSetting();
        factoryAction?.Invoke(optionSettingResult);

        return optionSettingResult;
    }

    private Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting CreateOptionSetting()
    {
        var optionSettingResult = new Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting();

        return optionSettingResult;
    }

} // End Of Class

public static class InnerEnvironmentOptionSettingFactoryExtensions
{
}
