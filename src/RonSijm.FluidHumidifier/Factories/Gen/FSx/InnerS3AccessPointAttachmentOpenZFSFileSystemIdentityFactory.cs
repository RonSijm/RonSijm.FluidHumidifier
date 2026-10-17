// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity>
{

    internal InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory PosixUserFactory { get; set; }

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity Create()
    {
        var openZFSFileSystemIdentityResult = CreateOpenZFSFileSystemIdentity();
        factoryAction?.Invoke(openZFSFileSystemIdentityResult);

        return openZFSFileSystemIdentityResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity CreateOpenZFSFileSystemIdentity()
    {
        var openZFSFileSystemIdentityResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity();

        return openZFSFileSystemIdentityResult;
    }
    public override void CreateChildren(Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity result)
    {
        base.CreateChildren(result);

        result.PosixUser ??= PosixUserFactory?.Build();
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactoryExtensions
{
    public static CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser(this InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory parentFactory, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null)
    {
        parentFactory.PosixUserFactory = new InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PosixUserFactory);
    }

    public static CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1>(this CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1>(this CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, T2, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2>(this CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T2, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2>(this CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, T2, T3, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T2, T3, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T3, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, T2, T3, T4, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T2, T3, T4, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T3, T4, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T4, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory, InnerS3AccessPointAttachmentOpenZFSPosixFileSystemUserFactory> WithPosixUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixUser(combinedResult.T5, subFactoryAction).T2);
}
