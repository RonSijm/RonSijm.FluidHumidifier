// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetDatabaseInputDefinitionFactory(Action<Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition>
{

    internal InnerDatasetS3LocationFactory TempDirectoryFactory { get; set; }

    protected override Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition Create()
    {
        var databaseInputDefinitionResult = CreateDatabaseInputDefinition();
        factoryAction?.Invoke(databaseInputDefinitionResult);

        return databaseInputDefinitionResult;
    }

    private Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition CreateDatabaseInputDefinition()
    {
        var databaseInputDefinitionResult = new Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition();

        return databaseInputDefinitionResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition result)
    {
        base.CreateChildren(result);

        result.TempDirectory ??= TempDirectoryFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDatabaseInputDefinitionFactoryExtensions
{
    public static CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory(this InnerDatasetDatabaseInputDefinitionFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.TempDirectoryFactory = new InnerDatasetS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TempDirectoryFactory);
    }

    public static CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, InnerDatasetS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, T2, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, T2, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatabaseInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDatabaseInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, T2, T3, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, T2, T3, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatabaseInputDefinitionFactory, T3, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDatabaseInputDefinitionFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDatabaseInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDatabaseInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, T2, T3, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDatabaseInputDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, T2, T3, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDatabaseInputDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatabaseInputDefinitionFactory, T3, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDatabaseInputDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDatabaseInputDefinitionFactory, T4, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDatabaseInputDefinitionFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDatabaseInputDefinitionFactory, InnerDatasetS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDatabaseInputDefinitionFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T5, subFactoryAction));
}
