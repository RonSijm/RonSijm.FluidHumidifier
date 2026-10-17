// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigManagedInstanceScalingFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling>
{

    internal InnerEndpointConfigScaleInPolicyFactory ScaleInPolicyFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling Create()
    {
        var managedInstanceScalingResult = CreateManagedInstanceScaling();
        factoryAction?.Invoke(managedInstanceScalingResult);

        return managedInstanceScalingResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling CreateManagedInstanceScaling()
    {
        var managedInstanceScalingResult = new Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling();

        return managedInstanceScalingResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling result)
    {
        base.CreateChildren(result);

        result.ScaleInPolicy ??= ScaleInPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointConfigManagedInstanceScalingFactoryExtensions
{
    public static CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy(this InnerEndpointConfigManagedInstanceScalingFactory parentFactory, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null)
    {
        parentFactory.ScaleInPolicyFactory = new InnerEndpointConfigScaleInPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScaleInPolicyFactory);
    }

    public static CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1>(this CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1>(this CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, T2, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2>(this CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, T2, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2>(this CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigManagedInstanceScalingFactory, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2>(this CombinedResult<T1, T2, InnerEndpointConfigManagedInstanceScalingFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, T2, T3, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, T2, T3, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigManagedInstanceScalingFactory, T3, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointConfigManagedInstanceScalingFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigManagedInstanceScalingFactory, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointConfigManagedInstanceScalingFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, T2, T3, T4, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<InnerEndpointConfigManagedInstanceScalingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, T2, T3, T4, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointConfigManagedInstanceScalingFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigManagedInstanceScalingFactory, T3, T4, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointConfigManagedInstanceScalingFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigManagedInstanceScalingFactory, T4, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointConfigManagedInstanceScalingFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointConfigManagedInstanceScalingFactory, InnerEndpointConfigScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointConfigManagedInstanceScalingFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T5, subFactoryAction).T2);
}
