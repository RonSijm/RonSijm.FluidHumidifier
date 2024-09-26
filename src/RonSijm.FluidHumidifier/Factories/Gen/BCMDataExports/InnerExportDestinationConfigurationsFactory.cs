// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class InnerExportDestinationConfigurationsFactory(Action<Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations> factoryAction = null) : SubResourceFactory<Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations>
{

    internal InnerExportS3DestinationFactory S3DestinationFactory { get; set; }

    protected override Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations Create()
    {
        var destinationConfigurationsResult = CreateDestinationConfigurations();
        factoryAction?.Invoke(destinationConfigurationsResult);

        return destinationConfigurationsResult;
    }

    private Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations CreateDestinationConfigurations()
    {
        var destinationConfigurationsResult = new Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations();

        return destinationConfigurationsResult;
    }
    public override void CreateChildren(Humidifier.BCMDataExports.ExportTypes.DestinationConfigurations result)
    {
        base.CreateChildren(result);

        result.S3Destination ??= S3DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerExportDestinationConfigurationsFactoryExtensions
{
    public static CombinedResult<InnerExportDestinationConfigurationsFactory, InnerExportS3DestinationFactory> WithS3Destination(this InnerExportDestinationConfigurationsFactory parentFactory, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null)
    {
        parentFactory.S3DestinationFactory = new InnerExportS3DestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DestinationFactory);
    }

    public static CombinedResult<InnerExportDestinationConfigurationsFactory, T1, InnerExportS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<InnerExportDestinationConfigurationsFactory, T1> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportDestinationConfigurationsFactory, InnerExportS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<T1, InnerExportDestinationConfigurationsFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerExportDestinationConfigurationsFactory, T1, T2, InnerExportS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<InnerExportDestinationConfigurationsFactory, T1, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportDestinationConfigurationsFactory, T2, InnerExportS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, InnerExportDestinationConfigurationsFactory, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExportDestinationConfigurationsFactory, InnerExportS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, T2, InnerExportDestinationConfigurationsFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerExportDestinationConfigurationsFactory, T1, T2, T3, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<InnerExportDestinationConfigurationsFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportDestinationConfigurationsFactory, T2, T3, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, InnerExportDestinationConfigurationsFactory, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExportDestinationConfigurationsFactory, T3, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, InnerExportDestinationConfigurationsFactory, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerExportDestinationConfigurationsFactory, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerExportDestinationConfigurationsFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerExportDestinationConfigurationsFactory, T1, T2, T3, T4, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<InnerExportDestinationConfigurationsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExportDestinationConfigurationsFactory, T2, T3, T4, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, InnerExportDestinationConfigurationsFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExportDestinationConfigurationsFactory, T3, T4, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerExportDestinationConfigurationsFactory, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerExportDestinationConfigurationsFactory, T4, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerExportDestinationConfigurationsFactory, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerExportDestinationConfigurationsFactory, InnerExportS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerExportDestinationConfigurationsFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T5, subFactoryAction));
}
