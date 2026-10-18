// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class InnerSamplingRuleSamplingRateBoostFactory(Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> factoryAction = null) : SubResourceFactory<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost>
{

    protected override Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost Create()
    {
        var samplingRateBoostResult = CreateSamplingRateBoost();
        factoryAction?.Invoke(samplingRateBoostResult);

        return samplingRateBoostResult;
    }

    private Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost CreateSamplingRateBoost()
    {
        var samplingRateBoostResult = new Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost();

        return samplingRateBoostResult;
    }

} // End Of Class

public static class InnerSamplingRuleSamplingRateBoostFactoryExtensions
{
}
