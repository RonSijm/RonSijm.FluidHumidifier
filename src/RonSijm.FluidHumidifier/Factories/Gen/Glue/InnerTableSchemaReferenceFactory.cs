// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableSchemaReferenceFactory(Action<Humidifier.Glue.TableTypes.SchemaReference> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.SchemaReference>
{

    internal InnerTableSchemaIdFactory SchemaIdFactory { get; set; }

    protected override Humidifier.Glue.TableTypes.SchemaReference Create()
    {
        var schemaReferenceResult = CreateSchemaReference();
        factoryAction?.Invoke(schemaReferenceResult);

        return schemaReferenceResult;
    }

    private Humidifier.Glue.TableTypes.SchemaReference CreateSchemaReference()
    {
        var schemaReferenceResult = new Humidifier.Glue.TableTypes.SchemaReference();

        return schemaReferenceResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableTypes.SchemaReference result)
    {
        base.CreateChildren(result);

        result.SchemaId ??= SchemaIdFactory?.Build();
    }

} // End Of Class

public static class InnerTableSchemaReferenceFactoryExtensions
{
    public static CombinedResult<InnerTableSchemaReferenceFactory, InnerTableSchemaIdFactory> WithSchemaId(this InnerTableSchemaReferenceFactory parentFactory, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null)
    {
        parentFactory.SchemaIdFactory = new InnerTableSchemaIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaIdFactory);
    }

    public static CombinedResult<InnerTableSchemaReferenceFactory, T1, InnerTableSchemaIdFactory> WithSchemaId<T1>(this CombinedResult<InnerTableSchemaReferenceFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableSchemaReferenceFactory, InnerTableSchemaIdFactory> WithSchemaId<T1>(this CombinedResult<T1, InnerTableSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableSchemaReferenceFactory, T1, T2, InnerTableSchemaIdFactory> WithSchemaId<T1, T2>(this CombinedResult<InnerTableSchemaReferenceFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableSchemaReferenceFactory, T2, InnerTableSchemaIdFactory> WithSchemaId<T1, T2>(this CombinedResult<T1, InnerTableSchemaReferenceFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableSchemaReferenceFactory, InnerTableSchemaIdFactory> WithSchemaId<T1, T2>(this CombinedResult<T1, T2, InnerTableSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableSchemaReferenceFactory, T1, T2, T3, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<InnerTableSchemaReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableSchemaReferenceFactory, T2, T3, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<T1, InnerTableSchemaReferenceFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableSchemaReferenceFactory, T3, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableSchemaReferenceFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableSchemaReferenceFactory, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableSchemaReferenceFactory, T1, T2, T3, T4, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<InnerTableSchemaReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableSchemaReferenceFactory, T2, T3, T4, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableSchemaReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableSchemaReferenceFactory, T3, T4, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableSchemaReferenceFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableSchemaReferenceFactory, T4, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableSchemaReferenceFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableSchemaReferenceFactory, InnerTableSchemaIdFactory> WithSchemaId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableSchemaReferenceFactory> combinedResult, Action<Humidifier.Glue.TableTypes.SchemaId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaId(combinedResult.T5, subFactoryAction));
}
