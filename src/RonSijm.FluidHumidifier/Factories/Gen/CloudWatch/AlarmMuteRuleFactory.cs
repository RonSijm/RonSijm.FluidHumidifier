// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class AlarmMuteRuleFactory(string resourceName = null, Action<Humidifier.CloudWatch.AlarmMuteRule> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.AlarmMuteRule>(resourceName)
{

    internal InnerAlarmMuteRuleMuteTargetsFactory MuteTargetsFactory { get; set; }

    internal InnerAlarmMuteRuleRuleFactory RuleFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmMuteRule Create()
    {
        var alarmMuteRuleResult = CreateAlarmMuteRule();
        factoryAction?.Invoke(alarmMuteRuleResult);

        return alarmMuteRuleResult;
    }

    private Humidifier.CloudWatch.AlarmMuteRule CreateAlarmMuteRule()
    {
        var alarmMuteRuleResult = new Humidifier.CloudWatch.AlarmMuteRule
        {
            GivenName = InputResourceName,
        };

        return alarmMuteRuleResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmMuteRule result)
    {
        base.CreateChildren(result);

        result.MuteTargets ??= MuteTargetsFactory?.Build();
        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class AlarmMuteRuleFactoryExtensions
{
    public static CombinedResult<AlarmMuteRuleFactory, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets(this AlarmMuteRuleFactory parentFactory, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null)
    {
        parentFactory.MuteTargetsFactory = new InnerAlarmMuteRuleMuteTargetsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MuteTargetsFactory);
    }

    public static CombinedResult<AlarmMuteRuleFactory, InnerAlarmMuteRuleRuleFactory> WithRule(this AlarmMuteRuleFactory parentFactory, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerAlarmMuteRuleRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<AlarmMuteRuleFactory, T1, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1>(this CombinedResult<AlarmMuteRuleFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithMuteTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1>(this CombinedResult<T1, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithMuteTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, T2, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2>(this CombinedResult<AlarmMuteRuleFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, T2, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2>(this CombinedResult<T1, AlarmMuteRuleFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlarmMuteRuleFactory, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2>(this CombinedResult<T1, T2, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, T2, T3, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3>(this CombinedResult<AlarmMuteRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, T2, T3, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3>(this CombinedResult<T1, AlarmMuteRuleFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlarmMuteRuleFactory, T3, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3>(this CombinedResult<T1, T2, AlarmMuteRuleFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlarmMuteRuleFactory, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, T2, T3, T4, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3, T4>(this CombinedResult<AlarmMuteRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, T2, T3, T4, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3, T4>(this CombinedResult<T1, AlarmMuteRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlarmMuteRuleFactory, T3, T4, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmMuteRuleFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlarmMuteRuleFactory, T4, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmMuteRuleFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AlarmMuteRuleFactory, InnerAlarmMuteRuleMuteTargetsFactory> WithMuteTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMuteTargets(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, InnerAlarmMuteRuleRuleFactory> WithRule<T1>(this CombinedResult<AlarmMuteRuleFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, InnerAlarmMuteRuleRuleFactory> WithRule<T1>(this CombinedResult<T1, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, T2, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2>(this CombinedResult<AlarmMuteRuleFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, T2, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, AlarmMuteRuleFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlarmMuteRuleFactory, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, T2, T3, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<AlarmMuteRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, T2, T3, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, AlarmMuteRuleFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlarmMuteRuleFactory, T3, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, AlarmMuteRuleFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlarmMuteRuleFactory, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AlarmMuteRuleFactory, T1, T2, T3, T4, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<AlarmMuteRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AlarmMuteRuleFactory, T2, T3, T4, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, AlarmMuteRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AlarmMuteRuleFactory, T3, T4, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmMuteRuleFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AlarmMuteRuleFactory, T4, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmMuteRuleFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AlarmMuteRuleFactory, InnerAlarmMuteRuleRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmMuteRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction).T2);
}
