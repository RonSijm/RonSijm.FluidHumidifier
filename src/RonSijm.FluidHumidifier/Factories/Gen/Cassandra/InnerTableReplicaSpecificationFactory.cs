// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableReplicaSpecificationFactory(Action<Humidifier.Cassandra.TableTypes.ReplicaSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.ReplicaSpecification>
{

    internal InnerTableAutoScalingSettingFactory ReadCapacityAutoScalingFactory { get; set; }

    protected override Humidifier.Cassandra.TableTypes.ReplicaSpecification Create()
    {
        var replicaSpecificationResult = CreateReplicaSpecification();
        factoryAction?.Invoke(replicaSpecificationResult);

        return replicaSpecificationResult;
    }

    private Humidifier.Cassandra.TableTypes.ReplicaSpecification CreateReplicaSpecification()
    {
        var replicaSpecificationResult = new Humidifier.Cassandra.TableTypes.ReplicaSpecification();

        return replicaSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.TableTypes.ReplicaSpecification result)
    {
        base.CreateChildren(result);

        result.ReadCapacityAutoScaling ??= ReadCapacityAutoScalingFactory?.Build();
    }

} // End Of Class

public static class InnerTableReplicaSpecificationFactoryExtensions
{
    public static CombinedResult<InnerTableReplicaSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling(this InnerTableReplicaSpecificationFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null)
    {
        parentFactory.ReadCapacityAutoScalingFactory = new InnerTableAutoScalingSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReadCapacityAutoScalingFactory);
    }

    public static CombinedResult<InnerTableReplicaSpecificationFactory, T1, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1>(this CombinedResult<InnerTableReplicaSpecificationFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableReplicaSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1>(this CombinedResult<T1, InnerTableReplicaSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableReplicaSpecificationFactory, T1, T2, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2>(this CombinedResult<InnerTableReplicaSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableReplicaSpecificationFactory, T2, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2>(this CombinedResult<T1, InnerTableReplicaSpecificationFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableReplicaSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2>(this CombinedResult<T1, T2, InnerTableReplicaSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableReplicaSpecificationFactory, T1, T2, T3, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<InnerTableReplicaSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableReplicaSpecificationFactory, T2, T3, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, InnerTableReplicaSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableReplicaSpecificationFactory, T3, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableReplicaSpecificationFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableReplicaSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableReplicaSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableReplicaSpecificationFactory, T1, T2, T3, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<InnerTableReplicaSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableReplicaSpecificationFactory, T2, T3, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableReplicaSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableReplicaSpecificationFactory, T3, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableReplicaSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableReplicaSpecificationFactory, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableReplicaSpecificationFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableReplicaSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableReplicaSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T5, subFactoryAction));
}
