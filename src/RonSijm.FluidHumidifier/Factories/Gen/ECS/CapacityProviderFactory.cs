// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class CapacityProviderFactory(string resourceName = null, Action<Humidifier.ECS.CapacityProvider> factoryAction = null) : ResourceFactory<Humidifier.ECS.CapacityProvider>(resourceName)
{

    internal InnerCapacityProviderAutoScalingGroupProviderFactory AutoScalingGroupProviderFactory { get; set; }

    protected override Humidifier.ECS.CapacityProvider Create()
    {
        var capacityProviderResult = CreateCapacityProvider();
        factoryAction?.Invoke(capacityProviderResult);

        return capacityProviderResult;
    }

    private Humidifier.ECS.CapacityProvider CreateCapacityProvider()
    {
        var capacityProviderResult = new Humidifier.ECS.CapacityProvider
        {
            GivenName = InputResourceName,
        };

        return capacityProviderResult;
    }
    public override void CreateChildren(Humidifier.ECS.CapacityProvider result)
    {
        base.CreateChildren(result);

        result.AutoScalingGroupProvider ??= AutoScalingGroupProviderFactory?.Build();
    }

} // End Of Class

public static class CapacityProviderFactoryExtensions
{
    public static CombinedResult<CapacityProviderFactory, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider(this CapacityProviderFactory parentFactory, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null)
    {
        parentFactory.AutoScalingGroupProviderFactory = new InnerCapacityProviderAutoScalingGroupProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoScalingGroupProviderFactory);
    }

    public static CombinedResult<CapacityProviderFactory, T1, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1>(this CombinedResult<CapacityProviderFactory, T1> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityProviderFactory, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1>(this CombinedResult<T1, CapacityProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapacityProviderFactory, T1, T2, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2>(this CombinedResult<CapacityProviderFactory, T1, T2> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityProviderFactory, T2, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2>(this CombinedResult<T1, CapacityProviderFactory, T2> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityProviderFactory, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2>(this CombinedResult<T1, T2, CapacityProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapacityProviderFactory, T1, T2, T3, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3>(this CombinedResult<CapacityProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityProviderFactory, T2, T3, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3>(this CombinedResult<T1, CapacityProviderFactory, T2, T3> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityProviderFactory, T3, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3>(this CombinedResult<T1, T2, CapacityProviderFactory, T3> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityProviderFactory, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapacityProviderFactory, T1, T2, T3, T4, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3, T4>(this CombinedResult<CapacityProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityProviderFactory, T2, T3, T4, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3, T4>(this CombinedResult<T1, CapacityProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityProviderFactory, T3, T4, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityProviderFactory, T3, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityProviderFactory, T4, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityProviderFactory, T4> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapacityProviderFactory, InnerCapacityProviderAutoScalingGroupProviderFactory> WithAutoScalingGroupProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityProviderFactory> combinedResult, Action<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingGroupProvider(combinedResult.T5, subFactoryAction));
}
