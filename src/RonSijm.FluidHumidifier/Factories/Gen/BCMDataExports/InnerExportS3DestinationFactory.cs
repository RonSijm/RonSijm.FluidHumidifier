// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class InnerExportS3DestinationFactory(Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> factoryAction = null) : SubResourceFactory<Humidifier.BCMDataExports.ExportTypes.S3Destination>
{

    internal InnerExportS3OutputConfigurationsFactory S3OutputConfigurationsFactory { get; set; }

    protected override Humidifier.BCMDataExports.ExportTypes.S3Destination Create()
    {
        var s3DestinationResult = CreateS3Destination();
        factoryAction?.Invoke(s3DestinationResult);

        return s3DestinationResult;
    }

    private Humidifier.BCMDataExports.ExportTypes.S3Destination CreateS3Destination()
    {
        var s3DestinationResult = new Humidifier.BCMDataExports.ExportTypes.S3Destination();

        return s3DestinationResult;
    }
    public override void CreateChildren(Humidifier.BCMDataExports.ExportTypes.S3Destination result)
    {
        base.CreateChildren(result);

        result.S3OutputConfigurations ??= S3OutputConfigurationsFactory?.Build();
    }

} // End Of Class

public static class InnerExportS3DestinationFactoryExtensions
{
    public static CombinedResult<InnerExportS3DestinationFactory, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations(this InnerExportS3DestinationFactory parentFactory, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null)
    {
        parentFactory.S3OutputConfigurationsFactory = new InnerExportS3OutputConfigurationsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3OutputConfigurationsFactory);
    }

    public static CombinedResult<InnerExportS3DestinationFactory, T1, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1>(this CombinedResult<InnerExportS3DestinationFactory, T1> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportS3DestinationFactory, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1>(this CombinedResult<T1, InnerExportS3DestinationFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerExportS3DestinationFactory, T1, T2, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2>(this CombinedResult<InnerExportS3DestinationFactory, T1, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportS3DestinationFactory, T2, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2>(this CombinedResult<T1, InnerExportS3DestinationFactory, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExportS3DestinationFactory, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2>(this CombinedResult<T1, T2, InnerExportS3DestinationFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerExportS3DestinationFactory, T1, T2, T3, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3>(this CombinedResult<InnerExportS3DestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportS3DestinationFactory, T2, T3, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3>(this CombinedResult<T1, InnerExportS3DestinationFactory, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExportS3DestinationFactory, T3, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, InnerExportS3DestinationFactory, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerExportS3DestinationFactory, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerExportS3DestinationFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerExportS3DestinationFactory, T1, T2, T3, T4, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3, T4>(this CombinedResult<InnerExportS3DestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportS3DestinationFactory, T2, T3, T4, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, InnerExportS3DestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExportS3DestinationFactory, T3, T4, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerExportS3DestinationFactory, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerExportS3DestinationFactory, T4, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerExportS3DestinationFactory, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerExportS3DestinationFactory, InnerExportS3OutputConfigurationsFactory> WithS3OutputConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerExportS3DestinationFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfigurations(combinedResult.T5, subFactoryAction));
}
