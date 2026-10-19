// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerProjectVersionCustomizationFeatureConfigFactory(Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig>
{

    internal InnerProjectVersionContentModerationConfigFactory ContentModerationFactory { get; set; }

    protected override Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig Create()
    {
        var customizationFeatureConfigResult = CreateCustomizationFeatureConfig();
        factoryAction?.Invoke(customizationFeatureConfigResult);

        return customizationFeatureConfigResult;
    }

    private Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig CreateCustomizationFeatureConfig()
    {
        var customizationFeatureConfigResult = new Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig();

        return customizationFeatureConfigResult;
    }
    public override void CreateChildren(Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig result)
    {
        base.CreateChildren(result);

        result.ContentModeration ??= ContentModerationFactory?.Build();
    }

} // End Of Class

public static class InnerProjectVersionCustomizationFeatureConfigFactoryExtensions
{
    public static CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, InnerProjectVersionContentModerationConfigFactory> WithContentModeration(this InnerProjectVersionCustomizationFeatureConfigFactory parentFactory, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null)
    {
        parentFactory.ContentModerationFactory = new InnerProjectVersionContentModerationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentModerationFactory);
    }

    public static CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1>(this CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentModeration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1>(this CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentModeration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, T2, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2>(this CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, T2> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, T2, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2>(this CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, T2> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2>(this CombinedResult<T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, T2, T3, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3>(this CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, T2, T3, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3>(this CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, T2, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory, T3, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProjectVersionCustomizationFeatureConfigFactory, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectVersionCustomizationFeatureConfigFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, T2, T3, T4, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3, T4>(this CombinedResult<InnerProjectVersionCustomizationFeatureConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, T2, T3, T4, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectVersionCustomizationFeatureConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory, T3, T4, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProjectVersionCustomizationFeatureConfigFactory, T4, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectVersionCustomizationFeatureConfigFactory, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProjectVersionCustomizationFeatureConfigFactory, InnerProjectVersionContentModerationConfigFactory> WithContentModeration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectVersionCustomizationFeatureConfigFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentModeration(combinedResult.T5, subFactoryAction).T2);
}
