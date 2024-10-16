// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableGlobalSecondaryIndexFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex>
{

    internal InnerGlobalTableProjectionFactory ProjectionFactory { get; set; }

    internal InnerGlobalTableWriteProvisionedThroughputSettingsFactory WriteProvisionedThroughputSettingsFactory { get; set; }

    internal InnerGlobalTableWriteOnDemandThroughputSettingsFactory WriteOnDemandThroughputSettingsFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex Create()
    {
        var globalSecondaryIndexResult = CreateGlobalSecondaryIndex();
        factoryAction?.Invoke(globalSecondaryIndexResult);

        return globalSecondaryIndexResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex CreateGlobalSecondaryIndex()
    {
        var globalSecondaryIndexResult = new Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex();

        return globalSecondaryIndexResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.GlobalSecondaryIndex result)
    {
        base.CreateChildren(result);

        result.Projection ??= ProjectionFactory?.Build();
        result.WriteProvisionedThroughputSettings ??= WriteProvisionedThroughputSettingsFactory?.Build();
        result.WriteOnDemandThroughputSettings ??= WriteOnDemandThroughputSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableGlobalSecondaryIndexFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection(this InnerGlobalTableGlobalSecondaryIndexFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null)
    {
        parentFactory.ProjectionFactory = new InnerGlobalTableProjectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectionFactory);
    }

    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings(this InnerGlobalTableGlobalSecondaryIndexFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null)
    {
        parentFactory.WriteProvisionedThroughputSettingsFactory = new InnerGlobalTableWriteProvisionedThroughputSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WriteProvisionedThroughputSettingsFactory);
    }

    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings(this InnerGlobalTableGlobalSecondaryIndexFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null)
    {
        parentFactory.WriteOnDemandThroughputSettingsFactory = new InnerGlobalTableWriteOnDemandThroughputSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WriteOnDemandThroughputSettingsFactory);
    }

    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, InnerGlobalTableProjectionFactory> WithProjection<T1>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, T4, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableProjectionFactory> WithProjection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.Projection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjection(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, T4, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, T4, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, T4, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, T4, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> WithWriteProvisionedThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteProvisionedThroughputSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, T4, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableGlobalSecondaryIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, T4, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableGlobalSecondaryIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, T4, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableGlobalSecondaryIndexFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, T4, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableGlobalSecondaryIndexFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableGlobalSecondaryIndexFactory, InnerGlobalTableWriteOnDemandThroughputSettingsFactory> WithWriteOnDemandThroughputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableGlobalSecondaryIndexFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteOnDemandThroughputSettings(combinedResult.T5, subFactoryAction));
}
