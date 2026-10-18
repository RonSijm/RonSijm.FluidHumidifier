// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMPrefixListResolverFactory(string resourceName = null, Action<Humidifier.EC2.IPAMPrefixListResolver> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMPrefixListResolver>(resourceName)
{

    internal List<InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.EC2.IPAMPrefixListResolver Create()
    {
        var iPAMPrefixListResolverResult = CreateIPAMPrefixListResolver();
        factoryAction?.Invoke(iPAMPrefixListResolverResult);

        return iPAMPrefixListResolverResult;
    }

    private Humidifier.EC2.IPAMPrefixListResolver CreateIPAMPrefixListResolver()
    {
        var iPAMPrefixListResolverResult = new Humidifier.EC2.IPAMPrefixListResolver
        {
            GivenName = InputResourceName,
        };

        return iPAMPrefixListResolverResult;
    }
    public override void CreateChildren(Humidifier.EC2.IPAMPrefixListResolver result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IPAMPrefixListResolverFactoryExtensions
{
    public static CombinedResult<IPAMPrefixListResolverFactory, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules(this IPAMPrefixListResolverFactory parentFactory, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null)
    {
        var factory = new InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPAMPrefixListResolverFactory, T1, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1>(this CombinedResult<IPAMPrefixListResolverFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMPrefixListResolverFactory, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1>(this CombinedResult<T1, IPAMPrefixListResolverFactory> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IPAMPrefixListResolverFactory, T1, T2, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2>(this CombinedResult<IPAMPrefixListResolverFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMPrefixListResolverFactory, T2, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, IPAMPrefixListResolverFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMPrefixListResolverFactory, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, IPAMPrefixListResolverFactory> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IPAMPrefixListResolverFactory, T1, T2, T3, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<IPAMPrefixListResolverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMPrefixListResolverFactory, T2, T3, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, IPAMPrefixListResolverFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMPrefixListResolverFactory, T3, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, IPAMPrefixListResolverFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMPrefixListResolverFactory, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMPrefixListResolverFactory> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IPAMPrefixListResolverFactory, T1, T2, T3, T4, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<IPAMPrefixListResolverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMPrefixListResolverFactory, T2, T3, T4, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, IPAMPrefixListResolverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMPrefixListResolverFactory, T3, T4, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMPrefixListResolverFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMPrefixListResolverFactory, T4, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMPrefixListResolverFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IPAMPrefixListResolverFactory, InnerIPAMPrefixListResolverIpamPrefixListResolverRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMPrefixListResolverFactory> combinedResult, Action<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction).T2);
}
