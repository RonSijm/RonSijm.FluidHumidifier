// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class CompositeAlarmFactory(string resourceName = null, Action<Humidifier.CloudWatch.CompositeAlarm> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.CompositeAlarm>(resourceName)
{

    internal InnerCompositeAlarmActionConfigurationFactory ActionConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.CompositeAlarm Create()
    {
        var compositeAlarmResult = CreateCompositeAlarm();
        factoryAction?.Invoke(compositeAlarmResult);

        return compositeAlarmResult;
    }

    private Humidifier.CloudWatch.CompositeAlarm CreateCompositeAlarm()
    {
        var compositeAlarmResult = new Humidifier.CloudWatch.CompositeAlarm
        {
            GivenName = InputResourceName,
        };

        return compositeAlarmResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.CompositeAlarm result)
    {
        base.CreateChildren(result);

        result.ActionConfiguration ??= ActionConfigurationFactory?.Build();
    }

} // End Of Class

public static class CompositeAlarmFactoryExtensions
{
    public static CombinedResult<CompositeAlarmFactory, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration(this CompositeAlarmFactory parentFactory, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null)
    {
        parentFactory.ActionConfigurationFactory = new InnerCompositeAlarmActionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionConfigurationFactory);
    }

    public static CombinedResult<CompositeAlarmFactory, T1, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1>(this CombinedResult<CompositeAlarmFactory, T1> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositeAlarmFactory, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1>(this CombinedResult<T1, CompositeAlarmFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CompositeAlarmFactory, T1, T2, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2>(this CombinedResult<CompositeAlarmFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositeAlarmFactory, T2, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2>(this CombinedResult<T1, CompositeAlarmFactory, T2> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositeAlarmFactory, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2>(this CombinedResult<T1, T2, CompositeAlarmFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CompositeAlarmFactory, T1, T2, T3, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3>(this CombinedResult<CompositeAlarmFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositeAlarmFactory, T2, T3, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3>(this CombinedResult<T1, CompositeAlarmFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositeAlarmFactory, T3, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CompositeAlarmFactory, T3> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CompositeAlarmFactory, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CompositeAlarmFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CompositeAlarmFactory, T1, T2, T3, T4, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3, T4>(this CombinedResult<CompositeAlarmFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositeAlarmFactory, T2, T3, T4, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CompositeAlarmFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositeAlarmFactory, T3, T4, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CompositeAlarmFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CompositeAlarmFactory, T4, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CompositeAlarmFactory, T4> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CompositeAlarmFactory, InnerCompositeAlarmActionConfigurationFactory> WithActionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CompositeAlarmFactory> combinedResult, Action<Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
