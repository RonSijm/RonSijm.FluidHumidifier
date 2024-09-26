// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerPartitionSchemaReferenceFactory(Action<Humidifier.Glue.PartitionTypes.SchemaReference> factoryAction = null) : SubResourceFactory<Humidifier.Glue.PartitionTypes.SchemaReference>
{

    internal InnerPartitionSchemaIdFactory SchemaIdFactory { get; set; }

    protected override Humidifier.Glue.PartitionTypes.SchemaReference Create()
    {
        var schemaReferenceResult = CreateSchemaReference();
        factoryAction?.Invoke(schemaReferenceResult);

        return schemaReferenceResult;
    }

    private Humidifier.Glue.PartitionTypes.SchemaReference CreateSchemaReference()
    {
        var schemaReferenceResult = new Humidifier.Glue.PartitionTypes.SchemaReference();

        return schemaReferenceResult;
    }
    public override void CreateChildren(Humidifier.Glue.PartitionTypes.SchemaReference result)
    {
        base.CreateChildren(result);

        result.SchemaId ??= SchemaIdFactory?.Build();
    }

} // End Of Class

public static class InnerPartitionSchemaReferenceFactoryExtensions
{
    public static CombinedResult<InnerPartitionSchemaReferenceFactory, InnerPartitionSchemaIdFactory> WithSchemaId(this InnerPartitionSchemaReferenceFactory parentFactory, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null)
    {
        parentFactory.SchemaIdFactory = new InnerPartitionSchemaIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaIdFactory);
    }

    public static CombinedResult<InnerPartitionSchemaReferenceFactory, T1, InnerPartitionSchemaIdFactory> WithSchemaId<T1>(this CombinedResult<InnerPartitionSchemaReferenceFactory, T1> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionSchemaReferenceFactory, InnerPartitionSchemaIdFactory> WithSchemaId<T1>(this CombinedResult<T1, InnerPartitionSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPartitionSchemaReferenceFactory, T1, T2, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2>(this CombinedResult<InnerPartitionSchemaReferenceFactory, T1, T2> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionSchemaReferenceFactory, T2, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2>(this CombinedResult<T1, InnerPartitionSchemaReferenceFactory, T2> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartitionSchemaReferenceFactory, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2>(this CombinedResult<T1, T2, InnerPartitionSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPartitionSchemaReferenceFactory, T1, T2, T3, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<InnerPartitionSchemaReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionSchemaReferenceFactory, T2, T3, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<T1, InnerPartitionSchemaReferenceFactory, T2, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartitionSchemaReferenceFactory, T3, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<T1, T2, InnerPartitionSchemaReferenceFactory, T3> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartitionSchemaReferenceFactory, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPartitionSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPartitionSchemaReferenceFactory, T1, T2, T3, T4, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<InnerPartitionSchemaReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPartitionSchemaReferenceFactory, T2, T3, T4, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, InnerPartitionSchemaReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPartitionSchemaReferenceFactory, T3, T4, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPartitionSchemaReferenceFactory, T3, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPartitionSchemaReferenceFactory, T4, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPartitionSchemaReferenceFactory, T4> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPartitionSchemaReferenceFactory, InnerPartitionSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPartitionSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.PartitionTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T5, subFactoryAction));
}
