// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateTemplateSourceTemplateFactory(Action<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate>
{

    protected override Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate Create()
    {
        var templateSourceTemplateResult = CreateTemplateSourceTemplate();
        factoryAction?.Invoke(templateSourceTemplateResult);

        return templateSourceTemplateResult;
    }

    private Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate CreateTemplateSourceTemplate()
    {
        var templateSourceTemplateResult = new Humidifier.QuickSight.TemplateTypes.TemplateSourceTemplate();

        return templateSourceTemplateResult;
    }

} // End Of Class

public static class InnerTemplateTemplateSourceTemplateFactoryExtensions
{
}
