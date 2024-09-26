// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceSharePointConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.SharePointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.SharePointConfiguration>
{

    internal InnerDataSourceS3PathFactory SslCertificateS3PathFactory { get; set; }

    internal InnerDataSourceDataSourceVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.Kendra.DataSourceTypes.SharePointConfiguration Create()
    {
        var sharePointConfigurationResult = CreateSharePointConfiguration();
        factoryAction?.Invoke(sharePointConfigurationResult);

        return sharePointConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.SharePointConfiguration CreateSharePointConfiguration()
    {
        var sharePointConfigurationResult = new Humidifier.Kendra.DataSourceTypes.SharePointConfiguration();

        return sharePointConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSourceTypes.SharePointConfiguration result)
    {
        base.CreateChildren(result);

        result.SslCertificateS3Path ??= SslCertificateS3PathFactory?.Build();
        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceSharePointConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, InnerDataSourceS3PathFactory> WithSslCertificateS3Path(this InnerDataSourceSharePointConfigurationFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null)
    {
        parentFactory.SslCertificateS3PathFactory = new InnerDataSourceS3PathFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SslCertificateS3PathFactory);
    }

    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration(this InnerDataSourceSharePointConfigurationFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerDataSourceDataSourceVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3, T4, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3, T4, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3, T4, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory, T4, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceS3PathFactory> WithSslCertificateS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslCertificateS3Path(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSharePointConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSharePointConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSharePointConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSharePointConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSharePointConfigurationFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSharePointConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
}
