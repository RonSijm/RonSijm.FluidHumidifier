// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class HubFactory(string resourceName = null, Action<Humidifier.SageMaker.Hub> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Hub>(resourceName)
{

    internal InnerHubS3StorageConfigFactory S3StorageConfigFactory { get; set; }

    protected override Humidifier.SageMaker.Hub Create()
    {
        var hubResult = CreateHub();
        factoryAction?.Invoke(hubResult);

        return hubResult;
    }

    private Humidifier.SageMaker.Hub CreateHub()
    {
        var hubResult = new Humidifier.SageMaker.Hub
        {
            GivenName = InputResourceName,
        };

        return hubResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Hub result)
    {
        base.CreateChildren(result);

        result.S3StorageConfig ??= S3StorageConfigFactory?.Build();
    }

} // End Of Class

public static class HubFactoryExtensions
{
    public static CombinedResult<HubFactory, InnerHubS3StorageConfigFactory> WithS3StorageConfig(this HubFactory parentFactory, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null)
    {
        parentFactory.S3StorageConfigFactory = new InnerHubS3StorageConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3StorageConfigFactory);
    }

    public static CombinedResult<HubFactory, T1, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1>(this CombinedResult<HubFactory, T1> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubFactory, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1>(this CombinedResult<T1, HubFactory> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<HubFactory, T1, T2, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2>(this CombinedResult<HubFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubFactory, T2, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2>(this CombinedResult<T1, HubFactory, T2> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HubFactory, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2>(this CombinedResult<T1, T2, HubFactory> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<HubFactory, T1, T2, T3, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<HubFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubFactory, T2, T3, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<T1, HubFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HubFactory, T3, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<T1, T2, HubFactory, T3> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HubFactory, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, HubFactory> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<HubFactory, T1, T2, T3, T4, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<HubFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubFactory, T2, T3, T4, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, HubFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HubFactory, T3, T4, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, HubFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HubFactory, T4, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HubFactory, T4> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, HubFactory, InnerHubS3StorageConfigFactory> WithS3StorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HubFactory> combinedResult, Action<Humidifier.SageMaker.HubTypes.S3StorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3StorageConfig(combinedResult.T5, subFactoryAction).T2);
}
