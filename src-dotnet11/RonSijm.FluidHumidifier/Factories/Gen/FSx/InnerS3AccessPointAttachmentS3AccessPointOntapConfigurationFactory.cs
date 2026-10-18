// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration>
{

    internal InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory FileSystemIdentityFactory { get; set; }

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration Create()
    {
        var s3AccessPointOntapConfigurationResult = CreateS3AccessPointOntapConfiguration();
        factoryAction?.Invoke(s3AccessPointOntapConfigurationResult);

        return s3AccessPointOntapConfigurationResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration CreateS3AccessPointOntapConfiguration()
    {
        var s3AccessPointOntapConfigurationResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration();

        return s3AccessPointOntapConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration result)
    {
        base.CreateChildren(result);

        result.FileSystemIdentity ??= FileSystemIdentityFactory?.Build();
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactoryExtensions
{
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity(this InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory parentFactory, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null)
    {
        parentFactory.FileSystemIdentityFactory = new InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileSystemIdentityFactory);
    }

    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, T2, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T2, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, T2, T3, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T2, T3, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T3, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, T2, T3, T4, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T2, T3, T4, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T3, T4, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T4, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory, InnerS3AccessPointAttachmentOntapFileSystemIdentityFactory> WithFileSystemIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerS3AccessPointAttachmentS3AccessPointOntapConfigurationFactory> combinedResult, Action<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemIdentity(combinedResult.T5, subFactoryAction).T2);
}
