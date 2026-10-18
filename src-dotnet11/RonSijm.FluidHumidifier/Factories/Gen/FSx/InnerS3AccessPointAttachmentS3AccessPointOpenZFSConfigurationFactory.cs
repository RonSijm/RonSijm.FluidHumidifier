// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration>
{

    internal InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory FileSystemIdentityFactory { get; set; }

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration Create()
    {
        var s3AccessPointOpenZFSConfigurationResult = CreateS3AccessPointOpenZFSConfiguration();
        factoryAction?.Invoke(s3AccessPointOpenZFSConfigurationResult);

        return s3AccessPointOpenZFSConfigurationResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration CreateS3AccessPointOpenZFSConfiguration()
    {
        var s3AccessPointOpenZFSConfigurationResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration();

        return s3AccessPointOpenZFSConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration result)
    {
        base.CreateChildren(result);

        result.FileSystemIdentity ??= FileSystemIdentityFactory?.Build();
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactoryExtensions
{
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity(this InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory parentFactory, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null)
    {
        parentFactory.FileSystemIdentityFactory = new InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileSystemIdentityFactory);
    }

    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T2, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, T2, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T2, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T3, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, T2, T3, T4, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T2, T3, T4, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T3, T4, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T4, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory, InnerS3AccessPointAttachmentOpenZFSFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointOpenZFSConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T5, subFactoryAction).T2);
}
