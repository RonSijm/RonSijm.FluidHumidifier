// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerDatasetExportJobDatasetExportJobOutputFactory(Action<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput>
{

    internal InnerDatasetExportJobS3DataConfigFactory S3DataDestinationFactory { get; set; }

    protected override Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput Create()
    {
        var datasetExportJobOutputResult = CreateDatasetExportJobOutput();
        factoryAction?.Invoke(datasetExportJobOutputResult);

        return datasetExportJobOutputResult;
    }

    private Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput CreateDatasetExportJobOutput()
    {
        var datasetExportJobOutputResult = new Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput();

        return datasetExportJobOutputResult;
    }
    public override void CreateChildren(Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput result)
    {
        base.CreateChildren(result);

        result.S3DataDestination ??= S3DataDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetExportJobDatasetExportJobOutputFactoryExtensions
{
    public static CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination(this InnerDatasetExportJobDatasetExportJobOutputFactory parentFactory, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null)
    {
        parentFactory.S3DataDestinationFactory = new InnerDatasetExportJobS3DataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataDestinationFactory);
    }

    public static CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1>(this CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1>(this CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, T2, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, T2, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, T2> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, T2, T3, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, T2, T3, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory, T3, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory, T3> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetExportJobDatasetExportJobOutputFactory, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetExportJobDatasetExportJobOutputFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, T2, T3, T4, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<InnerDatasetExportJobDatasetExportJobOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, T2, T3, T4, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetExportJobDatasetExportJobOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory, T3, T4, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetExportJobDatasetExportJobOutputFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetExportJobDatasetExportJobOutputFactory, T4, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetExportJobDatasetExportJobOutputFactory, T4> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetExportJobDatasetExportJobOutputFactory, InnerDatasetExportJobS3DataConfigFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetExportJobDatasetExportJobOutputFactory> combinedResult, Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T5, subFactoryAction).T2);
}
