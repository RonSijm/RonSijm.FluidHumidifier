// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableAutoScalingSettingFactory(Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.AutoScalingSetting>
{

    internal InnerTableScalingPolicyFactory ScalingPolicyFactory { get; set; }

    protected override Humidifier.Cassandra.TableTypes.AutoScalingSetting Create()
    {
        var autoScalingSettingResult = CreateAutoScalingSetting();
        factoryAction?.Invoke(autoScalingSettingResult);

        return autoScalingSettingResult;
    }

    private Humidifier.Cassandra.TableTypes.AutoScalingSetting CreateAutoScalingSetting()
    {
        var autoScalingSettingResult = new Humidifier.Cassandra.TableTypes.AutoScalingSetting();

        return autoScalingSettingResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.TableTypes.AutoScalingSetting result)
    {
        base.CreateChildren(result);

        result.ScalingPolicy ??= ScalingPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerTableAutoScalingSettingFactoryExtensions
{
    public static CombinedResult<InnerTableAutoScalingSettingFactory, InnerTableScalingPolicyFactory> WithScalingPolicy(this InnerTableAutoScalingSettingFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null)
    {
        parentFactory.ScalingPolicyFactory = new InnerTableScalingPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScalingPolicyFactory);
    }

    public static CombinedResult<InnerTableAutoScalingSettingFactory, T1, InnerTableScalingPolicyFactory> WithScalingPolicy<T1>(this CombinedResult<InnerTableAutoScalingSettingFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScalingPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSettingFactory, InnerTableScalingPolicyFactory> WithScalingPolicy<T1>(this CombinedResult<T1, InnerTableAutoScalingSettingFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScalingPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSettingFactory, T1, T2, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2>(this CombinedResult<InnerTableAutoScalingSettingFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSettingFactory, T2, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2>(this CombinedResult<T1, InnerTableAutoScalingSettingFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSettingFactory, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2>(this CombinedResult<T1, T2, InnerTableAutoScalingSettingFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSettingFactory, T1, T2, T3, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3>(this CombinedResult<InnerTableAutoScalingSettingFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSettingFactory, T2, T3, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3>(this CombinedResult<T1, InnerTableAutoScalingSettingFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSettingFactory, T3, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableAutoScalingSettingFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableAutoScalingSettingFactory, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableAutoScalingSettingFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSettingFactory, T1, T2, T3, T4, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3, T4>(this CombinedResult<InnerTableAutoScalingSettingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSettingFactory, T2, T3, T4, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableAutoScalingSettingFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSettingFactory, T3, T4, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableAutoScalingSettingFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableAutoScalingSettingFactory, T4, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableAutoScalingSettingFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableAutoScalingSettingFactory, InnerTableScalingPolicyFactory> WithScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableAutoScalingSettingFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalingPolicy(combinedResult.T5, subFactoryAction));
}
