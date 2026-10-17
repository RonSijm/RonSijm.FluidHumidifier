// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerSigningConfigurationRuleFactory(Action<Humidifier.ECR.SigningConfigurationTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.ECR.SigningConfigurationTypes.Rule>
{

    protected override Humidifier.ECR.SigningConfigurationTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.ECR.SigningConfigurationTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.ECR.SigningConfigurationTypes.Rule();

        return ruleResult;
    }

} // End Of Class

public static class InnerSigningConfigurationRuleFactoryExtensions
{
}
