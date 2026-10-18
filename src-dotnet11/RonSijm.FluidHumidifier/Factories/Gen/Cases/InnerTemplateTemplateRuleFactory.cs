// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerTemplateTemplateRuleFactory(Action<Humidifier.Cases.TemplateTypes.TemplateRule> factoryAction = null) : SubResourceFactory<Humidifier.Cases.TemplateTypes.TemplateRule>
{

    protected override Humidifier.Cases.TemplateTypes.TemplateRule Create()
    {
        var templateRuleResult = CreateTemplateRule();
        factoryAction?.Invoke(templateRuleResult);

        return templateRuleResult;
    }

    private Humidifier.Cases.TemplateTypes.TemplateRule CreateTemplateRule()
    {
        var templateRuleResult = new Humidifier.Cases.TemplateTypes.TemplateRule();

        return templateRuleResult;
    }

} // End Of Class

public static class InnerTemplateTemplateRuleFactoryExtensions
{
}
