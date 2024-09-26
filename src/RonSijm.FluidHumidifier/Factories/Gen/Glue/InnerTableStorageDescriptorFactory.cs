// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableStorageDescriptorFactory(Action<Humidifier.Glue.TableTypes.StorageDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.StorageDescriptor>
{

    internal InnerTableSerdeInfoFactory SerdeInfoFactory { get; set; }

    internal InnerTableSchemaReferenceFactory SchemaReferenceFactory { get; set; }

    internal InnerTableSkewedInfoFactory SkewedInfoFactory { get; set; }

    protected override Humidifier.Glue.TableTypes.StorageDescriptor Create()
    {
        var storageDescriptorResult = CreateStorageDescriptor();
        factoryAction?.Invoke(storageDescriptorResult);

        return storageDescriptorResult;
    }

    private Humidifier.Glue.TableTypes.StorageDescriptor CreateStorageDescriptor()
    {
        var storageDescriptorResult = new Humidifier.Glue.TableTypes.StorageDescriptor();

        return storageDescriptorResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableTypes.StorageDescriptor result)
    {
        base.CreateChildren(result);

        result.SerdeInfo ??= SerdeInfoFactory?.Build();
        result.SchemaReference ??= SchemaReferenceFactory?.Build();
        result.SkewedInfo ??= SkewedInfoFactory?.Build();
    }

} // End Of Class

public static class InnerTableStorageDescriptorFactoryExtensions
{
    public static CombinedResult<InnerTableStorageDescriptorFactory, InnerTableSerdeInfoFactory> WithSerdeInfo(this InnerTableStorageDescriptorFactory parentFactory, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null)
    {
        parentFactory.SerdeInfoFactory = new InnerTableSerdeInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SerdeInfoFactory);
    }

    public static CombinedResult<InnerTableStorageDescriptorFactory, InnerTableSchemaReferenceFactory> WithSchemaReference(this InnerTableStorageDescriptorFactory parentFactory, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null)
    {
        parentFactory.SchemaReferenceFactory = new InnerTableSchemaReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaReferenceFactory);
    }

    public static CombinedResult<InnerTableStorageDescriptorFactory, InnerTableSkewedInfoFactory> WithSkewedInfo(this InnerTableStorageDescriptorFactory parentFactory, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null)
    {
        parentFactory.SkewedInfoFactory = new InnerTableSkewedInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SkewedInfoFactory);
    }

    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, InnerTableSerdeInfoFactory> WithSerdeInfo<T1>(this CombinedResult<InnerTableStorageDescriptorFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSerdeInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, InnerTableSerdeInfoFactory> WithSerdeInfo<T1>(this CombinedResult<T1, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSerdeInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, T4, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3, T4>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, T4, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, T4, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, T4, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableStorageDescriptorFactory, InnerTableSerdeInfoFactory> WithSerdeInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SerdeInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerdeInfo(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, InnerTableSchemaReferenceFactory> WithSchemaReference<T1>(this CombinedResult<InnerTableStorageDescriptorFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, InnerTableSchemaReferenceFactory> WithSchemaReference<T1>(this CombinedResult<T1, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, T4, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3, T4>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, T4, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, T4, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, T4, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableStorageDescriptorFactory, InnerTableSchemaReferenceFactory> WithSchemaReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaReference(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, InnerTableSkewedInfoFactory> WithSkewedInfo<T1>(this CombinedResult<InnerTableStorageDescriptorFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkewedInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, InnerTableSkewedInfoFactory> WithSkewedInfo<T1>(this CombinedResult<T1, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkewedInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, T4, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3, T4>(this CombinedResult<InnerTableStorageDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, T4, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableStorageDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, T4, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableStorageDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, T4, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableStorageDescriptorFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableStorageDescriptorFactory, InnerTableSkewedInfoFactory> WithSkewedInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableStorageDescriptorFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SkewedInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkewedInfo(combinedResult.T5, subFactoryAction));
}
