// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupNotStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.NotStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.NotStatement>
{

    internal InnerRuleGroupStatementFactory StatementFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.NotStatement Create()
    {
        var notStatementResult = CreateNotStatement();
        factoryAction?.Invoke(notStatementResult);

        return notStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.NotStatement CreateNotStatement()
    {
        var notStatementResult = new Humidifier.WAFv2.RuleGroupTypes.NotStatement();

        return notStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.NotStatement result)
    {
        base.CreateChildren(result);

        result.Statement ??= StatementFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupNotStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupNotStatementFactory, InnerRuleGroupStatementFactory> WithStatement(this InnerRuleGroupNotStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null)
    {
        parentFactory.StatementFactory = new InnerRuleGroupStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatementFactory);
    }

    public static CombinedResult<InnerRuleGroupNotStatementFactory, T1, InnerRuleGroupStatementFactory> WithStatement<T1>(this CombinedResult<InnerRuleGroupNotStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupNotStatementFactory, InnerRuleGroupStatementFactory> WithStatement<T1>(this CombinedResult<T1, InnerRuleGroupNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupNotStatementFactory, T1, T2, InnerRuleGroupStatementFactory> WithStatement<T1, T2>(this CombinedResult<InnerRuleGroupNotStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupNotStatementFactory, T2, InnerRuleGroupStatementFactory> WithStatement<T1, T2>(this CombinedResult<T1, InnerRuleGroupNotStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupNotStatementFactory, InnerRuleGroupStatementFactory> WithStatement<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupNotStatementFactory, T1, T2, T3, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<InnerRuleGroupNotStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupNotStatementFactory, T2, T3, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupNotStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupNotStatementFactory, T3, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupNotStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupNotStatementFactory, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupNotStatementFactory, T1, T2, T3, T4, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupNotStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupNotStatementFactory, T2, T3, T4, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupNotStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupNotStatementFactory, T3, T4, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupNotStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupNotStatementFactory, T4, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupNotStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupNotStatementFactory, InnerRuleGroupStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T5, subFactoryAction));
}
