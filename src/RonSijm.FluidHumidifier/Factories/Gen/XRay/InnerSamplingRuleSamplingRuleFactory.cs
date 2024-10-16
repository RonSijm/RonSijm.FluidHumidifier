// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class InnerSamplingRuleSamplingRuleFactory(Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> factoryAction = null) : SubResourceFactory<Humidifier.XRay.SamplingRuleTypes.SamplingRule>
{

    protected override Humidifier.XRay.SamplingRuleTypes.SamplingRule Create()
    {
        var samplingRuleResult = CreateSamplingRule();
        factoryAction?.Invoke(samplingRuleResult);

        return samplingRuleResult;
    }

    private Humidifier.XRay.SamplingRuleTypes.SamplingRule CreateSamplingRule()
    {
        var samplingRuleResult = new Humidifier.XRay.SamplingRuleTypes.SamplingRule();

        return samplingRuleResult;
    }

} // End Of Class

public static class InnerSamplingRuleSamplingRuleFactoryExtensions
{
}
