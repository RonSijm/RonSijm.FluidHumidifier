// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3AccessControlListFactory(Action<Humidifier.S3.JobTypes.S3AccessControlList> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3AccessControlList>
{

    internal InnerJobS3ObjectOwnerFactory OwnerFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3AccessControlList Create()
    {
        var s3AccessControlListResult = CreateS3AccessControlList();
        factoryAction?.Invoke(s3AccessControlListResult);

        return s3AccessControlListResult;
    }

    private Humidifier.S3.JobTypes.S3AccessControlList CreateS3AccessControlList()
    {
        var s3AccessControlListResult = new Humidifier.S3.JobTypes.S3AccessControlList();

        return s3AccessControlListResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3AccessControlList result)
    {
        base.CreateChildren(result);

        result.Owner ??= OwnerFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3AccessControlListFactoryExtensions
{
    public static CombinedResult<InnerJobS3AccessControlListFactory, InnerJobS3ObjectOwnerFactory> WithOwner(this InnerJobS3AccessControlListFactory parentFactory, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null)
    {
        parentFactory.OwnerFactory = new InnerJobS3ObjectOwnerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OwnerFactory);
    }

    public static CombinedResult<InnerJobS3AccessControlListFactory, T1, InnerJobS3ObjectOwnerFactory> WithOwner<T1>(this CombinedResult<InnerJobS3AccessControlListFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwner(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlListFactory, InnerJobS3ObjectOwnerFactory> WithOwner<T1>(this CombinedResult<T1, InnerJobS3AccessControlListFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwner(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3AccessControlListFactory, T1, T2, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2>(this CombinedResult<InnerJobS3AccessControlListFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlListFactory, T2, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2>(this CombinedResult<T1, InnerJobS3AccessControlListFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3AccessControlListFactory, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2>(this CombinedResult<T1, T2, InnerJobS3AccessControlListFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3AccessControlListFactory, T1, T2, T3, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3>(this CombinedResult<InnerJobS3AccessControlListFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlListFactory, T2, T3, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3>(this CombinedResult<T1, InnerJobS3AccessControlListFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3AccessControlListFactory, T3, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3AccessControlListFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3AccessControlListFactory, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3AccessControlListFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3AccessControlListFactory, T1, T2, T3, T4, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3, T4>(this CombinedResult<InnerJobS3AccessControlListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3AccessControlListFactory, T2, T3, T4, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3AccessControlListFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3AccessControlListFactory, T3, T4, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3AccessControlListFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3AccessControlListFactory, T4, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3AccessControlListFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3AccessControlListFactory, InnerJobS3ObjectOwnerFactory> WithOwner<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3AccessControlListFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectOwner> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner(combinedResult.T5, subFactoryAction).T2);
}
