// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainExportingConfigFactory(Action<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.ExportingConfig>
{

    internal InnerDomainS3ExportingConfigFactory S3ExportingFactory { get; set; }

    protected override Humidifier.CustomerProfiles.DomainTypes.ExportingConfig Create()
    {
        var exportingConfigResult = CreateExportingConfig();
        factoryAction?.Invoke(exportingConfigResult);

        return exportingConfigResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.ExportingConfig CreateExportingConfig()
    {
        var exportingConfigResult = new Humidifier.CustomerProfiles.DomainTypes.ExportingConfig();

        return exportingConfigResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.DomainTypes.ExportingConfig result)
    {
        base.CreateChildren(result);

        result.S3Exporting ??= S3ExportingFactory?.Build();
    }

} // End Of Class

public static class InnerDomainExportingConfigFactoryExtensions
{
    public static CombinedResult<InnerDomainExportingConfigFactory, InnerDomainS3ExportingConfigFactory> WithS3Exporting(this InnerDomainExportingConfigFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null)
    {
        parentFactory.S3ExportingFactory = new InnerDomainS3ExportingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ExportingFactory);
    }

    public static CombinedResult<InnerDomainExportingConfigFactory, T1, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1>(this CombinedResult<InnerDomainExportingConfigFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Exporting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainExportingConfigFactory, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1>(this CombinedResult<T1, InnerDomainExportingConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Exporting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainExportingConfigFactory, T1, T2, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2>(this CombinedResult<InnerDomainExportingConfigFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainExportingConfigFactory, T2, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2>(this CombinedResult<T1, InnerDomainExportingConfigFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainExportingConfigFactory, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2>(this CombinedResult<T1, T2, InnerDomainExportingConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainExportingConfigFactory, T1, T2, T3, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3>(this CombinedResult<InnerDomainExportingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainExportingConfigFactory, T2, T3, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3>(this CombinedResult<T1, InnerDomainExportingConfigFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainExportingConfigFactory, T3, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainExportingConfigFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainExportingConfigFactory, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainExportingConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainExportingConfigFactory, T1, T2, T3, T4, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3, T4>(this CombinedResult<InnerDomainExportingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainExportingConfigFactory, T2, T3, T4, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainExportingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainExportingConfigFactory, T3, T4, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainExportingConfigFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainExportingConfigFactory, T4, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainExportingConfigFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainExportingConfigFactory, InnerDomainS3ExportingConfigFactory> WithS3Exporting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainExportingConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Exporting(combinedResult.T5, subFactoryAction));
}
