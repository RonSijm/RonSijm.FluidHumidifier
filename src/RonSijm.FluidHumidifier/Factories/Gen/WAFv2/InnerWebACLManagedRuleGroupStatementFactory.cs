// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLManagedRuleGroupStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement>
{

    internal InnerWebACLStatementFactory ScopeDownStatementFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement Create()
    {
        var managedRuleGroupStatementResult = CreateManagedRuleGroupStatement();
        factoryAction?.Invoke(managedRuleGroupStatementResult);

        return managedRuleGroupStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement CreateManagedRuleGroupStatement()
    {
        var managedRuleGroupStatementResult = new Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement();

        return managedRuleGroupStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.ManagedRuleGroupStatement result)
    {
        base.CreateChildren(result);

        result.ScopeDownStatement ??= ScopeDownStatementFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLManagedRuleGroupStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement(this InnerWebACLManagedRuleGroupStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null)
    {
        parentFactory.ScopeDownStatementFactory = new InnerWebACLStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeDownStatementFactory);
    }

    public static CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, InnerWebACLStatementFactory> WithScopeDownStatement<T1>(this CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1>(this CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, T2, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, T2, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLManagedRuleGroupStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<T1, T2, InnerWebACLManagedRuleGroupStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, T2, T3, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, T2, T3, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLManagedRuleGroupStatementFactory, T3, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLManagedRuleGroupStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLManagedRuleGroupStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLManagedRuleGroupStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, T2, T3, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<InnerWebACLManagedRuleGroupStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, T2, T3, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLManagedRuleGroupStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLManagedRuleGroupStatementFactory, T3, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLManagedRuleGroupStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLManagedRuleGroupStatementFactory, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLManagedRuleGroupStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLManagedRuleGroupStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLManagedRuleGroupStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T5, subFactoryAction));
}
