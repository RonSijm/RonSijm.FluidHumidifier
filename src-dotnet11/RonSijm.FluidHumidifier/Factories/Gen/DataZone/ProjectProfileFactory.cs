// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class ProjectProfileFactory(string resourceName = null, Action<Humidifier.DataZone.ProjectProfile> factoryAction = null) : ResourceFactory<Humidifier.DataZone.ProjectProfile>(resourceName)
{

    internal List<InnerProjectProfileEnvironmentConfigurationFactory> EnvironmentConfigurationsFactories { get; set; } = [];

    internal List<InnerProjectProfileResourceTagParameterFactory> ProjectResourceTagsFactories { get; set; } = [];

    protected override Humidifier.DataZone.ProjectProfile Create()
    {
        var projectProfileResult = CreateProjectProfile();
        factoryAction?.Invoke(projectProfileResult);

        return projectProfileResult;
    }

    private Humidifier.DataZone.ProjectProfile CreateProjectProfile()
    {
        var projectProfileResult = new Humidifier.DataZone.ProjectProfile
        {
            GivenName = InputResourceName,
        };

        return projectProfileResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ProjectProfile result)
    {
        base.CreateChildren(result);

        result.EnvironmentConfigurations = EnvironmentConfigurationsFactories.Any() ? EnvironmentConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.ProjectResourceTags = ProjectResourceTagsFactories.Any() ? ProjectResourceTagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ProjectProfileFactoryExtensions
{
    public static CombinedResult<ProjectProfileFactory, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations(this ProjectProfileFactory parentFactory, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null)
    {
        var factory = new InnerProjectProfileEnvironmentConfigurationFactory(subFactoryAction);
        parentFactory.EnvironmentConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProjectProfileFactory, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags(this ProjectProfileFactory parentFactory, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null)
    {
        var factory = new InnerProjectProfileResourceTagParameterFactory(subFactoryAction);
        parentFactory.ProjectResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProjectProfileFactory, T1, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1>(this CombinedResult<ProjectProfileFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1>(this CombinedResult<T1, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, T2, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2>(this CombinedResult<ProjectProfileFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, T2, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2>(this CombinedResult<T1, ProjectProfileFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectProfileFactory, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2>(this CombinedResult<T1, T2, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, T2, T3, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3>(this CombinedResult<ProjectProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, T2, T3, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3>(this CombinedResult<T1, ProjectProfileFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectProfileFactory, T3, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, ProjectProfileFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectProfileFactory, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, T2, T3, T4, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3, T4>(this CombinedResult<ProjectProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, T2, T3, T4, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, ProjectProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectProfileFactory, T3, T4, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectProfileFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectProfileFactory, T4, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectProfileFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectProfileFactory, InnerProjectProfileEnvironmentConfigurationFactory> WithEnvironmentConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfigurations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1>(this CombinedResult<ProjectProfileFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1>(this CombinedResult<T1, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, T2, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2>(this CombinedResult<ProjectProfileFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, T2, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2>(this CombinedResult<T1, ProjectProfileFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectProfileFactory, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2>(this CombinedResult<T1, T2, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, T2, T3, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3>(this CombinedResult<ProjectProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, T2, T3, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3>(this CombinedResult<T1, ProjectProfileFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectProfileFactory, T3, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, ProjectProfileFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectProfileFactory, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectProfileFactory, T1, T2, T3, T4, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3, T4>(this CombinedResult<ProjectProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectProfileFactory, T2, T3, T4, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, ProjectProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectProfileFactory, T3, T4, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectProfileFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectProfileFactory, T4, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectProfileFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectProfileFactory, InnerProjectProfileResourceTagParameterFactory> WithProjectResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectProfileFactory> combinedResult, Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectResourceTags(combinedResult.T5, subFactoryAction).T2);
}
