// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerDetectorRuleFactory(Action<Humidifier.FraudDetector.DetectorTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.DetectorTypes.Rule>
{

    protected override Humidifier.FraudDetector.DetectorTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.FraudDetector.DetectorTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.FraudDetector.DetectorTypes.Rule();

        return ruleResult;
    }

} // End Of Class

public static class InnerDetectorRuleFactoryExtensions
{
}
