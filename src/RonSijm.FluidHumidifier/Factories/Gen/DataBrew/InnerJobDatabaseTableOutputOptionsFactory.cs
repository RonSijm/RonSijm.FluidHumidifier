// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobDatabaseTableOutputOptionsFactory(Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions>
{

    internal InnerJobS3LocationFactory TempDirectoryFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions Create()
    {
        var databaseTableOutputOptionsResult = CreateDatabaseTableOutputOptions();
        factoryAction?.Invoke(databaseTableOutputOptionsResult);

        return databaseTableOutputOptionsResult;
    }

    private Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions CreateDatabaseTableOutputOptions()
    {
        var databaseTableOutputOptionsResult = new Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions();

        return databaseTableOutputOptionsResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions result)
    {
        base.CreateChildren(result);

        result.TempDirectory ??= TempDirectoryFactory?.Build();
    }

} // End Of Class

public static class InnerJobDatabaseTableOutputOptionsFactoryExtensions
{
    public static CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, InnerJobS3LocationFactory> WithTempDirectory(this InnerJobDatabaseTableOutputOptionsFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.TempDirectoryFactory = new InnerJobS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TempDirectoryFactory);
    }

    public static CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, InnerJobS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, InnerJobS3LocationFactory> WithTempDirectory<T1>(this CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, T2, InnerJobS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, T2, InnerJobS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDatabaseTableOutputOptionsFactory, InnerJobS3LocationFactory> WithTempDirectory<T1, T2>(this CombinedResult<T1, T2, InnerJobDatabaseTableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, T2, T3, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, T2, T3, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDatabaseTableOutputOptionsFactory, T3, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDatabaseTableOutputOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDatabaseTableOutputOptionsFactory, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDatabaseTableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, T2, T3, T4, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<InnerJobDatabaseTableOutputOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, T2, T3, T4, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDatabaseTableOutputOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDatabaseTableOutputOptionsFactory, T3, T4, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDatabaseTableOutputOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDatabaseTableOutputOptionsFactory, T4, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDatabaseTableOutputOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDatabaseTableOutputOptionsFactory, InnerJobS3LocationFactory> WithTempDirectory<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTempDirectory(combinedResult.T5, subFactoryAction));
}
