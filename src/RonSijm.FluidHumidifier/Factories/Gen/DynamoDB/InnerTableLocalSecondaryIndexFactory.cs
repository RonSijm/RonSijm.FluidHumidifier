// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableLocalSecondaryIndexFactory(Action<Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex>
{

    internal InnerTableProjectionFactory ProjectionFactory { get; set; }

    protected override Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex Create()
    {
        var localSecondaryIndexResult = CreateLocalSecondaryIndex();
        factoryAction?.Invoke(localSecondaryIndexResult);

        return localSecondaryIndexResult;
    }

    private Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex CreateLocalSecondaryIndex()
    {
        var localSecondaryIndexResult = new Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex();

        return localSecondaryIndexResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.TableTypes.LocalSecondaryIndex result)
    {
        base.CreateChildren(result);

        result.Projection ??= ProjectionFactory?.Build();
    }

} // End Of Class

public static class InnerTableLocalSecondaryIndexFactoryExtensions
{
    public static CombinedResult<InnerTableLocalSecondaryIndexFactory, InnerTableProjectionFactory> WithProjection(this InnerTableLocalSecondaryIndexFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null)
    {
        parentFactory.ProjectionFactory = new InnerTableProjectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectionFactory);
    }

    public static CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, InnerTableProjectionFactory> WithProjection<T1>(this CombinedResult<InnerTableLocalSecondaryIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, InnerTableProjectionFactory> WithProjection<T1>(this CombinedResult<T1, InnerTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, T2, InnerTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, T2, InnerTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableLocalSecondaryIndexFactory, InnerTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, T2, InnerTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, T2, T3, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, T2, T3, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableLocalSecondaryIndexFactory, T3, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableLocalSecondaryIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableLocalSecondaryIndexFactory, InnerTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, T2, T3, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<InnerTableLocalSecondaryIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, T2, T3, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableLocalSecondaryIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableLocalSecondaryIndexFactory, T3, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableLocalSecondaryIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableLocalSecondaryIndexFactory, T4, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableLocalSecondaryIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableLocalSecondaryIndexFactory, InnerTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableLocalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T5, subFactoryAction));
}
