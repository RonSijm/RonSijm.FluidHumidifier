// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelS3DataSourceFactory(Action<Humidifier.SageMaker.ModelTypes.S3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.S3DataSource>
{

    internal InnerModelModelAccessConfigFactory ModelAccessConfigFactory { get; set; }

    internal InnerModelHubAccessConfigFactory HubAccessConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelTypes.S3DataSource Create()
    {
        var s3DataSourceResult = CreateS3DataSource();
        factoryAction?.Invoke(s3DataSourceResult);

        return s3DataSourceResult;
    }

    private Humidifier.SageMaker.ModelTypes.S3DataSource CreateS3DataSource()
    {
        var s3DataSourceResult = new Humidifier.SageMaker.ModelTypes.S3DataSource();

        return s3DataSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelTypes.S3DataSource result)
    {
        base.CreateChildren(result);

        result.ModelAccessConfig ??= ModelAccessConfigFactory?.Build();
        result.HubAccessConfig ??= HubAccessConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelS3DataSourceFactoryExtensions
{
    public static CombinedResult<InnerModelS3DataSourceFactory, InnerModelModelAccessConfigFactory> WithModelAccessConfig(this InnerModelS3DataSourceFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null)
    {
        parentFactory.ModelAccessConfigFactory = new InnerModelModelAccessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelAccessConfigFactory);
    }

    public static CombinedResult<InnerModelS3DataSourceFactory, InnerModelHubAccessConfigFactory> WithHubAccessConfig(this InnerModelS3DataSourceFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null)
    {
        parentFactory.HubAccessConfigFactory = new InnerModelHubAccessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HubAccessConfigFactory);
    }

    public static CombinedResult<InnerModelS3DataSourceFactory, T1, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1>(this CombinedResult<InnerModelS3DataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1>(this CombinedResult<T1, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, T2, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2>(this CombinedResult<InnerModelS3DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, T2, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2>(this CombinedResult<T1, InnerModelS3DataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelS3DataSourceFactory, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3>(this CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3, T4, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3, T4, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3, T4, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory, T4, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelS3DataSourceFactory, InnerModelModelAccessConfigFactory> WithModelAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelAccessConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1>(this CombinedResult<InnerModelS3DataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1>(this CombinedResult<T1, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, T2, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2>(this CombinedResult<InnerModelS3DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, T2, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2>(this CombinedResult<T1, InnerModelS3DataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelS3DataSourceFactory, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3>(this CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3, T4, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelS3DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3, T4, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelS3DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3, T4, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelS3DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory, T4, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelS3DataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelS3DataSourceFactory, InnerModelHubAccessConfigFactory> WithHubAccessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelS3DataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.HubAccessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHubAccessConfig(combinedResult.T5, subFactoryAction));
}
