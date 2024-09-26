// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableLocalSecondaryIndexFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex>
{

    internal InnerGlobalTableProjectionFactory ProjectionFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex Create()
    {
        var localSecondaryIndexResult = CreateLocalSecondaryIndex();
        factoryAction?.Invoke(localSecondaryIndexResult);

        return localSecondaryIndexResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex CreateLocalSecondaryIndex()
    {
        var localSecondaryIndexResult = new Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex();

        return localSecondaryIndexResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.LocalSecondaryIndex result)
    {
        base.CreateChildren(result);

        result.Projection ??= ProjectionFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableLocalSecondaryIndexFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection(this InnerGlobalTableLocalSecondaryIndexFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null)
    {
        parentFactory.ProjectionFactory = new InnerGlobalTableProjectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectionFactory);
    }

    public static CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, InnerGlobalTableProjectionFactory> WithProjection<T1>(this CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1>(this CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, T2, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, T2, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableLocalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, T2, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, T2, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableLocalSecondaryIndexFactory, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableLocalSecondaryIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableLocalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, T2, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableLocalSecondaryIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, T2, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableLocalSecondaryIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableLocalSecondaryIndexFactory, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableLocalSecondaryIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableLocalSecondaryIndexFactory, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableLocalSecondaryIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableLocalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T5, subFactoryAction));
}
