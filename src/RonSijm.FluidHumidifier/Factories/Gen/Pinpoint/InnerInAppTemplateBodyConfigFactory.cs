// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerInAppTemplateBodyConfigFactory(Action<Humidifier.Pinpoint.InAppTemplateTypes.BodyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.InAppTemplateTypes.BodyConfig>
{

    protected override Humidifier.Pinpoint.InAppTemplateTypes.BodyConfig Create()
    {
        var bodyConfigResult = CreateBodyConfig();
        factoryAction?.Invoke(bodyConfigResult);

        return bodyConfigResult;
    }

    private Humidifier.Pinpoint.InAppTemplateTypes.BodyConfig CreateBodyConfig()
    {
        var bodyConfigResult = new Humidifier.Pinpoint.InAppTemplateTypes.BodyConfig();

        return bodyConfigResult;
    }

} // End Of Class

public static class InnerInAppTemplateBodyConfigFactoryExtensions
{
}
