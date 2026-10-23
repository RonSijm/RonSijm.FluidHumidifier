// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerInfrastructureConfigurationParentInstanceFactory(Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance>
{

    internal InnerInfrastructureConfigurationAutoScalingGroupFactory AutoScalingGroupFactory { get; set; }

    protected override Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance Create()
    {
        var parentInstanceResult = CreateParentInstance();
        factoryAction?.Invoke(parentInstanceResult);

        return parentInstanceResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance CreateParentInstance()
    {
        var parentInstanceResult = new Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance();

        return parentInstanceResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.InfrastructureConfigurationTypes.ParentInstance result)
    {
        base.CreateChildren(result);

        result.AutoScalingGroup ??= AutoScalingGroupFactory?.Build();
    }

} // End Of Class

public static class InnerInfrastructureConfigurationParentInstanceFactoryExtensions
{
    public static CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup(this InnerInfrastructureConfigurationParentInstanceFactory parentFactory, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null)
    {
        parentFactory.AutoScalingGroupFactory = new InnerInfrastructureConfigurationAutoScalingGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoScalingGroupFactory);
    }

    public static CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1>(this CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1>(this CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, T2, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2>(this CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, T2, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2>(this CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInfrastructureConfigurationParentInstanceFactory, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2>(this CombinedResult<T1, T2, InnerInfrastructureConfigurationParentInstanceFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, T2, T3, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3>(this CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, T2, T3, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3>(this CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInfrastructureConfigurationParentInstanceFactory, T3, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3>(this CombinedResult<T1, T2, InnerInfrastructureConfigurationParentInstanceFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationParentInstanceFactory, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationParentInstanceFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, T2, T3, T4, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3, T4>(this CombinedResult<InnerInfrastructureConfigurationParentInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, T2, T3, T4, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3, T4>(this CombinedResult<T1, InnerInfrastructureConfigurationParentInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInfrastructureConfigurationParentInstanceFactory, T3, T4, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInfrastructureConfigurationParentInstanceFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationParentInstanceFactory, T4, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationParentInstanceFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInfrastructureConfigurationParentInstanceFactory, InnerInfrastructureConfigurationAutoScalingGroupFactory> WithAutoScalingGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInfrastructureConfigurationParentInstanceFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroup(combinedResult.T5, subFactoryAction).T2);
}
