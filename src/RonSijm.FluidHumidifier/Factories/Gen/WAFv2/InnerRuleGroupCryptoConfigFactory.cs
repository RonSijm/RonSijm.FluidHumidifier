// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCryptoConfigFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.CryptoConfig Create()
    {
        var cryptoConfigResult = CreateCryptoConfig();
        factoryAction?.Invoke(cryptoConfigResult);

        return cryptoConfigResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CryptoConfig CreateCryptoConfig()
    {
        var cryptoConfigResult = new Humidifier.WAFv2.RuleGroupTypes.CryptoConfig();

        return cryptoConfigResult;
    }

} // End Of Class

public static class InnerRuleGroupCryptoConfigFactoryExtensions
{
}
