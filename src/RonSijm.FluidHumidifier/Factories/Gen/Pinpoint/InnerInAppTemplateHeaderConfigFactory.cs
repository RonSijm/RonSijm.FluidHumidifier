// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerInAppTemplateHeaderConfigFactory(Action<Humidifier.Pinpoint.InAppTemplateTypes.HeaderConfig> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.InAppTemplateTypes.HeaderConfig>
{

    protected override Humidifier.Pinpoint.InAppTemplateTypes.HeaderConfig Create()
    {
        var headerConfigResult = CreateHeaderConfig();
        factoryAction?.Invoke(headerConfigResult);

        return headerConfigResult;
    }

    private Humidifier.Pinpoint.InAppTemplateTypes.HeaderConfig CreateHeaderConfig()
    {
        var headerConfigResult = new Humidifier.Pinpoint.InAppTemplateTypes.HeaderConfig();

        return headerConfigResult;
    }

} // End Of Class

public static class InnerInAppTemplateHeaderConfigFactoryExtensions
{
}
