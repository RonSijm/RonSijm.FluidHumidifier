// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class PatchBaselineFactory(string resourceName = null, Action<Humidifier.SSM.PatchBaseline> factoryAction = null) : ResourceFactory<Humidifier.SSM.PatchBaseline>(resourceName)
{

    internal List<InnerPatchBaselinePatchSourceFactory> SourcesFactories { get; set; } = [];

    internal InnerPatchBaselineRuleGroupFactory ApprovalRulesFactory { get; set; }

    internal InnerPatchBaselinePatchFilterGroupFactory GlobalFiltersFactory { get; set; }

    protected override Humidifier.SSM.PatchBaseline Create()
    {
        var patchBaselineResult = CreatePatchBaseline();
        factoryAction?.Invoke(patchBaselineResult);

        return patchBaselineResult;
    }

    private Humidifier.SSM.PatchBaseline CreatePatchBaseline()
    {
        var patchBaselineResult = new Humidifier.SSM.PatchBaseline
        {
            GivenName = InputResourceName,
        };

        return patchBaselineResult;
    }
    public override void CreateChildren(Humidifier.SSM.PatchBaseline result)
    {
        base.CreateChildren(result);

        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
        result.ApprovalRules ??= ApprovalRulesFactory?.Build();
        result.GlobalFilters ??= GlobalFiltersFactory?.Build();
    }

} // End Of Class

public static class PatchBaselineFactoryExtensions
{
    public static CombinedResult<PatchBaselineFactory, InnerPatchBaselinePatchSourceFactory> WithSources(this PatchBaselineFactory parentFactory, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null)
    {
        var factory = new InnerPatchBaselinePatchSourceFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PatchBaselineFactory, InnerPatchBaselineRuleGroupFactory> WithApprovalRules(this PatchBaselineFactory parentFactory, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null)
    {
        parentFactory.ApprovalRulesFactory = new InnerPatchBaselineRuleGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApprovalRulesFactory);
    }

    public static CombinedResult<PatchBaselineFactory, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters(this PatchBaselineFactory parentFactory, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null)
    {
        parentFactory.GlobalFiltersFactory = new InnerPatchBaselinePatchFilterGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlobalFiltersFactory);
    }

    public static CombinedResult<PatchBaselineFactory, T1, InnerPatchBaselinePatchSourceFactory> WithSources<T1>(this CombinedResult<PatchBaselineFactory, T1> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, InnerPatchBaselinePatchSourceFactory> WithSources<T1>(this CombinedResult<T1, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2>(this CombinedResult<PatchBaselineFactory, T1, T2> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, PatchBaselineFactory, T2> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, T3, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<PatchBaselineFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, T3, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, PatchBaselineFactory, T2, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, T3, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, PatchBaselineFactory, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PatchBaselineFactory, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, T3, T4, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<PatchBaselineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, T3, T4, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, PatchBaselineFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, T3, T4, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, PatchBaselineFactory, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PatchBaselineFactory, T4, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PatchBaselineFactory, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PatchBaselineFactory, InnerPatchBaselinePatchSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1>(this CombinedResult<PatchBaselineFactory, T1> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovalRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1>(this CombinedResult<T1, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovalRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2>(this CombinedResult<PatchBaselineFactory, T1, T2> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2>(this CombinedResult<T1, PatchBaselineFactory, T2> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2>(this CombinedResult<T1, T2, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, T3, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3>(this CombinedResult<PatchBaselineFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, T3, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3>(this CombinedResult<T1, PatchBaselineFactory, T2, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, T3, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3>(this CombinedResult<T1, T2, PatchBaselineFactory, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PatchBaselineFactory, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, T3, T4, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3, T4>(this CombinedResult<PatchBaselineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, T3, T4, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3, T4>(this CombinedResult<T1, PatchBaselineFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, T3, T4, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, PatchBaselineFactory, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PatchBaselineFactory, T4, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PatchBaselineFactory, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PatchBaselineFactory, InnerPatchBaselineRuleGroupFactory> WithApprovalRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1>(this CombinedResult<PatchBaselineFactory, T1> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1>(this CombinedResult<T1, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2>(this CombinedResult<PatchBaselineFactory, T1, T2> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2>(this CombinedResult<T1, PatchBaselineFactory, T2> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2>(this CombinedResult<T1, T2, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, T3, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3>(this CombinedResult<PatchBaselineFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, T3, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3>(this CombinedResult<T1, PatchBaselineFactory, T2, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, T3, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3>(this CombinedResult<T1, T2, PatchBaselineFactory, T3> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PatchBaselineFactory, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PatchBaselineFactory, T1, T2, T3, T4, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3, T4>(this CombinedResult<PatchBaselineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PatchBaselineFactory, T2, T3, T4, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3, T4>(this CombinedResult<T1, PatchBaselineFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PatchBaselineFactory, T3, T4, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, PatchBaselineFactory, T3, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PatchBaselineFactory, T4, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PatchBaselineFactory, T4> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PatchBaselineFactory, InnerPatchBaselinePatchFilterGroupFactory> WithGlobalFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PatchBaselineFactory> combinedResult, Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalFilters(combinedResult.T5, subFactoryAction));
}
