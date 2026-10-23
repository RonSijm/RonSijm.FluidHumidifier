// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerLogAlarmActionConfigurationFactory(Action<Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration>
{

    internal InnerLogAlarmAlarmTagsPropagationFactory AlarmTagsPropagationFactory { get; set; }

    protected override Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration Create()
    {
        var actionConfigurationResult = CreateActionConfiguration();
        factoryAction?.Invoke(actionConfigurationResult);

        return actionConfigurationResult;
    }

    private Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration CreateActionConfiguration()
    {
        var actionConfigurationResult = new Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration();

        return actionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration result)
    {
        base.CreateChildren(result);

        result.AlarmTagsPropagation ??= AlarmTagsPropagationFactory?.Build();
    }

} // End Of Class

public static class InnerLogAlarmActionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerLogAlarmActionConfigurationFactory, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation(this InnerLogAlarmActionConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null)
    {
        parentFactory.AlarmTagsPropagationFactory = new InnerLogAlarmAlarmTagsPropagationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmTagsPropagationFactory);
    }

    public static CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1>(this CombinedResult<InnerLogAlarmActionConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1>(this CombinedResult<T1, InnerLogAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, T2, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, T2, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLogAlarmActionConfigurationFactory, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<T1, T2, InnerLogAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, T2, T3, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, T2, T3, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLogAlarmActionConfigurationFactory, T3, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, T2, InnerLogAlarmActionConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLogAlarmActionConfigurationFactory, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLogAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, T2, T3, T4, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<InnerLogAlarmActionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, T2, T3, T4, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, InnerLogAlarmActionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLogAlarmActionConfigurationFactory, T3, T4, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLogAlarmActionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLogAlarmActionConfigurationFactory, T4, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLogAlarmActionConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLogAlarmActionConfigurationFactory, InnerLogAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLogAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T5, subFactoryAction).T2);
}
