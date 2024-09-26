// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerInAppTemplateDefaultButtonConfigurationFactory(Action<Humidifier.Pinpoint.InAppTemplateTypes.DefaultButtonConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.InAppTemplateTypes.DefaultButtonConfiguration>
{

    protected override Humidifier.Pinpoint.InAppTemplateTypes.DefaultButtonConfiguration Create()
    {
        var defaultButtonConfigurationResult = CreateDefaultButtonConfiguration();
        factoryAction?.Invoke(defaultButtonConfigurationResult);

        return defaultButtonConfigurationResult;
    }

    private Humidifier.Pinpoint.InAppTemplateTypes.DefaultButtonConfiguration CreateDefaultButtonConfiguration()
    {
        var defaultButtonConfigurationResult = new Humidifier.Pinpoint.InAppTemplateTypes.DefaultButtonConfiguration();

        return defaultButtonConfigurationResult;
    }

} // End Of Class

public static class InnerInAppTemplateDefaultButtonConfigurationFactoryExtensions
{
}
