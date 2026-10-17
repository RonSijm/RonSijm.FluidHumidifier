// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableVectorIndexFactory(Action<Humidifier.DynamoDB.TableTypes.VectorIndex> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.VectorIndex>
{

    internal InnerTableVectorAttributeFactory VectorAttributeFactory { get; set; }

    internal InnerTableProjectionFactory ProjectionFactory { get; set; }

    protected override Humidifier.DynamoDB.TableTypes.VectorIndex Create()
    {
        var vectorIndexResult = CreateVectorIndex();
        factoryAction?.Invoke(vectorIndexResult);

        return vectorIndexResult;
    }

    private Humidifier.DynamoDB.TableTypes.VectorIndex CreateVectorIndex()
    {
        var vectorIndexResult = new Humidifier.DynamoDB.TableTypes.VectorIndex();

        return vectorIndexResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.TableTypes.VectorIndex result)
    {
        base.CreateChildren(result);

        result.VectorAttribute ??= VectorAttributeFactory?.Build();
        result.Projection ??= ProjectionFactory?.Build();
    }

} // End Of Class

public static class InnerTableVectorIndexFactoryExtensions
{
    public static CombinedResult<InnerTableVectorIndexFactory, InnerTableVectorAttributeFactory> WithVectorAttribute(this InnerTableVectorIndexFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null)
    {
        parentFactory.VectorAttributeFactory = new InnerTableVectorAttributeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VectorAttributeFactory);
    }

    public static CombinedResult<InnerTableVectorIndexFactory, InnerTableProjectionFactory> WithProjection(this InnerTableVectorIndexFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null)
    {
        parentFactory.ProjectionFactory = new InnerTableProjectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectionFactory);
    }

    public static CombinedResult<InnerTableVectorIndexFactory, T1, InnerTableVectorAttributeFactory> WithVectorAttribute<T1>(this CombinedResult<InnerTableVectorIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, InnerTableVectorAttributeFactory> WithVectorAttribute<T1>(this CombinedResult<T1, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, T2, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2>(this CombinedResult<InnerTableVectorIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, T2, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2>(this CombinedResult<T1, InnerTableVectorIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableVectorIndexFactory, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2>(this CombinedResult<T1, T2, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3, T4, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3, T4, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3, T4, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory, T4, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTableVectorIndexFactory, InnerTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, InnerTableProjectionFactory> WithProjection<T1>(this CombinedResult<InnerTableVectorIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, InnerTableProjectionFactory> WithProjection<T1>(this CombinedResult<T1, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, T2, InnerTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<InnerTableVectorIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, T2, InnerTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, InnerTableVectorIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableVectorIndexFactory, InnerTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, T2, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<InnerTableVectorIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableVectorIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableVectorIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableVectorIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTableVectorIndexFactory, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T5, subFactoryAction).T2);
}
