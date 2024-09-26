// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerSizeConstraintSetSizeConstraintFactory(Action<Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint>
{

    internal InnerSizeConstraintSetFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint Create()
    {
        var sizeConstraintResult = CreateSizeConstraint();
        factoryAction?.Invoke(sizeConstraintResult);

        return sizeConstraintResult;
    }

    private Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint CreateSizeConstraint()
    {
        var sizeConstraintResult = new Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint();

        return sizeConstraintResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.SizeConstraintSetTypes.SizeConstraint result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerSizeConstraintSetSizeConstraintFactoryExtensions
{
    public static CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch(this InnerSizeConstraintSetSizeConstraintFactory parentFactory, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerSizeConstraintSetFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, T2, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, T2, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, T2> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSizeConstraintSetSizeConstraintFactory, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerSizeConstraintSetSizeConstraintFactory> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, T2, T3, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, T2, T3, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSizeConstraintSetSizeConstraintFactory, T3, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerSizeConstraintSetSizeConstraintFactory, T3> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSizeConstraintSetSizeConstraintFactory, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSizeConstraintSetSizeConstraintFactory> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, T2, T3, T4, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerSizeConstraintSetSizeConstraintFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, T2, T3, T4, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerSizeConstraintSetSizeConstraintFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSizeConstraintSetSizeConstraintFactory, T3, T4, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSizeConstraintSetSizeConstraintFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSizeConstraintSetSizeConstraintFactory, T4, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSizeConstraintSetSizeConstraintFactory, T4> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSizeConstraintSetSizeConstraintFactory, InnerSizeConstraintSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSizeConstraintSetSizeConstraintFactory> combinedResult, Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
