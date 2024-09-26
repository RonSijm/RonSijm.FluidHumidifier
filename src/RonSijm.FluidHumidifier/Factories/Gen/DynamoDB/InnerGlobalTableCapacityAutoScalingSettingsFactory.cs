// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableCapacityAutoScalingSettingsFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings>
{

    internal InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory TargetTrackingScalingPolicyConfigurationFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings Create()
    {
        var capacityAutoScalingSettingsResult = CreateCapacityAutoScalingSettings();
        factoryAction?.Invoke(capacityAutoScalingSettingsResult);

        return capacityAutoScalingSettingsResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings CreateCapacityAutoScalingSettings()
    {
        var capacityAutoScalingSettingsResult = new Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings();

        return capacityAutoScalingSettingsResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.CapacityAutoScalingSettings result)
    {
        base.CreateChildren(result);

        result.TargetTrackingScalingPolicyConfiguration ??= TargetTrackingScalingPolicyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableCapacityAutoScalingSettingsFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration(this InnerGlobalTableCapacityAutoScalingSettingsFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null)
    {
        parentFactory.TargetTrackingScalingPolicyConfigurationFactory = new InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetTrackingScalingPolicyConfigurationFactory);
    }

    public static CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1>(this CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1>(this CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, T2, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2>(this CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, T2, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2>(this CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, T2, T3, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, T2, T3, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory, T3, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, T2, T3, T4, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableCapacityAutoScalingSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, T2, T3, T4, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableCapacityAutoScalingSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory, T3, T4, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableCapacityAutoScalingSettingsFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory, T4, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableCapacityAutoScalingSettingsFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory, InnerGlobalTableTargetTrackingScalingPolicyConfigurationFactory> WithTargetTrackingScalingPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableCapacityAutoScalingSettingsFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.TargetTrackingScalingPolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingScalingPolicyConfiguration(combinedResult.T5, subFactoryAction));
}
