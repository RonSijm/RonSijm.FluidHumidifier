// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigRuleComplianceFactory(Action<Humidifier.Config.ConfigRuleTypes.Compliance> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigRuleTypes.Compliance>
{

    protected override Humidifier.Config.ConfigRuleTypes.Compliance Create()
    {
        var complianceResult = CreateCompliance();
        factoryAction?.Invoke(complianceResult);

        return complianceResult;
    }

    private Humidifier.Config.ConfigRuleTypes.Compliance CreateCompliance()
    {
        var complianceResult = new Humidifier.Config.ConfigRuleTypes.Compliance();

        return complianceResult;
    }

} // End Of Class

public static class InnerConfigRuleComplianceFactoryExtensions
{
}
