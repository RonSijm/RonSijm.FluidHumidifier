// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerPartitionPartitionInputFactory(Action<Humidifier.Glue.PartitionTypes.PartitionInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.PartitionTypes.PartitionInput>
{

    internal InnerPartitionStorageDescriptorFactory StorageDescriptorFactory { get; set; }

    protected override Humidifier.Glue.PartitionTypes.PartitionInput Create()
    {
        var partitionInputResult = CreatePartitionInput();
        factoryAction?.Invoke(partitionInputResult);

        return partitionInputResult;
    }

    private Humidifier.Glue.PartitionTypes.PartitionInput CreatePartitionInput()
    {
        var partitionInputResult = new Humidifier.Glue.PartitionTypes.PartitionInput();

        return partitionInputResult;
    }
    public override void CreateChildren(Humidifier.Glue.PartitionTypes.PartitionInput result)
    {
        base.CreateChildren(result);

        result.StorageDescriptor ??= StorageDescriptorFactory?.Build();
    }

} // End Of Class

public static class InnerPartitionPartitionInputFactoryExtensions
{
    public static CombinedResult<InnerPartitionPartitionInputFactory, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor(this InnerPartitionPartitionInputFactory parentFactory, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null)
    {
        parentFactory.StorageDescriptorFactory = new InnerPartitionStorageDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageDescriptorFactory);
    }

    public static CombinedResult<InnerPartitionPartitionInputFactory, T1, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1>(this CombinedResult<InnerPartitionPartitionInputFactory, T1> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionPartitionInputFactory, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1>(this CombinedResult<T1, InnerPartitionPartitionInputFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPartitionPartitionInputFactory, T1, T2, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2>(this CombinedResult<InnerPartitionPartitionInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionPartitionInputFactory, T2, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2>(this CombinedResult<T1, InnerPartitionPartitionInputFactory, T2> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartitionPartitionInputFactory, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2>(this CombinedResult<T1, T2, InnerPartitionPartitionInputFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPartitionPartitionInputFactory, T1, T2, T3, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<InnerPartitionPartitionInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionPartitionInputFactory, T2, T3, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<T1, InnerPartitionPartitionInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartitionPartitionInputFactory, T3, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartitionPartitionInputFactory, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartitionPartitionInputFactory, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartitionPartitionInputFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPartitionPartitionInputFactory, T1, T2, T3, T4, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<InnerPartitionPartitionInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionPartitionInputFactory, T2, T3, T4, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartitionPartitionInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartitionPartitionInputFactory, T3, T4, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartitionPartitionInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartitionPartitionInputFactory, T4, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartitionPartitionInputFactory, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPartitionPartitionInputFactory, InnerPartitionStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartitionPartitionInputFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T5, subFactoryAction));
}
