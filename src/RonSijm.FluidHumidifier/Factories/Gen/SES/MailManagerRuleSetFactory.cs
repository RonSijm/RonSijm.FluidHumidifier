// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerRuleSetFactory(string resourceName = null, Action<Humidifier.SES.MailManagerRuleSet> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerRuleSet>(resourceName)
{

    internal List<InnerMailManagerRuleSetRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.SES.MailManagerRuleSet Create()
    {
        var mailManagerRuleSetResult = CreateMailManagerRuleSet();
        factoryAction?.Invoke(mailManagerRuleSetResult);

        return mailManagerRuleSetResult;
    }

    private Humidifier.SES.MailManagerRuleSet CreateMailManagerRuleSet()
    {
        var mailManagerRuleSetResult = new Humidifier.SES.MailManagerRuleSet
        {
            GivenName = InputResourceName,
        };

        return mailManagerRuleSetResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerRuleSet result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MailManagerRuleSetFactoryExtensions
{
    public static CombinedResult<MailManagerRuleSetFactory, InnerMailManagerRuleSetRuleFactory> WithRules(this MailManagerRuleSetFactory parentFactory, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerMailManagerRuleSetRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MailManagerRuleSetFactory, T1, InnerMailManagerRuleSetRuleFactory> WithRules<T1>(this CombinedResult<MailManagerRuleSetFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRuleSetFactory, InnerMailManagerRuleSetRuleFactory> WithRules<T1>(this CombinedResult<T1, MailManagerRuleSetFactory> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MailManagerRuleSetFactory, T1, T2, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2>(this CombinedResult<MailManagerRuleSetFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRuleSetFactory, T2, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, MailManagerRuleSetFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerRuleSetFactory, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, MailManagerRuleSetFactory> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MailManagerRuleSetFactory, T1, T2, T3, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<MailManagerRuleSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRuleSetFactory, T2, T3, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, MailManagerRuleSetFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerRuleSetFactory, T3, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, MailManagerRuleSetFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerRuleSetFactory, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, MailManagerRuleSetFactory> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MailManagerRuleSetFactory, T1, T2, T3, T4, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<MailManagerRuleSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerRuleSetFactory, T2, T3, T4, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, MailManagerRuleSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerRuleSetFactory, T3, T4, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, MailManagerRuleSetFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerRuleSetFactory, T4, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MailManagerRuleSetFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MailManagerRuleSetFactory, InnerMailManagerRuleSetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MailManagerRuleSetFactory> combinedResult, Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
}
