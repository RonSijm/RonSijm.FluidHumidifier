// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointRollingUpdatePolicyFactory(Action<Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy>
{

    internal InnerEndpointCapacitySizeFactory MaximumBatchSizeFactory { get; set; }

    internal InnerEndpointCapacitySizeFactory RollbackMaximumBatchSizeFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy Create()
    {
        var rollingUpdatePolicyResult = CreateRollingUpdatePolicy();
        factoryAction?.Invoke(rollingUpdatePolicyResult);

        return rollingUpdatePolicyResult;
    }

    private Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy CreateRollingUpdatePolicy()
    {
        var rollingUpdatePolicyResult = new Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy();

        return rollingUpdatePolicyResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy result)
    {
        base.CreateChildren(result);

        result.MaximumBatchSize ??= MaximumBatchSizeFactory?.Build();
        result.RollbackMaximumBatchSize ??= RollbackMaximumBatchSizeFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointRollingUpdatePolicyFactoryExtensions
{
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize(this InnerEndpointRollingUpdatePolicyFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null)
    {
        parentFactory.MaximumBatchSizeFactory = new InnerEndpointCapacitySizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaximumBatchSizeFactory);
    }

    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize(this InnerEndpointRollingUpdatePolicyFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null)
    {
        parentFactory.RollbackMaximumBatchSizeFactory = new InnerEndpointCapacitySizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RollbackMaximumBatchSizeFactory);
    }

    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2>(this CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3, T4, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory, T4, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2>(this CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<InnerEndpointRollingUpdatePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointRollingUpdatePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3, T4, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointRollingUpdatePolicyFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory, T4, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointRollingUpdatePolicyFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointRollingUpdatePolicyFactory, InnerEndpointCapacitySizeFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T5, subFactoryAction));
}
