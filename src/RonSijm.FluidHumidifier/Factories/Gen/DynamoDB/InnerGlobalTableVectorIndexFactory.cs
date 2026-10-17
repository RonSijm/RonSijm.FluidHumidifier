// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableVectorIndexFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.VectorIndex> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.VectorIndex>
{

    internal InnerGlobalTableVectorAttributeFactory VectorAttributeFactory { get; set; }

    internal InnerGlobalTableProjectionFactory ProjectionFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.VectorIndex Create()
    {
        var vectorIndexResult = CreateVectorIndex();
        factoryAction?.Invoke(vectorIndexResult);

        return vectorIndexResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.VectorIndex CreateVectorIndex()
    {
        var vectorIndexResult = new Humidifier.DynamoDB.GlobalTableTypes.VectorIndex();

        return vectorIndexResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.VectorIndex result)
    {
        base.CreateChildren(result);

        result.VectorAttribute ??= VectorAttributeFactory?.Build();
        result.Projection ??= ProjectionFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableVectorIndexFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute(this InnerGlobalTableVectorIndexFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null)
    {
        parentFactory.VectorAttributeFactory = new InnerGlobalTableVectorAttributeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VectorAttributeFactory);
    }

    public static CombinedResult<InnerGlobalTableVectorIndexFactory, InnerGlobalTableProjectionFactory> WithProjection(this InnerGlobalTableVectorIndexFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null)
    {
        parentFactory.ProjectionFactory = new InnerGlobalTableProjectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectionFactory);
    }

    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3, T4, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3, T4, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3, T4, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory, T4, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableVectorIndexFactory, InnerGlobalTableVectorAttributeFactory> WithVectorAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.VectorAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorAttribute(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, InnerGlobalTableProjectionFactory> WithProjection<T1>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableVectorIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableVectorIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableVectorIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableVectorIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableVectorIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableVectorIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T5, subFactoryAction).T2);
}
