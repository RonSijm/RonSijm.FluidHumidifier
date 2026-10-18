// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceCapacityReservationSpecificationFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification>
{

    internal InnerWorkspaceInstanceCapacityReservationTargetFactory CapacityReservationTargetFactory { get; set; }

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification Create()
    {
        var capacityReservationSpecificationResult = CreateCapacityReservationSpecification();
        factoryAction?.Invoke(capacityReservationSpecificationResult);

        return capacityReservationSpecificationResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification CreateCapacityReservationSpecification()
    {
        var capacityReservationSpecificationResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification();

        return capacityReservationSpecificationResult;
    }
    public override void CreateChildren(Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationTarget ??= CapacityReservationTargetFactory?.Build();
    }

} // End Of Class

public static class InnerWorkspaceInstanceCapacityReservationSpecificationFactoryExtensions
{
    public static CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget(this InnerWorkspaceInstanceCapacityReservationSpecificationFactory parentFactory, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null)
    {
        parentFactory.CapacityReservationTargetFactory = new InnerWorkspaceInstanceCapacityReservationTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationTargetFactory);
    }

    public static CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, T2, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T2, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T2> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, T2, InnerWorkspaceInstanceCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, T2, T3, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T2, T3, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T3, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T3> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkspaceInstanceCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, T2, T3, T4, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T2, T3, T4, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T3, T4, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T4, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, T4> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkspaceInstanceCapacityReservationSpecificationFactory, InnerWorkspaceInstanceCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkspaceInstanceCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T5, subFactoryAction).T2);
}
