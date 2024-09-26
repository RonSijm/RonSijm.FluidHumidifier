// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class DomainFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.Domain> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.Domain>(resourceName)
{

    internal InnerDomainMatchingFactory MatchingFactory { get; set; }

    internal InnerDomainRuleBasedMatchingFactory RuleBasedMatchingFactory { get; set; }

    protected override Humidifier.CustomerProfiles.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.CustomerProfiles.Domain CreateDomain()
    {
        var domainResult = new Humidifier.CustomerProfiles.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.Domain result)
    {
        base.CreateChildren(result);

        result.Matching ??= MatchingFactory?.Build();
        result.RuleBasedMatching ??= RuleBasedMatchingFactory?.Build();
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainMatchingFactory> WithMatching(this DomainFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null)
    {
        parentFactory.MatchingFactory = new InnerDomainMatchingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchingFactory);
    }

    public static CombinedResult<DomainFactory, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching(this DomainFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null)
    {
        parentFactory.RuleBasedMatchingFactory = new InnerDomainRuleBasedMatchingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleBasedMatchingFactory);
    }

    public static CombinedResult<DomainFactory, T1, InnerDomainMatchingFactory> WithMatching<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainMatchingFactory> WithMatching<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainMatchingFactory> WithMatching<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainMatchingFactory> WithMatching<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainMatchingFactory> WithMatching<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainMatchingFactory> WithMatching<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainMatchingFactory> WithMatching<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainMatchingFactory> WithMatching<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainMatchingFactory> WithMatching<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainMatchingFactory> WithMatching<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainMatchingFactory> WithMatching<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainMatchingFactory> WithMatching<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainMatchingFactory> WithMatching<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainMatchingFactory> WithMatching<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Matching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatching(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainRuleBasedMatchingFactory> WithRuleBasedMatching<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.RuleBasedMatching> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleBasedMatching(combinedResult.T5, subFactoryAction));
}
