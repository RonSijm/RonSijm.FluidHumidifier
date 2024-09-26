// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameServerGroupAutoScalingPolicyFactory(Action<Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy>
{

    internal InnerGameServerGroupTargetTrackingConfigurationFactory TargetTrackingConfigurationFactory { get; set; }

    protected override Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy Create()
    {
        var autoScalingPolicyResult = CreateAutoScalingPolicy();
        factoryAction?.Invoke(autoScalingPolicyResult);

        return autoScalingPolicyResult;
    }

    private Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy CreateAutoScalingPolicy()
    {
        var autoScalingPolicyResult = new Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy();

        return autoScalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.GameLift.GameServerGroupTypes.AutoScalingPolicy result)
    {
        base.CreateChildren(result);

        result.TargetTrackingConfiguration ??= TargetTrackingConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerGameServerGroupAutoScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration(this InnerGameServerGroupAutoScalingPolicyFactory parentFactory, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null)
    {
        parentFactory.TargetTrackingConfigurationFactory = new InnerGameServerGroupTargetTrackingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetTrackingConfigurationFactory);
    }

    public static CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1>(this CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1>(this CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, T2, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2>(this CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, T2, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2>(this CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, T2> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGameServerGroupAutoScalingPolicyFactory, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerGameServerGroupAutoScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, T2, T3, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3>(this CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, T2, T3, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGameServerGroupAutoScalingPolicyFactory, T3, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerGameServerGroupAutoScalingPolicyFactory, T3> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGameServerGroupAutoScalingPolicyFactory, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGameServerGroupAutoScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, T2, T3, T4, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerGameServerGroupAutoScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, T2, T3, T4, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerGameServerGroupAutoScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGameServerGroupAutoScalingPolicyFactory, T3, T4, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGameServerGroupAutoScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGameServerGroupAutoScalingPolicyFactory, T4, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGameServerGroupAutoScalingPolicyFactory, T4> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGameServerGroupAutoScalingPolicyFactory, InnerGameServerGroupTargetTrackingConfigurationFactory> WithTargetTrackingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGameServerGroupAutoScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetTrackingConfiguration(combinedResult.T5, subFactoryAction));
}
