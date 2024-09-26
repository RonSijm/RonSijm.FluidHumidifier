// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentComputeResourcesFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources>
{

    internal InnerComputeEnvironmentLaunchTemplateSpecificationFactory LaunchTemplateFactory { get; set; }

    protected override Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources Create()
    {
        var computeResourcesResult = CreateComputeResources();
        factoryAction?.Invoke(computeResourcesResult);

        return computeResourcesResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources CreateComputeResources()
    {
        var computeResourcesResult = new Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources();

        return computeResourcesResult;
    }
    public override void CreateChildren(Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources result)
    {
        base.CreateChildren(result);

        result.LaunchTemplate ??= LaunchTemplateFactory?.Build();
    }

} // End Of Class

public static class InnerComputeEnvironmentComputeResourcesFactoryExtensions
{
    public static CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate(this InnerComputeEnvironmentComputeResourcesFactory parentFactory, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null)
    {
        parentFactory.LaunchTemplateFactory = new InnerComputeEnvironmentLaunchTemplateSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchTemplateFactory);
    }

    public static CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1>(this CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1>(this CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, T2, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2>(this CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, T2> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, T2, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2>(this CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, T2> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComputeEnvironmentComputeResourcesFactory, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2>(this CombinedResult<T1, T2, InnerComputeEnvironmentComputeResourcesFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, T2, T3, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3>(this CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, T2, T3, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3>(this CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, T2, T3> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComputeEnvironmentComputeResourcesFactory, T3, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerComputeEnvironmentComputeResourcesFactory, T3> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComputeEnvironmentComputeResourcesFactory, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComputeEnvironmentComputeResourcesFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, T2, T3, T4, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3, T4>(this CombinedResult<InnerComputeEnvironmentComputeResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, T2, T3, T4, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerComputeEnvironmentComputeResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComputeEnvironmentComputeResourcesFactory, T3, T4, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComputeEnvironmentComputeResourcesFactory, T3, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComputeEnvironmentComputeResourcesFactory, T4, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComputeEnvironmentComputeResourcesFactory, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerComputeEnvironmentComputeResourcesFactory, InnerComputeEnvironmentLaunchTemplateSpecificationFactory> WithLaunchTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComputeEnvironmentComputeResourcesFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchTemplate(combinedResult.T5, subFactoryAction));
}
