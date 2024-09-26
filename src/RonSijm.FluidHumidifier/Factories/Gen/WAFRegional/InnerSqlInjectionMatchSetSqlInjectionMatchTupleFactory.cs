// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory(Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple>
{

    internal InnerSqlInjectionMatchSetFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple Create()
    {
        var sqlInjectionMatchTupleResult = CreateSqlInjectionMatchTuple();
        factoryAction?.Invoke(sqlInjectionMatchTupleResult);

        return sqlInjectionMatchTupleResult;
    }

    private Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple CreateSqlInjectionMatchTuple()
    {
        var sqlInjectionMatchTupleResult = new Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple();

        return sqlInjectionMatchTupleResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.SqlInjectionMatchSetTypes.SqlInjectionMatchTuple result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactoryExtensions
{
    public static CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch(this InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory parentFactory, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerSqlInjectionMatchSetFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, T2, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T2, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T2> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, T2, T3, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T2, T3, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T3, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T3> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, T2, T3, T4, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T2, T3, T4, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T3, T4, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T4, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, T4> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory, InnerSqlInjectionMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSqlInjectionMatchSetSqlInjectionMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
