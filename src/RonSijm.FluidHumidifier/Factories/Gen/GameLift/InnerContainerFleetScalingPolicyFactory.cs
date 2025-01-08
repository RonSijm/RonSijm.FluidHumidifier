// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetScalingPolicyFactory(Action<Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy>
{

    internal InnerContainerFleetTargetConfigurationFactory TargetConfigurationFactory { get; set; }

    protected override Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy Create()
    {
        var scalingPolicyResult = CreateScalingPolicy();
        factoryAction?.Invoke(scalingPolicyResult);

        return scalingPolicyResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy CreateScalingPolicy()
    {
        var scalingPolicyResult = new Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy();

        return scalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.GameLift.ContainerFleetTypes.ScalingPolicy result)
    {
        base.CreateChildren(result);

        result.TargetConfiguration ??= TargetConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerContainerFleetScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerContainerFleetScalingPolicyFactory, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration(this InnerContainerFleetScalingPolicyFactory parentFactory, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null)
    {
        parentFactory.TargetConfigurationFactory = new InnerContainerFleetTargetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetConfigurationFactory);
    }

    public static CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1>(this CombinedResult<InnerContainerFleetScalingPolicyFactory, T1> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1>(this CombinedResult<T1, InnerContainerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, T2, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2>(this CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, T2, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2>(this CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, T2> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerFleetScalingPolicyFactory, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerContainerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, T2, T3, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, T2, T3, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerFleetScalingPolicyFactory, T3, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerFleetScalingPolicyFactory, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerFleetScalingPolicyFactory, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, T2, T3, T4, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerContainerFleetScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, T2, T3, T4, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerFleetScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerFleetScalingPolicyFactory, T3, T4, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerFleetScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerFleetScalingPolicyFactory, T4, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerFleetScalingPolicyFactory, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContainerFleetScalingPolicyFactory, InnerContainerFleetTargetConfigurationFactory> WithTargetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerFleetScalingPolicyFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetConfiguration(combinedResult.T5, subFactoryAction));
}
