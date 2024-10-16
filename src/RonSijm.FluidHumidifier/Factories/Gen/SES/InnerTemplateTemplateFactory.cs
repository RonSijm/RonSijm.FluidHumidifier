// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerTemplateTemplateFactory(Action<Humidifier.SES.TemplateTypes.Template> factoryAction = null) : SubResourceFactory<Humidifier.SES.TemplateTypes.Template>
{

    protected override Humidifier.SES.TemplateTypes.Template Create()
    {
        var templateResult = CreateTemplate();
        factoryAction?.Invoke(templateResult);

        return templateResult;
    }

    private Humidifier.SES.TemplateTypes.Template CreateTemplate()
    {
        var templateResult = new Humidifier.SES.TemplateTypes.Template();

        return templateResult;
    }

} // End Of Class

public static class InnerTemplateTemplateFactoryExtensions
{
}
