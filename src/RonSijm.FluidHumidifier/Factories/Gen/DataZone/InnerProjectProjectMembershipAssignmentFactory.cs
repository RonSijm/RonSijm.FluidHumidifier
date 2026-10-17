// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectProjectMembershipAssignmentFactory(Action<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment>
{

    internal InnerProjectMemberFactory MemberFactory { get; set; }

    protected override Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment Create()
    {
        var projectMembershipAssignmentResult = CreateProjectMembershipAssignment();
        factoryAction?.Invoke(projectMembershipAssignmentResult);

        return projectMembershipAssignmentResult;
    }

    private Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment CreateProjectMembershipAssignment()
    {
        var projectMembershipAssignmentResult = new Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment();

        return projectMembershipAssignmentResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ProjectTypes.ProjectMembershipAssignment result)
    {
        base.CreateChildren(result);

        result.Member ??= MemberFactory?.Build();
    }

} // End Of Class

public static class InnerProjectProjectMembershipAssignmentFactoryExtensions
{
    public static CombinedResult<InnerProjectProjectMembershipAssignmentFactory, InnerProjectMemberFactory> WithMember(this InnerProjectProjectMembershipAssignmentFactory parentFactory, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null)
    {
        parentFactory.MemberFactory = new InnerProjectMemberFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberFactory);
    }

    public static CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, InnerProjectMemberFactory> WithMember<T1>(this CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, InnerProjectMemberFactory> WithMember<T1>(this CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, T2, InnerProjectMemberFactory> WithMember<T1, T2>(this CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, T2, InnerProjectMemberFactory> WithMember<T1, T2>(this CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, T2> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectProjectMembershipAssignmentFactory, InnerProjectMemberFactory> WithMember<T1, T2>(this CombinedResult<T1, T2, InnerProjectProjectMembershipAssignmentFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, T2, T3, InnerProjectMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, T2, T3, InnerProjectMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectProjectMembershipAssignmentFactory, T3, InnerProjectMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectProjectMembershipAssignmentFactory, T3> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProjectProjectMembershipAssignmentFactory, InnerProjectMemberFactory> WithMember<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectProjectMembershipAssignmentFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, T2, T3, T4, InnerProjectMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<InnerProjectProjectMembershipAssignmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, T2, T3, T4, InnerProjectMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectProjectMembershipAssignmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProjectProjectMembershipAssignmentFactory, T3, T4, InnerProjectMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectProjectMembershipAssignmentFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProjectProjectMembershipAssignmentFactory, T4, InnerProjectMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectProjectMembershipAssignmentFactory, T4> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProjectProjectMembershipAssignmentFactory, InnerProjectMemberFactory> WithMember<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectProjectMembershipAssignmentFactory> combinedResult, Action<Humidifier.DataZone.ProjectTypes.Member> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMember(combinedResult.T5, subFactoryAction).T2);
}
