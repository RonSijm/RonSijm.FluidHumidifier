// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3SetObjectAclOperationFactory(Action<Humidifier.S3.JobTypes.S3SetObjectAclOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3SetObjectAclOperation>
{

    internal InnerJobS3AccessControlPolicyFactory AccessControlPolicyFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3SetObjectAclOperation Create()
    {
        var s3SetObjectAclOperationResult = CreateS3SetObjectAclOperation();
        factoryAction?.Invoke(s3SetObjectAclOperationResult);

        return s3SetObjectAclOperationResult;
    }

    private Humidifier.S3.JobTypes.S3SetObjectAclOperation CreateS3SetObjectAclOperation()
    {
        var s3SetObjectAclOperationResult = new Humidifier.S3.JobTypes.S3SetObjectAclOperation();

        return s3SetObjectAclOperationResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3SetObjectAclOperation result)
    {
        base.CreateChildren(result);

        result.AccessControlPolicy ??= AccessControlPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3SetObjectAclOperationFactoryExtensions
{
    public static CombinedResult<InnerJobS3SetObjectAclOperationFactory, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy(this InnerJobS3SetObjectAclOperationFactory parentFactory, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null)
    {
        parentFactory.AccessControlPolicyFactory = new InnerJobS3AccessControlPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessControlPolicyFactory);
    }

    public static CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1>(this CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1>(this CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, T2, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2>(this CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, T2, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2>(this CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectAclOperationFactory, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2>(this CombinedResult<T1, T2, InnerJobS3SetObjectAclOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, T2, T3, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3>(this CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, T2, T3, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3>(this CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectAclOperationFactory, T3, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3SetObjectAclOperationFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3SetObjectAclOperationFactory, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3SetObjectAclOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, T2, T3, T4, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3, T4>(this CombinedResult<InnerJobS3SetObjectAclOperationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, T2, T3, T4, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3SetObjectAclOperationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectAclOperationFactory, T3, T4, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3SetObjectAclOperationFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3SetObjectAclOperationFactory, T4, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3SetObjectAclOperationFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3SetObjectAclOperationFactory, InnerJobS3AccessControlPolicyFactory> WithAccessControlPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3SetObjectAclOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlPolicy(combinedResult.T5, subFactoryAction).T2);
}
