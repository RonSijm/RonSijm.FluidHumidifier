// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerTargetGroupMatcherFactory(Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher>
{

    protected override Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher Create()
    {
        var matcherResult = CreateMatcher();
        factoryAction?.Invoke(matcherResult);

        return matcherResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher CreateMatcher()
    {
        var matcherResult = new Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher();

        return matcherResult;
    }

} // End Of Class

public static class InnerTargetGroupMatcherFactoryExtensions
{
}
