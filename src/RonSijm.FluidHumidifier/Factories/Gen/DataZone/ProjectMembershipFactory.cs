// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class ProjectMembershipFactory(string resourceName = null, Action<Humidifier.DataZone.ProjectMembership> factoryAction = null) : ResourceFactory<Humidifier.DataZone.ProjectMembership>(resourceName)
{

    internal InnerProjectMembershipMemberFactory MemberFactory { get; set; }

    protected override Humidifier.DataZone.ProjectMembership Create()
    {
        var projectMembershipResult = CreateProjectMembership();
        factoryAction?.Invoke(projectMembershipResult);

        return projectMembershipResult;
    }

    private Humidifier.DataZone.ProjectMembership CreateProjectMembership()
    {
        var projectMembershipResult = new Humidifier.DataZone.ProjectMembership
        {
            GivenName = InputResourceName,
        };

        return projectMembershipResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ProjectMembership result)
    {
        base.CreateChildren(result);

        result.Member ??= MemberFactory?.Build();
    }

} // End Of Class

public static class ProjectMembershipFactoryExtensions
{
    public static CombinedResult<ProjectMembershipFactory, InnerProjectMembershipMemberFactory> WithMember(this ProjectMembershipFactory parentFactory, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null)
    {
        parentFactory.MemberFactory = new InnerProjectMembershipMemberFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberFactory);
    }

    public static CombinedResult<ProjectMembershipFactory, T1, InnerProjectMembershipMemberFactory> WithMember<T1>(this CombinedResult<ProjectMembershipFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectMembershipFactory, InnerProjectMembershipMemberFactory> WithMember<T1>(this CombinedResult<T1, ProjectMembershipFactory> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectMembershipFactory, T1, T2, InnerProjectMembershipMemberFactory> WithMember<T1, T2>(this CombinedResult<ProjectMembershipFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectMembershipFactory, T2, InnerProjectMembershipMemberFactory> WithMember<T1, T2>(this CombinedResult<T1, ProjectMembershipFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectMembershipFactory, InnerProjectMembershipMemberFactory> WithMember<T1, T2>(this CombinedResult<T1, T2, ProjectMembershipFactory> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectMembershipFactory, T1, T2, T3, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<ProjectMembershipFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectMembershipFactory, T2, T3, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<T1, ProjectMembershipFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectMembershipFactory, T3, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<T1, T2, ProjectMembershipFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectMembershipFactory, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectMembershipFactory> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectMembershipFactory, T1, T2, T3, T4, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<ProjectMembershipFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectMembershipFactory, T2, T3, T4, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, ProjectMembershipFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectMembershipFactory, T3, T4, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectMembershipFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectMembershipFactory, T4, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectMembershipFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectMembershipFactory, InnerProjectMembershipMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectMembershipFactory> combinedResult, Action<Humidifier.DataZone.ProjectMembershipTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T5, subFactoryAction));
}
