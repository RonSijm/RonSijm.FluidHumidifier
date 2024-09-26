// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableScalingPolicyFactory(Action<Humidifier.Cassandra.TableTypes.ScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.ScalingPolicy>
{

    internal InnerTableTargetTrackingScalingPolicyConfigurationFactory TargetTrackingScalingPolicyConfigurationFactory { get; set; }

    protected override Humidifier.Cassandra.TableTypes.ScalingPolicy Create()
    {
        var scalingPolicyResult = CreateScalingPolicy();
        factoryAction?.Invoke(scalingPolicyResult);

        return scalingPolicyResult;
    }

    private Humidifier.Cassandra.TableTypes.ScalingPolicy CreateScalingPolicy()
    {
        var scalingPolicyResult = new Humidifier.Cassandra.TableTypes.ScalingPolicy();

        return scalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.TableTypes.ScalingPolicy result)
    {
        base.CreateChildren(result);

        result.TargetTrackingScalingPolicyConfiguration ??= TargetTrackingScalingPolicyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTableScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerTableScalingPolicyFactory, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration(this InnerTableScalingPolicyFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null)
    {
        parentFactory.TargetTrackingScalingPolicyConfigurationFactory = new InnerTableTargetTrackingScalingPolicyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetTrackingScalingPolicyConfigurationFactory);
    }

    public static CombinedResult<InnerTableScalingPolicyFactory, T1, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1>(this CombinedResult<InnerTableScalingPolicyFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableScalingPolicyFactory, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1>(this CombinedResult<T1, InnerTableScalingPolicyFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableScalingPolicyFactory, T1, T2, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2>(this CombinedResult<InnerTableScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableScalingPolicyFactory, T2, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2>(this CombinedResult<T1, InnerTableScalingPolicyFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableScalingPolicyFactory, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTableScalingPolicyFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableScalingPolicyFactory, T1, T2, T3, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<InnerTableScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableScalingPolicyFactory, T2, T3, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTableScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableScalingPolicyFactory, T3, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableScalingPolicyFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableScalingPolicyFactory, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableScalingPolicyFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableScalingPolicyFactory, T1, T2, T3, T4, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTableScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableScalingPolicyFactory, T2, T3, T4, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableScalingPolicyFactory, T3, T4, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableScalingPolicyFactory, T4, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableScalingPolicyFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableScalingPolicyFactory, InnerTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableScalingPolicyFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T5, subFactoryAction));
}
