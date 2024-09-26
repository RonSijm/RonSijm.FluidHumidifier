// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableWriteProvisionedThroughputSettingsFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings>
{

    internal InnerGlobalTableCapacityAutoScalingSettingsFactory WriteCapacityAutoScalingSettingsFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings Create()
    {
        var writeProvisionedThroughputSettingsResult = CreateWriteProvisionedThroughputSettings();
        factoryAction?.Invoke(writeProvisionedThroughputSettingsResult);

        return writeProvisionedThroughputSettingsResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings CreateWriteProvisionedThroughputSettings()
    {
        var writeProvisionedThroughputSettingsResult = new Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings();

        return writeProvisionedThroughputSettingsResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.WriteProvisionedThroughputSettings result)
    {
        base.CreateChildren(result);

        result.WriteCapacityAutoScalingSettings ??= WriteCapacityAutoScalingSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableWriteProvisionedThroughputSettingsFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings(this InnerGlobalTableWriteProvisionedThroughputSettingsFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null)
    {
        parentFactory.WriteCapacityAutoScalingSettingsFactory = new InnerGlobalTableCapacityAutoScalingSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WriteCapacityAutoScalingSettingsFactory);
    }

    public static CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1>(this CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1>(this CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2>(this CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2>(this CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, T2, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T2, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableWriteProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithWriteCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableWriteProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWriteCapacityAutoScalingSettings(combinedResult.T5, subFactoryAction));
}
