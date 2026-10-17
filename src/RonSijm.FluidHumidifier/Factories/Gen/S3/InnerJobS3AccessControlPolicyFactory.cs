// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3AccessControlPolicyFactory(Action<Humidifier.S3.JobTypes.S3AccessControlPolicy> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3AccessControlPolicy>
{

    internal InnerJobS3AccessControlListFactory AccessControlListFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3AccessControlPolicy Create()
    {
        var s3AccessControlPolicyResult = CreateS3AccessControlPolicy();
        factoryAction?.Invoke(s3AccessControlPolicyResult);

        return s3AccessControlPolicyResult;
    }

    private Humidifier.S3.JobTypes.S3AccessControlPolicy CreateS3AccessControlPolicy()
    {
        var s3AccessControlPolicyResult = new Humidifier.S3.JobTypes.S3AccessControlPolicy();

        return s3AccessControlPolicyResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3AccessControlPolicy result)
    {
        base.CreateChildren(result);

        result.AccessControlList ??= AccessControlListFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3AccessControlPolicyFactoryExtensions
{
    public static CombinedResult<InnerJobS3AccessControlPolicyFactory, InnerJobS3AccessControlListFactory> WithAccessControlList(this InnerJobS3AccessControlPolicyFactory parentFactory, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null)
    {
        parentFactory.AccessControlListFactory = new InnerJobS3AccessControlListFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessControlListFactory);
    }

    public static CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, InnerJobS3AccessControlListFactory> WithAccessControlList<T1>(this CombinedResult<InnerJobS3AccessControlPolicyFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessControlList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, InnerJobS3AccessControlListFactory> WithAccessControlList<T1>(this CombinedResult<T1, InnerJobS3AccessControlPolicyFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessControlList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, T2, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2>(this CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, T2, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2>(this CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3AccessControlPolicyFactory, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2>(this CombinedResult<T1, T2, InnerJobS3AccessControlPolicyFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, T2, T3, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3>(this CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, T2, T3, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3>(this CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3AccessControlPolicyFactory, T3, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3AccessControlPolicyFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3AccessControlPolicyFactory, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3AccessControlPolicyFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, T2, T3, T4, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3, T4>(this CombinedResult<InnerJobS3AccessControlPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, T2, T3, T4, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3AccessControlPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3AccessControlPolicyFactory, T3, T4, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3AccessControlPolicyFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3AccessControlPolicyFactory, T4, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3AccessControlPolicyFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3AccessControlPolicyFactory, InnerJobS3AccessControlListFactory> WithAccessControlList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3AccessControlPolicyFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3AccessControlList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessControlList(combinedResult.T5, subFactoryAction).T2);
}
