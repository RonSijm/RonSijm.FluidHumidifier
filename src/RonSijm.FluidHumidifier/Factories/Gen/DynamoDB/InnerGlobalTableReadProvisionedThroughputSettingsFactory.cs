// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableReadProvisionedThroughputSettingsFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings>
{

    internal InnerGlobalTableCapacityAutoScalingSettingsFactory ReadCapacityAutoScalingSettingsFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings Create()
    {
        var readProvisionedThroughputSettingsResult = CreateReadProvisionedThroughputSettings();
        factoryAction?.Invoke(readProvisionedThroughputSettingsResult);

        return readProvisionedThroughputSettingsResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings CreateReadProvisionedThroughputSettings()
    {
        var readProvisionedThroughputSettingsResult = new Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings();

        return readProvisionedThroughputSettingsResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.ReadProvisionedThroughputSettings result)
    {
        base.CreateChildren(result);

        result.ReadCapacityAutoScalingSettings ??= ReadCapacityAutoScalingSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableReadProvisionedThroughputSettingsFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings(this InnerGlobalTableReadProvisionedThroughputSettingsFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null)
    {
        parentFactory.ReadCapacityAutoScalingSettingsFactory = new InnerGlobalTableCapacityAutoScalingSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReadCapacityAutoScalingSettingsFactory);
    }

    public static CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1>(this CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1>(this CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2>(this CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2>(this CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableReadProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableReadProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableReadProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableReadProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, T2, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableReadProvisionedThroughputSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T2, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableReadProvisionedThroughputSettingsFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableReadProvisionedThroughputSettingsFactory, InnerGlobalTableCapacityAutoScalingSettingsFactory> WithReadCapacityAutoScalingSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableReadProvisionedThroughputSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadCapacityAutoScalingSettings(combinedResult.T5, subFactoryAction));
}
