// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigRuleCustomPolicyDetailsFactory(Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails>
{

    protected override Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails Create()
    {
        var customPolicyDetailsResult = CreateCustomPolicyDetails();
        factoryAction?.Invoke(customPolicyDetailsResult);

        return customPolicyDetailsResult;
    }

    private Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails CreateCustomPolicyDetails()
    {
        var customPolicyDetailsResult = new Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails();

        return customPolicyDetailsResult;
    }

} // End Of Class

public static class InnerConfigRuleCustomPolicyDetailsFactoryExtensions
{
}
