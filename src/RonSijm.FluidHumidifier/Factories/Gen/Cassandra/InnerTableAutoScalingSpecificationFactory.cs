// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableAutoScalingSpecificationFactory(Action<Humidifier.Cassandra.TableTypes.AutoScalingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.AutoScalingSpecification>
{

    internal InnerTableAutoScalingSettingFactory ReadCapacityAutoScalingFactory { get; set; }

    internal InnerTableAutoScalingSettingFactory WriteCapacityAutoScalingFactory { get; set; }

    protected override Humidifier.Cassandra.TableTypes.AutoScalingSpecification Create()
    {
        var autoScalingSpecificationResult = CreateAutoScalingSpecification();
        factoryAction?.Invoke(autoScalingSpecificationResult);

        return autoScalingSpecificationResult;
    }

    private Humidifier.Cassandra.TableTypes.AutoScalingSpecification CreateAutoScalingSpecification()
    {
        var autoScalingSpecificationResult = new Humidifier.Cassandra.TableTypes.AutoScalingSpecification();

        return autoScalingSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.TableTypes.AutoScalingSpecification result)
    {
        base.CreateChildren(result);

        result.ReadCapacityAutoScaling ??= ReadCapacityAutoScalingFactory?.Build();
        result.WriteCapacityAutoScaling ??= WriteCapacityAutoScalingFactory?.Build();
    }

} // End Of Class

public static class InnerTableAutoScalingSpecificationFactoryExtensions
{
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling(this InnerTableAutoScalingSpecificationFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null)
    {
        parentFactory.ReadCapacityAutoScalingFactory = new InnerTableAutoScalingSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReadCapacityAutoScalingFactory);
    }

    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling(this InnerTableAutoScalingSpecificationFactory parentFactory, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null)
    {
        parentFactory.WriteCapacityAutoScalingFactory = new InnerTableAutoScalingSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WriteCapacityAutoScalingFactory);
    }

    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2>(this CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory, T4, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithReadCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScaling(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2>(this CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3, T4, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<InnerTableAutoScalingSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3, T4, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableAutoScalingSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3, T4, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableAutoScalingSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory, T4, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableAutoScalingSpecificationFactory, T4> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableAutoScalingSpecificationFactory, InnerTableAutoScalingSettingFactory> WithWriteCapacityAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableAutoScalingSpecificationFactory> combinedResult, Action<Humidifier.Cassandra.TableTypes.AutoScalingSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScaling(combinedResult.T5, subFactoryAction));
}
