// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupJA4FingerprintFactory(Action<Humidifier.WAFv2.RuleGroupTypes.JA4Fingerprint> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.JA4Fingerprint>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.JA4Fingerprint Create()
    {
        var jA4FingerprintResult = CreateJA4Fingerprint();
        factoryAction?.Invoke(jA4FingerprintResult);

        return jA4FingerprintResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.JA4Fingerprint CreateJA4Fingerprint()
    {
        var jA4FingerprintResult = new Humidifier.WAFv2.RuleGroupTypes.JA4Fingerprint();

        return jA4FingerprintResult;
    }

} // End Of Class

public static class InnerRuleGroupJA4FingerprintFactoryExtensions
{
}
