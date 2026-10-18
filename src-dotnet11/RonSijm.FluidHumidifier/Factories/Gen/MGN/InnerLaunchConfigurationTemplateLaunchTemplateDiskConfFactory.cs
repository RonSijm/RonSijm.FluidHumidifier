// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerLaunchConfigurationTemplateLaunchTemplateDiskConfFactory(Action<Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf> factoryAction = null) : SubResourceFactory<Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf>
{

    protected override Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf Create()
    {
        var launchTemplateDiskConfResult = CreateLaunchTemplateDiskConf();
        factoryAction?.Invoke(launchTemplateDiskConfResult);

        return launchTemplateDiskConfResult;
    }

    private Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf CreateLaunchTemplateDiskConf()
    {
        var launchTemplateDiskConfResult = new Humidifier.MGN.LaunchConfigurationTemplateTypes.LaunchTemplateDiskConf();

        return launchTemplateDiskConfResult;
    }

} // End Of Class

public static class InnerLaunchConfigurationTemplateLaunchTemplateDiskConfFactoryExtensions
{
}
