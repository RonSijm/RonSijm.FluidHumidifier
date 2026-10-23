// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerCompositeAlarmActionConfigurationFactory(Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration>
{

    internal InnerCompositeAlarmAlarmTagsPropagationFactory AlarmTagsPropagationFactory { get; set; }

    protected override Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration Create()
    {
        var actionConfigurationResult = CreateActionConfiguration();
        factoryAction?.Invoke(actionConfigurationResult);

        return actionConfigurationResult;
    }

    private Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration CreateActionConfiguration()
    {
        var actionConfigurationResult = new Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration();

        return actionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration result)
    {
        base.CreateChildren(result);

        result.AlarmTagsPropagation ??= AlarmTagsPropagationFactory?.Build();
    }

} // End Of Class

public static class InnerCompositeAlarmActionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCompositeAlarmActionConfigurationFactory, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation(this InnerCompositeAlarmActionConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null)
    {
        parentFactory.AlarmTagsPropagationFactory = new InnerCompositeAlarmAlarmTagsPropagationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmTagsPropagationFactory);
    }

    public static CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1>(this CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1>(this CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, T2, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, T2, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositeAlarmActionConfigurationFactory, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2>(this CombinedResult<T1, T2, InnerCompositeAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, T2, T3, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, T2, T3, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositeAlarmActionConfigurationFactory, T3, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositeAlarmActionConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositeAlarmActionConfigurationFactory, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositeAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, T2, T3, T4, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<InnerCompositeAlarmActionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, T2, T3, T4, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositeAlarmActionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositeAlarmActionConfigurationFactory, T3, T4, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositeAlarmActionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositeAlarmActionConfigurationFactory, T4, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositeAlarmActionConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositeAlarmActionConfigurationFactory, InnerCompositeAlarmAlarmTagsPropagationFactory> WithAlarmTagsPropagation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositeAlarmActionConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmTagsPropagation(combinedResult.T5, subFactoryAction).T2);
}
