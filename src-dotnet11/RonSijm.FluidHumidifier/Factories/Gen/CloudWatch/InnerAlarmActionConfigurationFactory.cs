// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmActionConfigurationFactory(Action<Humidifier.CloudWatch.AlarmTypes.ActionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.ActionConfiguration>
{

    internal InnerAlarmAlarmTagsPropagationFactory AlarmTagsPropagationFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmTypes.ActionConfiguration Create()
    {
        var actionConfigurationResult = CreateActionConfiguration();
        factoryAction?.Invoke(actionConfigurationResult);

        return actionConfigurationResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.ActionConfiguration CreateActionConfiguration()
    {
        var actionConfigurationResult = new Humidifier.CloudWatch.AlarmTypes.ActionConfiguration();

        return actionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmTypes.ActionConfiguration result)
    {
        base.CreateChildren(result);

        result.AlarmTagsPropagation ??= AlarmTagsPropagationFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmActionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAlarmActionConfigurationFactory, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation(this InnerAlarmActionConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null)
    {
        parentFactory.AlarmTagsPropagationFactory = new InnerAlarmAlarmTagsPropagationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmTagsPropagationFactory);
    }

    public static CombinedResult<InnerAlarmActionConfigurationFactory, T1, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1>(this CombinedResult<InnerAlarmActionConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmActionConfigurationFactory, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1>(this CombinedResult<T1, InnerAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmActionConfigurationFactory, T1, T2, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<InnerAlarmActionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmActionConfigurationFactory, T2, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<T1, InnerAlarmActionConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmActionConfigurationFactory, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<T1, T2, InnerAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmActionConfigurationFactory, T1, T2, T3, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<InnerAlarmActionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmActionConfigurationFactory, T2, T3, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, InnerAlarmActionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmActionConfigurationFactory, T3, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmActionConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmActionConfigurationFactory, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmActionConfigurationFactory, T1, T2, T3, T4, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<InnerAlarmActionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmActionConfigurationFactory, T2, T3, T4, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmActionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmActionConfigurationFactory, T3, T4, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmActionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmActionConfigurationFactory, T4, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmActionConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmActionConfigurationFactory, InnerAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T5, subFactoryAction).T2);
}
