// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class WorkspaceIpGroupFactory(string resourceName = null, Action<Humidifier.WorkSpaces.WorkspaceIpGroup> factoryAction = null) : ResourceFactory<Humidifier.WorkSpaces.WorkspaceIpGroup>(resourceName)
{

    internal List<InnerWorkspaceIpGroupIpRuleItemFactory> UserRulesFactories { get; set; } = [];

    protected override Humidifier.WorkSpaces.WorkspaceIpGroup Create()
    {
        var workspaceIpGroupResult = CreateWorkspaceIpGroup();
        factoryAction?.Invoke(workspaceIpGroupResult);

        return workspaceIpGroupResult;
    }

    private Humidifier.WorkSpaces.WorkspaceIpGroup CreateWorkspaceIpGroup()
    {
        var workspaceIpGroupResult = new Humidifier.WorkSpaces.WorkspaceIpGroup
        {
            GivenName = InputResourceName,
        };

        return workspaceIpGroupResult;
    }
    public override void CreateChildren(Humidifier.WorkSpaces.WorkspaceIpGroup result)
    {
        base.CreateChildren(result);

        result.UserRules = UserRulesFactories.Any() ? UserRulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class WorkspaceIpGroupFactoryExtensions
{
    public static CombinedResult<WorkspaceIpGroupFactory, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules(this WorkspaceIpGroupFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null)
    {
        var factory = new InnerWorkspaceIpGroupIpRuleItemFactory(subFactoryAction);
        parentFactory.UserRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkspaceIpGroupFactory, T1, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1>(this CombinedResult<WorkspaceIpGroupFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceIpGroupFactory, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1>(this CombinedResult<T1, WorkspaceIpGroupFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceIpGroupFactory, T1, T2, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2>(this CombinedResult<WorkspaceIpGroupFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceIpGroupFactory, T2, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2>(this CombinedResult<T1, WorkspaceIpGroupFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceIpGroupFactory, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2>(this CombinedResult<T1, T2, WorkspaceIpGroupFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceIpGroupFactory, T1, T2, T3, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3>(this CombinedResult<WorkspaceIpGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceIpGroupFactory, T2, T3, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3>(this CombinedResult<T1, WorkspaceIpGroupFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceIpGroupFactory, T3, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceIpGroupFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceIpGroupFactory, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceIpGroupFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceIpGroupFactory, T1, T2, T3, T4, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3, T4>(this CombinedResult<WorkspaceIpGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceIpGroupFactory, T2, T3, T4, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceIpGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceIpGroupFactory, T3, T4, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceIpGroupFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceIpGroupFactory, T4, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceIpGroupFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceIpGroupFactory, InnerWorkspaceIpGroupIpRuleItemFactory> WithUserRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceIpGroupFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserRules(combinedResult.T5, subFactoryAction).T2);
}
