// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class PartitionFactory(string resourceName = null, Action<Humidifier.Glue.Partition> factoryAction = null) : ResourceFactory<Humidifier.Glue.Partition>(resourceName)
{

    internal InnerPartitionPartitionInputFactory PartitionInputFactory { get; set; }

    protected override Humidifier.Glue.Partition Create()
    {
        var partitionResult = CreatePartition();
        factoryAction?.Invoke(partitionResult);

        return partitionResult;
    }

    private Humidifier.Glue.Partition CreatePartition()
    {
        var partitionResult = new Humidifier.Glue.Partition
        {
            GivenName = InputResourceName,
        };

        return partitionResult;
    }
    public override void CreateChildren(Humidifier.Glue.Partition result)
    {
        base.CreateChildren(result);

        result.PartitionInput ??= PartitionInputFactory?.Build();
    }

} // End Of Class

public static class PartitionFactoryExtensions
{
    public static CombinedResult<PartitionFactory, InnerPartitionPartitionInputFactory> WithPartitionInput(this PartitionFactory parentFactory, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null)
    {
        parentFactory.PartitionInputFactory = new InnerPartitionPartitionInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PartitionInputFactory);
    }

    public static CombinedResult<PartitionFactory, T1, InnerPartitionPartitionInputFactory> WithPartitionInput<T1>(this CombinedResult<PartitionFactory, T1> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithPartitionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartitionFactory, InnerPartitionPartitionInputFactory> WithPartitionInput<T1>(this CombinedResult<T1, PartitionFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithPartitionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PartitionFactory, T1, T2, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2>(this CombinedResult<PartitionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartitionFactory, T2, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2>(this CombinedResult<T1, PartitionFactory, T2> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartitionFactory, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2>(this CombinedResult<T1, T2, PartitionFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PartitionFactory, T1, T2, T3, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3>(this CombinedResult<PartitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartitionFactory, T2, T3, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3>(this CombinedResult<T1, PartitionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartitionFactory, T3, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3>(this CombinedResult<T1, T2, PartitionFactory, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartitionFactory, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, PartitionFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PartitionFactory, T1, T2, T3, T4, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3, T4>(this CombinedResult<PartitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartitionFactory, T2, T3, T4, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3, T4>(this CombinedResult<T1, PartitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartitionFactory, T3, T4, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, PartitionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartitionFactory, T4, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PartitionFactory, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PartitionFactory, InnerPartitionPartitionInputFactory> WithPartitionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PartitionFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.PartitionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionInput(combinedResult.T5, subFactoryAction));
}
