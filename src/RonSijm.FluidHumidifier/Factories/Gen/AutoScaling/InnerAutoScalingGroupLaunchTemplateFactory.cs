// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupLaunchTemplateFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate>
{

    internal InnerAutoScalingGroupLaunchTemplateSpecificationFactory LaunchTemplateSpecificationFactory { get; set; }

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate Create()
    {
        var launchTemplateResult = CreateLaunchTemplate();
        factoryAction?.Invoke(launchTemplateResult);

        return launchTemplateResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate CreateLaunchTemplate()
    {
        var launchTemplateResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate();

        return launchTemplateResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate result)
    {
        base.CreateChildren(result);

        result.LaunchTemplateSpecification ??= LaunchTemplateSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerAutoScalingGroupLaunchTemplateFactoryExtensions
{
    public static CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification(this InnerAutoScalingGroupLaunchTemplateFactory parentFactory, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null)
    {
        parentFactory.LaunchTemplateSpecificationFactory = new InnerAutoScalingGroupLaunchTemplateSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchTemplateSpecificationFactory);
    }

    public static CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1>(this CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1>(this CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, T2, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2>(this CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, T2, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2>(this CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, T2> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutoScalingGroupLaunchTemplateFactory, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2>(this CombinedResult<T1, T2, InnerAutoScalingGroupLaunchTemplateFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, T2, T3, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, T2, T3, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutoScalingGroupLaunchTemplateFactory, T3, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoScalingGroupLaunchTemplateFactory, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAutoScalingGroupLaunchTemplateFactory, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoScalingGroupLaunchTemplateFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, T2, T3, T4, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<InnerAutoScalingGroupLaunchTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, T2, T3, T4, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoScalingGroupLaunchTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutoScalingGroupLaunchTemplateFactory, T3, T4, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoScalingGroupLaunchTemplateFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAutoScalingGroupLaunchTemplateFactory, T4, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoScalingGroupLaunchTemplateFactory, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAutoScalingGroupLaunchTemplateFactory, InnerAutoScalingGroupLaunchTemplateSpecificationFactory> WithLaunchTemplateSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoScalingGroupLaunchTemplateFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplateSpecification(combinedResult.T5, subFactoryAction));
}
