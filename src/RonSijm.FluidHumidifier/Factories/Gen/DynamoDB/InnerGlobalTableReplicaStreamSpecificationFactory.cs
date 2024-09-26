// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableReplicaStreamSpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification>
{

    internal InnerGlobalTableResourcePolicyFactory ResourcePolicyFactory { get; set; }

    protected override Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification Create()
    {
        var replicaStreamSpecificationResult = CreateReplicaStreamSpecification();
        factoryAction?.Invoke(replicaStreamSpecificationResult);

        return replicaStreamSpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification CreateReplicaStreamSpecification()
    {
        var replicaStreamSpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification();

        return replicaStreamSpecificationResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.GlobalTableTypes.ReplicaStreamSpecification result)
    {
        base.CreateChildren(result);

        result.ResourcePolicy ??= ResourcePolicyFactory?.Build();
    }

} // End Of Class

public static class InnerGlobalTableReplicaStreamSpecificationFactoryExtensions
{
    public static CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy(this InnerGlobalTableReplicaStreamSpecificationFactory parentFactory, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null)
    {
        parentFactory.ResourcePolicyFactory = new InnerGlobalTableResourcePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourcePolicyFactory);
    }

    public static CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1>(this CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1>(this CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, T2, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2>(this CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, T2, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2>(this CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, T2> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableReplicaStreamSpecificationFactory, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2>(this CombinedResult<T1, T2, InnerGlobalTableReplicaStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, T2, T3, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, T2, T3, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableReplicaStreamSpecificationFactory, T3, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerGlobalTableReplicaStreamSpecificationFactory, T3> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableReplicaStreamSpecificationFactory, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGlobalTableReplicaStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, T2, T3, T4, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<InnerGlobalTableReplicaStreamSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, T2, T3, T4, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerGlobalTableReplicaStreamSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGlobalTableReplicaStreamSpecificationFactory, T3, T4, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGlobalTableReplicaStreamSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGlobalTableReplicaStreamSpecificationFactory, T4, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGlobalTableReplicaStreamSpecificationFactory, T4> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGlobalTableReplicaStreamSpecificationFactory, InnerGlobalTableResourcePolicyFactory> WithResourcePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGlobalTableReplicaStreamSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourcePolicy(combinedResult.T5, subFactoryAction));
}
