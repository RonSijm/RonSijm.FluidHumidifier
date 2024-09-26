// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetDataCatalogInputDefinitionFactory(Action<Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition>
{

    internal InnerDatasetS3LocationFactory TempDirectoryFactory { get; set; }

    protected override Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition Create()
    {
        var dataCatalogInputDefinitionResult = CreateDataCatalogInputDefinition();
        factoryAction?.Invoke(dataCatalogInputDefinitionResult);

        return dataCatalogInputDefinitionResult;
    }

    private Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition CreateDataCatalogInputDefinition()
    {
        var dataCatalogInputDefinitionResult = new Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition();

        return dataCatalogInputDefinitionResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition result)
    {
        base.CreateChildren(result);

        result.TempDirectory ??= TempDirectoryFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDataCatalogInputDefinitionFactoryExtensions
{
    public static CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory(this InnerDatasetDataCatalogInputDefinitionFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.TempDirectoryFactory = new InnerDatasetS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TempDirectoryFactory);
    }

    public static CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, InnerDatasetS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, T2, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, T2, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDataCatalogInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, T2, T3, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, T2, T3, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDataCatalogInputDefinitionFactory, T3, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDataCatalogInputDefinitionFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDataCatalogInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, T2, T3, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDataCatalogInputDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, T2, T3, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDataCatalogInputDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDataCatalogInputDefinitionFactory, T3, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDataCatalogInputDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDataCatalogInputDefinitionFactory, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDataCatalogInputDefinitionFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDataCatalogInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDataCatalogInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T5, subFactoryAction));
}
