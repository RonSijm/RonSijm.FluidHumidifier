// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConformancePackTemplateSSMDocumentDetailsFactory(Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails>
{

    protected override Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails Create()
    {
        var templateSSMDocumentDetailsResult = CreateTemplateSSMDocumentDetails();
        factoryAction?.Invoke(templateSSMDocumentDetailsResult);

        return templateSSMDocumentDetailsResult;
    }

    private Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails CreateTemplateSSMDocumentDetails()
    {
        var templateSSMDocumentDetailsResult = new Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails();

        return templateSSMDocumentDetailsResult;
    }

} // End Of Class

public static class InnerConformancePackTemplateSSMDocumentDetailsFactoryExtensions
{
}
