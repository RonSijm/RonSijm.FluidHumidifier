// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationDeployAsApplicationConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration>
{

    internal InnerApplicationS3ContentBaseLocationFactory S3ContentLocationFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration Create()
    {
        var deployAsApplicationConfigurationResult = CreateDeployAsApplicationConfiguration();
        factoryAction?.Invoke(deployAsApplicationConfigurationResult);

        return deployAsApplicationConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration CreateDeployAsApplicationConfiguration()
    {
        var deployAsApplicationConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration();

        return deployAsApplicationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationTypes.DeployAsApplicationConfiguration result)
    {
        base.CreateChildren(result);

        result.S3ContentLocation ??= S3ContentLocationFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationDeployAsApplicationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation(this InnerApplicationDeployAsApplicationConfigurationFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null)
    {
        parentFactory.S3ContentLocationFactory = new InnerApplicationS3ContentBaseLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ContentLocationFactory);
    }

    public static CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1>(this CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1>(this CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, T2, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2>(this CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, T2, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2>(this CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationDeployAsApplicationConfigurationFactory, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2>(this CombinedResult<T1, T2, InnerApplicationDeployAsApplicationConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, T2, T3, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, T2, T3, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationDeployAsApplicationConfigurationFactory, T3, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationDeployAsApplicationConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationDeployAsApplicationConfigurationFactory, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationDeployAsApplicationConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, T2, T3, T4, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<InnerApplicationDeployAsApplicationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, T2, T3, T4, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationDeployAsApplicationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationDeployAsApplicationConfigurationFactory, T3, T4, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationDeployAsApplicationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationDeployAsApplicationConfigurationFactory, T4, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationDeployAsApplicationConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationDeployAsApplicationConfigurationFactory, InnerApplicationS3ContentBaseLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationDeployAsApplicationConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T5, subFactoryAction));
}
