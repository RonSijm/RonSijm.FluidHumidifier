// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupJA3FingerprintFactory(Action<Humidifier.WAFv2.RuleGroupTypes.JA3Fingerprint> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.JA3Fingerprint>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.JA3Fingerprint Create()
    {
        var jA3FingerprintResult = CreateJA3Fingerprint();
        factoryAction?.Invoke(jA3FingerprintResult);

        return jA3FingerprintResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.JA3Fingerprint CreateJA3Fingerprint()
    {
        var jA3FingerprintResult = new Humidifier.WAFv2.RuleGroupTypes.JA3Fingerprint();

        return jA3FingerprintResult;
    }

} // End Of Class

public static class InnerRuleGroupJA3FingerprintFactoryExtensions
{
}
