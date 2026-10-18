// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class ProjectFactory(string resourceName = null, Action<Humidifier.DataZone.Project> factoryAction = null) : ResourceFactory<Humidifier.DataZone.Project>(resourceName)
{

    internal List<InnerProjectEnvironmentConfigurationUserParameterFactory> UserParametersFactories { get; set; } = [];

    internal List<InnerProjectResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    internal List<InnerProjectProjectMembershipAssignmentFactory> MembershipAssignmentsFactories { get; set; } = [];

    protected override Humidifier.DataZone.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.DataZone.Project CreateProject()
    {
        var projectResult = new Humidifier.DataZone.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }
    public override void CreateChildren(Humidifier.DataZone.Project result)
    {
        base.CreateChildren(result);

        result.UserParameters = UserParametersFactories.Any() ? UserParametersFactories.Select(x => x.Build()).ToList() : null;
        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.MembershipAssignments = MembershipAssignmentsFactories.Any() ? MembershipAssignmentsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
    public static CombinedResult<ProjectFactory, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters(this ProjectFactory parentFactory, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null)
    {
        var factory = new InnerProjectEnvironmentConfigurationUserParameterFactory(subFactoryAction);
        parentFactory.UserParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProjectFactory, InnerProjectResourceTagFactory> WithResourceTags(this ProjectFactory parentFactory, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerProjectResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProjectFactory, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments(this ProjectFactory parentFactory, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null)
    {
        var factory = new InnerProjectProjectMembershipAssignmentFactory(subFactoryAction);
        parentFactory.MembershipAssignmentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProjectFactory, T1, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectEnvironmentConfigurationUserParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, InnerProjectResourceTagFactory> WithResourceTags<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, InnerProjectResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectProjectMembershipAssignmentFactory> WithMembershipAssignments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembershipAssignments(combinedResult.T5, subFactoryAction).T2);
}
