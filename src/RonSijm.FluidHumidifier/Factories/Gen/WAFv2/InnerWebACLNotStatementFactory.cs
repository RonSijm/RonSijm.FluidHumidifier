// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLNotStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.NotStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.NotStatement>
{

    internal InnerWebACLStatementFactory StatementFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.NotStatement Create()
    {
        var notStatementResult = CreateNotStatement();
        factoryAction?.Invoke(notStatementResult);

        return notStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.NotStatement CreateNotStatement()
    {
        var notStatementResult = new Humidifier.WAFv2.WebACLTypes.NotStatement();

        return notStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.NotStatement result)
    {
        base.CreateChildren(result);

        result.Statement ??= StatementFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLNotStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLNotStatementFactory, InnerWebACLStatementFactory> WithStatement(this InnerWebACLNotStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null)
    {
        parentFactory.StatementFactory = new InnerWebACLStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatementFactory);
    }

    public static CombinedResult<InnerWebACLNotStatementFactory, T1, InnerWebACLStatementFactory> WithStatement<T1>(this CombinedResult<InnerWebACLNotStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLNotStatementFactory, InnerWebACLStatementFactory> WithStatement<T1>(this CombinedResult<T1, InnerWebACLNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLNotStatementFactory, T1, T2, InnerWebACLStatementFactory> WithStatement<T1, T2>(this CombinedResult<InnerWebACLNotStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLNotStatementFactory, T2, InnerWebACLStatementFactory> WithStatement<T1, T2>(this CombinedResult<T1, InnerWebACLNotStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLNotStatementFactory, InnerWebACLStatementFactory> WithStatement<T1, T2>(this CombinedResult<T1, T2, InnerWebACLNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLNotStatementFactory, T1, T2, T3, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<InnerWebACLNotStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLNotStatementFactory, T2, T3, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, InnerWebACLNotStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLNotStatementFactory, T3, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLNotStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLNotStatementFactory, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLNotStatementFactory, T1, T2, T3, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<InnerWebACLNotStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLNotStatementFactory, T2, T3, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLNotStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLNotStatementFactory, T3, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLNotStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLNotStatementFactory, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLNotStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLNotStatementFactory, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLNotStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T5, subFactoryAction));
}
