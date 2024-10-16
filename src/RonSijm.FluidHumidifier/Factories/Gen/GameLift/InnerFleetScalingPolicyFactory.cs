// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetScalingPolicyFactory(Action<Humidifier.GameLift.FleetTypes.ScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.ScalingPolicy>
{

    internal InnerFleetTargetConfigurationFactory TargetConfigurationFactory { get; set; }

    protected override Humidifier.GameLift.FleetTypes.ScalingPolicy Create()
    {
        var scalingPolicyResult = CreateScalingPolicy();
        factoryAction?.Invoke(scalingPolicyResult);

        return scalingPolicyResult;
    }

    private Humidifier.GameLift.FleetTypes.ScalingPolicy CreateScalingPolicy()
    {
        var scalingPolicyResult = new Humidifier.GameLift.FleetTypes.ScalingPolicy();

        return scalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.GameLift.FleetTypes.ScalingPolicy result)
    {
        base.CreateChildren(result);

        result.TargetConfiguration ??= TargetConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFleetScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerFleetScalingPolicyFactory, InnerFleetTargetConfigurationFactory> WithTargetConfiguration(this InnerFleetScalingPolicyFactory parentFactory, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null)
    {
        parentFactory.TargetConfigurationFactory = new InnerFleetTargetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetConfigurationFactory);
    }

    public static CombinedResult<InnerFleetScalingPolicyFactory, T1, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1>(this CombinedResult<InnerFleetScalingPolicyFactory, T1> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetScalingPolicyFactory, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1>(this CombinedResult<T1, InnerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetScalingPolicyFactory, T1, T2, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2>(this CombinedResult<InnerFleetScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetScalingPolicyFactory, T2, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2>(this CombinedResult<T1, InnerFleetScalingPolicyFactory, T2> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetScalingPolicyFactory, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetScalingPolicyFactory, T1, T2, T3, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<InnerFleetScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetScalingPolicyFactory, T2, T3, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFleetScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetScalingPolicyFactory, T3, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetScalingPolicyFactory, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetScalingPolicyFactory, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetScalingPolicyFactory, T1, T2, T3, T4, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFleetScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetScalingPolicyFactory, T2, T3, T4, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetScalingPolicyFactory, T3, T4, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetScalingPolicyFactory, T4, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetScalingPolicyFactory, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetScalingPolicyFactory, InnerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T5, subFactoryAction));
}
