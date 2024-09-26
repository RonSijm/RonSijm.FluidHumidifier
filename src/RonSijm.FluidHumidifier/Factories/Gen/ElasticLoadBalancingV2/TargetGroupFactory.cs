// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class TargetGroupFactory(string resourceName = null, Action<Humidifier.ElasticLoadBalancingV2.TargetGroup> factoryAction = null) : ResourceFactory<Humidifier.ElasticLoadBalancingV2.TargetGroup>(resourceName)
{

    internal List<InnerTargetGroupTargetDescriptionFactory> TargetsFactories { get; set; } = [];

    internal List<InnerTargetGroupTargetGroupAttributeFactory> TargetGroupAttributesFactories { get; set; } = [];

    internal InnerTargetGroupMatcherFactory MatcherFactory { get; set; }

    protected override Humidifier.ElasticLoadBalancingV2.TargetGroup Create()
    {
        var targetGroupResult = CreateTargetGroup();
        factoryAction?.Invoke(targetGroupResult);

        return targetGroupResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TargetGroup CreateTargetGroup()
    {
        var targetGroupResult = new Humidifier.ElasticLoadBalancingV2.TargetGroup
        {
            GivenName = InputResourceName,
        };

        return targetGroupResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.TargetGroup result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
        result.TargetGroupAttributes = TargetGroupAttributesFactories.Any() ? TargetGroupAttributesFactories.Select(x => x.Build()).ToList() : null;
        result.Matcher ??= MatcherFactory?.Build();
    }

} // End Of Class

public static class TargetGroupFactoryExtensions
{
    public static CombinedResult<TargetGroupFactory, InnerTargetGroupTargetDescriptionFactory> WithTargets(this TargetGroupFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null)
    {
        var factory = new InnerTargetGroupTargetDescriptionFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TargetGroupFactory, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes(this TargetGroupFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null)
    {
        var factory = new InnerTargetGroupTargetGroupAttributeFactory(subFactoryAction);
        parentFactory.TargetGroupAttributesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TargetGroupFactory, InnerTargetGroupMatcherFactory> WithMatcher(this TargetGroupFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null)
    {
        parentFactory.MatcherFactory = new InnerTargetGroupMatcherFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatcherFactory);
    }

    public static CombinedResult<TargetGroupFactory, T1, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1>(this CombinedResult<TargetGroupFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1>(this CombinedResult<T1, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2>(this CombinedResult<TargetGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2>(this CombinedResult<T1, TargetGroupFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3>(this CombinedResult<TargetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, TargetGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, TargetGroupFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, T4, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<TargetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, T4, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, TargetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, T4, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, T4, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetGroupFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TargetGroupFactory, InnerTargetGroupTargetDescriptionFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1>(this CombinedResult<TargetGroupFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1>(this CombinedResult<T1, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2>(this CombinedResult<TargetGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2>(this CombinedResult<T1, TargetGroupFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2>(this CombinedResult<T1, T2, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3>(this CombinedResult<TargetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3>(this CombinedResult<T1, TargetGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3>(this CombinedResult<T1, T2, TargetGroupFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, T4, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3, T4>(this CombinedResult<TargetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, T4, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3, T4>(this CombinedResult<T1, TargetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, T4, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, T4, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetGroupFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TargetGroupFactory, InnerTargetGroupTargetGroupAttributeFactory> WithTargetGroupAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupAttributes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, InnerTargetGroupMatcherFactory> WithMatcher<T1>(this CombinedResult<TargetGroupFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1>(this CombinedResult<T1, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<TargetGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<T1, TargetGroupFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<T1, T2, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<TargetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, TargetGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, T2, TargetGroupFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<TargetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, TargetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetGroupFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TargetGroupFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetGroupFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T5, subFactoryAction));
}
