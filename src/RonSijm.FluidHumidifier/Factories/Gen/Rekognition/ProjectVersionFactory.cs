// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class ProjectVersionFactory(string resourceName = null, Action<Humidifier.Rekognition.ProjectVersion> factoryAction = null) : ResourceFactory<Humidifier.Rekognition.ProjectVersion>(resourceName)
{

    internal InnerProjectVersionOutputConfigFactory OutputConfigFactory { get; set; }

    internal InnerProjectVersionCustomizationFeatureConfigFactory FeatureConfigFactory { get; set; }

    protected override Humidifier.Rekognition.ProjectVersion Create()
    {
        var projectVersionResult = CreateProjectVersion();
        factoryAction?.Invoke(projectVersionResult);

        return projectVersionResult;
    }

    private Humidifier.Rekognition.ProjectVersion CreateProjectVersion()
    {
        var projectVersionResult = new Humidifier.Rekognition.ProjectVersion
        {
            GivenName = InputResourceName,
        };

        return projectVersionResult;
    }
    public override void CreateChildren(Humidifier.Rekognition.ProjectVersion result)
    {
        base.CreateChildren(result);

        result.OutputConfig ??= OutputConfigFactory?.Build();
        result.FeatureConfig ??= FeatureConfigFactory?.Build();
    }

} // End Of Class

public static class ProjectVersionFactoryExtensions
{
    public static CombinedResult<ProjectVersionFactory, InnerProjectVersionOutputConfigFactory> WithOutputConfig(this ProjectVersionFactory parentFactory, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null)
    {
        parentFactory.OutputConfigFactory = new InnerProjectVersionOutputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputConfigFactory);
    }

    public static CombinedResult<ProjectVersionFactory, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig(this ProjectVersionFactory parentFactory, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null)
    {
        parentFactory.FeatureConfigFactory = new InnerProjectVersionCustomizationFeatureConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FeatureConfigFactory);
    }

    public static CombinedResult<ProjectVersionFactory, T1, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<ProjectVersionFactory, T1> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<T1, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, T2, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<ProjectVersionFactory, T1, T2> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, T2, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, ProjectVersionFactory, T2> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectVersionFactory, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, T2, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, T2, T3, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<ProjectVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, T2, T3, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, ProjectVersionFactory, T2, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectVersionFactory, T3, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, ProjectVersionFactory, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectVersionFactory, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, T2, T3, T4, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<ProjectVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, T2, T3, T4, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, ProjectVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectVersionFactory, T3, T4, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectVersionFactory, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectVersionFactory, T4, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectVersionFactory, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectVersionFactory, InnerProjectVersionOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1>(this CombinedResult<ProjectVersionFactory, T1> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeatureConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1>(this CombinedResult<T1, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFeatureConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, T2, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2>(this CombinedResult<ProjectVersionFactory, T1, T2> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, T2, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2>(this CombinedResult<T1, ProjectVersionFactory, T2> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectVersionFactory, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2>(this CombinedResult<T1, T2, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, T2, T3, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3>(this CombinedResult<ProjectVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, T2, T3, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3>(this CombinedResult<T1, ProjectVersionFactory, T2, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectVersionFactory, T3, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3>(this CombinedResult<T1, T2, ProjectVersionFactory, T3> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectVersionFactory, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectVersionFactory, T1, T2, T3, T4, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3, T4>(this CombinedResult<ProjectVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectVersionFactory, T2, T3, T4, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3, T4>(this CombinedResult<T1, ProjectVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectVersionFactory, T3, T4, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectVersionFactory, T3, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectVersionFactory, T4, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectVersionFactory, T4> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectVersionFactory, InnerProjectVersionCustomizationFeatureConfigFactory> WithFeatureConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectVersionFactory> combinedResult, Action<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFeatureConfig(combinedResult.T5, subFactoryAction).T2);
}
