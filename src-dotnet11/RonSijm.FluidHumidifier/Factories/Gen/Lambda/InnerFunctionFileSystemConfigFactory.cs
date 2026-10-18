// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionFileSystemConfigFactory(Action<Humidifier.Lambda.FunctionTypes.FileSystemConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.FileSystemConfig>
{

    internal InnerFunctionS3FilesConfigFactory S3FilesConfigFactory { get; set; }

    protected override Humidifier.Lambda.FunctionTypes.FileSystemConfig Create()
    {
        var fileSystemConfigResult = CreateFileSystemConfig();
        factoryAction?.Invoke(fileSystemConfigResult);

        return fileSystemConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.FileSystemConfig CreateFileSystemConfig()
    {
        var fileSystemConfigResult = new Humidifier.Lambda.FunctionTypes.FileSystemConfig();

        return fileSystemConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.FunctionTypes.FileSystemConfig result)
    {
        base.CreateChildren(result);

        result.S3FilesConfig ??= S3FilesConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionFileSystemConfigFactoryExtensions
{
    public static CombinedResult<InnerFunctionFileSystemConfigFactory, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig(this InnerFunctionFileSystemConfigFactory parentFactory, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null)
    {
        parentFactory.S3FilesConfigFactory = new InnerFunctionS3FilesConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3FilesConfigFactory);
    }

    public static CombinedResult<InnerFunctionFileSystemConfigFactory, T1, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1>(this CombinedResult<InnerFunctionFileSystemConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionFileSystemConfigFactory, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1>(this CombinedResult<T1, InnerFunctionFileSystemConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFunctionFileSystemConfigFactory, T1, T2, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2>(this CombinedResult<InnerFunctionFileSystemConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionFileSystemConfigFactory, T2, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2>(this CombinedResult<T1, InnerFunctionFileSystemConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFunctionFileSystemConfigFactory, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2>(this CombinedResult<T1, T2, InnerFunctionFileSystemConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFunctionFileSystemConfigFactory, T1, T2, T3, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3>(this CombinedResult<InnerFunctionFileSystemConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionFileSystemConfigFactory, T2, T3, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3>(this CombinedResult<T1, InnerFunctionFileSystemConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFunctionFileSystemConfigFactory, T3, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionFileSystemConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFunctionFileSystemConfigFactory, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionFileSystemConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFunctionFileSystemConfigFactory, T1, T2, T3, T4, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3, T4>(this CombinedResult<InnerFunctionFileSystemConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionFileSystemConfigFactory, T2, T3, T4, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionFileSystemConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFunctionFileSystemConfigFactory, T3, T4, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionFileSystemConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFunctionFileSystemConfigFactory, T4, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionFileSystemConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionFileSystemConfigFactory, InnerFunctionS3FilesConfigFactory> WithS3FilesConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionFileSystemConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FilesConfig(combinedResult.T5, subFactoryAction).T2);
}
