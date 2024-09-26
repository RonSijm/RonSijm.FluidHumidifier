// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class DetectorFactory(string resourceName = null, Action<Humidifier.GuardDuty.Detector> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.Detector>(resourceName)
{

    internal List<InnerDetectorCFNFeatureConfigurationFactory> FeaturesFactories { get; set; } = [];

    internal List<InnerDetectorTagItemFactory> TagsFactories { get; set; } = [];

    internal InnerDetectorCFNDataSourceConfigurationsFactory DataSourcesFactory { get; set; }

    protected override Humidifier.GuardDuty.Detector Create()
    {
        var detectorResult = CreateDetector();
        factoryAction?.Invoke(detectorResult);

        return detectorResult;
    }

    private Humidifier.GuardDuty.Detector CreateDetector()
    {
        var detectorResult = new Humidifier.GuardDuty.Detector
        {
            GivenName = InputResourceName,
        };

        return detectorResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.Detector result)
    {
        base.CreateChildren(result);

        result.Features = FeaturesFactories.Any() ? FeaturesFactories.Select(x => x.Build()).ToList() : null;
        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.DataSources ??= DataSourcesFactory?.Build();
    }

} // End Of Class

public static class DetectorFactoryExtensions
{
    public static CombinedResult<DetectorFactory, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures(this DetectorFactory parentFactory, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null)
    {
        var factory = new InnerDetectorCFNFeatureConfigurationFactory(subFactoryAction);
        parentFactory.FeaturesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DetectorFactory, InnerDetectorTagItemFactory> WithTags(this DetectorFactory parentFactory, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerDetectorTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DetectorFactory, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources(this DetectorFactory parentFactory, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null)
    {
        parentFactory.DataSourcesFactory = new InnerDetectorCFNDataSourceConfigurationsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourcesFactory);
    }

    public static CombinedResult<DetectorFactory, T1, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1>(this CombinedResult<DetectorFactory, T1> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1>(this CombinedResult<T1, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2>(this CombinedResult<DetectorFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2>(this CombinedResult<T1, DetectorFactory, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2>(this CombinedResult<T1, T2, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3>(this CombinedResult<DetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3>(this CombinedResult<T1, DetectorFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3>(this CombinedResult<T1, T2, DetectorFactory, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, T4, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<DetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, T4, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, DetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, T4, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, T4, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorFactory, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorFactory, InnerDetectorCFNFeatureConfigurationFactory> WithFeatures<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatures(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, InnerDetectorTagItemFactory> WithTags<T1>(this CombinedResult<DetectorFactory, T1> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, InnerDetectorTagItemFactory> WithTags<T1>(this CombinedResult<T1, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, InnerDetectorTagItemFactory> WithTags<T1, T2>(this CombinedResult<DetectorFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, InnerDetectorTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, DetectorFactory, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, InnerDetectorTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, InnerDetectorTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<DetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, InnerDetectorTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DetectorFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, InnerDetectorTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DetectorFactory, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, InnerDetectorTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, T4, InnerDetectorTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, T4, InnerDetectorTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, T4, InnerDetectorTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, T4, InnerDetectorTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorFactory, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorFactory, InnerDetectorTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1>(this CombinedResult<DetectorFactory, T1> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1>(this CombinedResult<T1, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2>(this CombinedResult<DetectorFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2>(this CombinedResult<T1, DetectorFactory, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2>(this CombinedResult<T1, T2, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3>(this CombinedResult<DetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, DetectorFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, T2, DetectorFactory, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, T4, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<DetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, T4, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, DetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, T4, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, T4, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorFactory, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorFactory, InnerDetectorCFNDataSourceConfigurationsFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNDataSourceConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T5, subFactoryAction));
}
