// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableTableInputFactory(Action<Humidifier.Glue.TableTypes.TableInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.TableInput>
{

    internal InnerTableStorageDescriptorFactory StorageDescriptorFactory { get; set; }

    internal InnerTableTableIdentifierFactory TargetTableFactory { get; set; }

    protected override Humidifier.Glue.TableTypes.TableInput Create()
    {
        var tableInputResult = CreateTableInput();
        factoryAction?.Invoke(tableInputResult);

        return tableInputResult;
    }

    private Humidifier.Glue.TableTypes.TableInput CreateTableInput()
    {
        var tableInputResult = new Humidifier.Glue.TableTypes.TableInput();

        return tableInputResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableTypes.TableInput result)
    {
        base.CreateChildren(result);

        result.StorageDescriptor ??= StorageDescriptorFactory?.Build();
        result.TargetTable ??= TargetTableFactory?.Build();
    }

} // End Of Class

public static class InnerTableTableInputFactoryExtensions
{
    public static CombinedResult<InnerTableTableInputFactory, InnerTableStorageDescriptorFactory> WithStorageDescriptor(this InnerTableTableInputFactory parentFactory, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null)
    {
        parentFactory.StorageDescriptorFactory = new InnerTableStorageDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageDescriptorFactory);
    }

    public static CombinedResult<InnerTableTableInputFactory, InnerTableTableIdentifierFactory> WithTargetTable(this InnerTableTableInputFactory parentFactory, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null)
    {
        parentFactory.TargetTableFactory = new InnerTableTableIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetTableFactory);
    }

    public static CombinedResult<InnerTableTableInputFactory, T1, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1>(this CombinedResult<InnerTableTableInputFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1>(this CombinedResult<T1, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, T2, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2>(this CombinedResult<InnerTableTableInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, T2, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2>(this CombinedResult<T1, InnerTableTableInputFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableTableInputFactory, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2>(this CombinedResult<T1, T2, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, T2, T3, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<InnerTableTableInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, T2, T3, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<T1, InnerTableTableInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableTableInputFactory, T3, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableTableInputFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableTableInputFactory, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, T2, T3, T4, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<InnerTableTableInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, T2, T3, T4, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableTableInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableTableInputFactory, T3, T4, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableTableInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableTableInputFactory, T4, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableTableInputFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableTableInputFactory, InnerTableStorageDescriptorFactory> WithStorageDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.StorageDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageDescriptor(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, InnerTableTableIdentifierFactory> WithTargetTable<T1>(this CombinedResult<InnerTableTableInputFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, InnerTableTableIdentifierFactory> WithTargetTable<T1>(this CombinedResult<T1, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, T2, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2>(this CombinedResult<InnerTableTableInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, T2, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2>(this CombinedResult<T1, InnerTableTableInputFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableTableInputFactory, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2>(this CombinedResult<T1, T2, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, T2, T3, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<InnerTableTableInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, T2, T3, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<T1, InnerTableTableInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableTableInputFactory, T3, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableTableInputFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableTableInputFactory, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableTableInputFactory, T1, T2, T3, T4, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<InnerTableTableInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableTableInputFactory, T2, T3, T4, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableTableInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableTableInputFactory, T3, T4, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableTableInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableTableInputFactory, T4, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableTableInputFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableTableInputFactory, InnerTableTableIdentifierFactory> WithTargetTable<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableTableInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTable(combinedResult.T5, subFactoryAction));
}
