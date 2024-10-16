// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class DirectoryConfigFactory(string resourceName = null, Action<Humidifier.AppStream.DirectoryConfig> factoryAction = null) : ResourceFactory<Humidifier.AppStream.DirectoryConfig>(resourceName)
{

    internal InnerDirectoryConfigServiceAccountCredentialsFactory ServiceAccountCredentialsFactory { get; set; }

    internal InnerDirectoryConfigCertificateBasedAuthPropertiesFactory CertificateBasedAuthPropertiesFactory { get; set; }

    protected override Humidifier.AppStream.DirectoryConfig Create()
    {
        var directoryConfigResult = CreateDirectoryConfig();
        factoryAction?.Invoke(directoryConfigResult);

        return directoryConfigResult;
    }

    private Humidifier.AppStream.DirectoryConfig CreateDirectoryConfig()
    {
        var directoryConfigResult = new Humidifier.AppStream.DirectoryConfig
        {
            GivenName = InputResourceName,
        };

        return directoryConfigResult;
    }
    public override void CreateChildren(Humidifier.AppStream.DirectoryConfig result)
    {
        base.CreateChildren(result);

        result.ServiceAccountCredentials ??= ServiceAccountCredentialsFactory?.Build();
        result.CertificateBasedAuthProperties ??= CertificateBasedAuthPropertiesFactory?.Build();
    }

} // End Of Class

public static class DirectoryConfigFactoryExtensions
{
    public static CombinedResult<DirectoryConfigFactory, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials(this DirectoryConfigFactory parentFactory, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null)
    {
        parentFactory.ServiceAccountCredentialsFactory = new InnerDirectoryConfigServiceAccountCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceAccountCredentialsFactory);
    }

    public static CombinedResult<DirectoryConfigFactory, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties(this DirectoryConfigFactory parentFactory, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null)
    {
        parentFactory.CertificateBasedAuthPropertiesFactory = new InnerDirectoryConfigCertificateBasedAuthPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateBasedAuthPropertiesFactory);
    }

    public static CombinedResult<DirectoryConfigFactory, T1, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1>(this CombinedResult<DirectoryConfigFactory, T1> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1>(this CombinedResult<T1, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, T2, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2>(this CombinedResult<DirectoryConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, T2, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2>(this CombinedResult<T1, DirectoryConfigFactory, T2> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryConfigFactory, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2>(this CombinedResult<T1, T2, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, T2, T3, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3>(this CombinedResult<DirectoryConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, T2, T3, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3>(this CombinedResult<T1, DirectoryConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryConfigFactory, T3, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3>(this CombinedResult<T1, T2, DirectoryConfigFactory, T3> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryConfigFactory, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, T2, T3, T4, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3, T4>(this CombinedResult<DirectoryConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, T2, T3, T4, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3, T4>(this CombinedResult<T1, DirectoryConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryConfigFactory, T3, T4, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, DirectoryConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryConfigFactory, T4, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DirectoryConfigFactory, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DirectoryConfigFactory, InnerDirectoryConfigServiceAccountCredentialsFactory> WithServiceAccountCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceAccountCredentials(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1>(this CombinedResult<DirectoryConfigFactory, T1> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1>(this CombinedResult<T1, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, T2, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2>(this CombinedResult<DirectoryConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, T2, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2>(this CombinedResult<T1, DirectoryConfigFactory, T2> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryConfigFactory, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2>(this CombinedResult<T1, T2, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, T2, T3, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3>(this CombinedResult<DirectoryConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, T2, T3, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3>(this CombinedResult<T1, DirectoryConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryConfigFactory, T3, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3>(this CombinedResult<T1, T2, DirectoryConfigFactory, T3> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryConfigFactory, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DirectoryConfigFactory, T1, T2, T3, T4, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3, T4>(this CombinedResult<DirectoryConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryConfigFactory, T2, T3, T4, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, DirectoryConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryConfigFactory, T3, T4, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, DirectoryConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryConfigFactory, T4, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DirectoryConfigFactory, T4> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DirectoryConfigFactory, InnerDirectoryConfigCertificateBasedAuthPropertiesFactory> WithCertificateBasedAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DirectoryConfigFactory> combinedResult, Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateBasedAuthProperties(combinedResult.T5, subFactoryAction));
}
