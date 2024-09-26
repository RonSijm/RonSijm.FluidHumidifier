// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderAutoScalingGroupProviderFactory(Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider>
{

    internal InnerCapacityProviderManagedScalingFactory ManagedScalingFactory { get; set; }

    protected override Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider Create()
    {
        var autoScalingGroupProviderResult = CreateAutoScalingGroupProvider();
        factoryAction?.Invoke(autoScalingGroupProviderResult);

        return autoScalingGroupProviderResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider CreateAutoScalingGroupProvider()
    {
        var autoScalingGroupProviderResult = new Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider();

        return autoScalingGroupProviderResult;
    }
    public override void CreateChildren(Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider result)
    {
        base.CreateChildren(result);

        result.ManagedScaling ??= ManagedScalingFactory?.Build();
    }

} // End Of Class

public static class InnerCapacityProviderAutoScalingGroupProviderFactoryExtensions
{
    public static CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, InnerCapacityProviderManagedScalingFactory> WithManagedScaling(this InnerCapacityProviderAutoScalingGroupProviderFactory parentFactory, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null)
    {
        parentFactory.ManagedScalingFactory = new InnerCapacityProviderManagedScalingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManagedScalingFactory);
    }

    public static CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1>(this CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1>(this CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, T2, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2>(this CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, T2> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, T2, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2>(this CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, T2> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2>(this CombinedResult<T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, T2, T3, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3>(this CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, T2, T3, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3>(this CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, T2, T3> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory, T3, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory, T3> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderAutoScalingGroupProviderFactory, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapacityProviderAutoScalingGroupProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, T2, T3, T4, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3, T4>(this CombinedResult<InnerCapacityProviderAutoScalingGroupProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, T2, T3, T4, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapacityProviderAutoScalingGroupProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory, T3, T4, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory, T3, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderAutoScalingGroupProviderFactory, T4, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapacityProviderAutoScalingGroupProviderFactory, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCapacityProviderAutoScalingGroupProviderFactory, InnerCapacityProviderManagedScalingFactory> WithManagedScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapacityProviderAutoScalingGroupProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedScaling(combinedResult.T5, subFactoryAction));
}
