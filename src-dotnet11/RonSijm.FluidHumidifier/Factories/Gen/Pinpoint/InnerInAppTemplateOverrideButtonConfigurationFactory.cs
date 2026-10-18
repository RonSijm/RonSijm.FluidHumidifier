// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerInAppTemplateOverrideButtonConfigurationFactory(Action<Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration>
{

    protected override Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration Create()
    {
        var overrideButtonConfigurationResult = CreateOverrideButtonConfiguration();
        factoryAction?.Invoke(overrideButtonConfigurationResult);

        return overrideButtonConfigurationResult;
    }

    private Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration CreateOverrideButtonConfiguration()
    {
        var overrideButtonConfigurationResult = new Humidifier.Pinpoint.InAppTemplateTypes.OverrideButtonConfiguration();

        return overrideButtonConfigurationResult;
    }

} // End Of Class

public static class InnerInAppTemplateOverrideButtonConfigurationFactoryExtensions
{
}
