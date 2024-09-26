// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class SqlInjectionMatchSetFactory(string resourceName = null, Action<Humidifier.WAFRegional.SqlInjectionMatchSet> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.SqlInjectionMatchSet>(resourceName)
{

    internal List<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> SqlInjectionMatchTuplesFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.SqlInjectionMatchSet Create()
    {
        var sqlInjectionMatchSetResult = CreateSqlInjectionMatchSet();
        factoryAction?.Invoke(sqlInjectionMatchSetResult);

        return sqlInjectionMatchSetResult;
    }

    private Humidifier.WAFRegional.SqlInjectionMatchSet CreateSqlInjectionMatchSet()
    {
        var sqlInjectionMatchSetResult = new Humidifier.WAFRegional.SqlInjectionMatchSet
        {
            GivenName = InputResourceName,
        };

        return sqlInjectionMatchSetResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.SqlInjectionMatchSet result)
    {
        base.CreateChildren(result);

        result.SqlInjectionMatchTuples = SqlInjectionMatchTuplesFactories.Any() ? SqlInjectionMatchTuplesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SqlInjectionMatchSetFactoryExtensions
{
    public static CombinedResult<SqlInjectionMatchSetFactory, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples(this SqlInjectionMatchSetFactory parentFactory, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null)
    {
        var factory = new InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory(subFactoryAction);
        parentFactory.SqlInjectionMatchTuplesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SqlInjectionMatchSetFactory, T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1>(this CombinedResult<SqlInjectionMatchSetFactory, T1> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SqlInjectionMatchSetFactory, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1>(this CombinedResult<T1, SqlInjectionMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SqlInjectionMatchSetFactory, T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2>(this CombinedResult<SqlInjectionMatchSetFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SqlInjectionMatchSetFactory, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2>(this CombinedResult<T1, SqlInjectionMatchSetFactory, T2> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SqlInjectionMatchSetFactory, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2>(this CombinedResult<T1, T2, SqlInjectionMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SqlInjectionMatchSetFactory, T1, T2, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3>(this CombinedResult<SqlInjectionMatchSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SqlInjectionMatchSetFactory, T2, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3>(this CombinedResult<T1, SqlInjectionMatchSetFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SqlInjectionMatchSetFactory, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3>(this CombinedResult<T1, T2, SqlInjectionMatchSetFactory, T3> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SqlInjectionMatchSetFactory, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3>(this CombinedResult<T1, T2, T3, SqlInjectionMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SqlInjectionMatchSetFactory, T1, T2, T3, T4, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3, T4>(this CombinedResult<SqlInjectionMatchSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SqlInjectionMatchSetFactory, T2, T3, T4, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, SqlInjectionMatchSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SqlInjectionMatchSetFactory, T3, T4, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, SqlInjectionMatchSetFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SqlInjectionMatchSetFactory, T4, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SqlInjectionMatchSetFactory, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SqlInjectionMatchSetFactory, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> WithSqlInjectionMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SqlInjectionMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlInjectionMatchTuples(combinedResult.T5, subFactoryAction));
}
