// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class SizeConstraintSetFactory(string resourceName = null, Action<Humidifier.WAF.SizeConstraintSet> factoryAction = null) : ResourceFactory<Humidifier.WAF.SizeConstraintSet>(resourceName)
{

    internal List<InnerSizeConstraintSetSizeConstraintFactory> SizeConstraintsFactories { get; set; } = [];

    protected override Humidifier.WAF.SizeConstraintSet Create()
    {
        var sizeConstraintSetResult = CreateSizeConstraintSet();
        factoryAction?.Invoke(sizeConstraintSetResult);

        return sizeConstraintSetResult;
    }

    private Humidifier.WAF.SizeConstraintSet CreateSizeConstraintSet()
    {
        var sizeConstraintSetResult = new Humidifier.WAF.SizeConstraintSet
        {
            GivenName = InputResourceName,
        };

        return sizeConstraintSetResult;
    }
    public override void CreateChildren(Humidifier.WAF.SizeConstraintSet result)
    {
        base.CreateChildren(result);

        result.SizeConstraints = SizeConstraintsFactories.Any() ? SizeConstraintsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SizeConstraintSetFactoryExtensions
{
    public static CombinedResult<SizeConstraintSetFactory, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints(this SizeConstraintSetFactory parentFactory, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null)
    {
        var factory = new InnerSizeConstraintSetSizeConstraintFactory(subFactoryAction);
        parentFactory.SizeConstraintsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SizeConstraintSetFactory, T1, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1>(this CombinedResult<SizeConstraintSetFactory, T1> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, WithSizeConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SizeConstraintSetFactory, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1>(this CombinedResult<T1, SizeConstraintSetFactory> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, WithSizeConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SizeConstraintSetFactory, T1, T2, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2>(this CombinedResult<SizeConstraintSetFactory, T1, T2> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SizeConstraintSetFactory, T2, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2>(this CombinedResult<T1, SizeConstraintSetFactory, T2> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SizeConstraintSetFactory, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2>(this CombinedResult<T1, T2, SizeConstraintSetFactory> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SizeConstraintSetFactory, T1, T2, T3, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3>(this CombinedResult<SizeConstraintSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SizeConstraintSetFactory, T2, T3, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3>(this CombinedResult<T1, SizeConstraintSetFactory, T2, T3> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SizeConstraintSetFactory, T3, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3>(this CombinedResult<T1, T2, SizeConstraintSetFactory, T3> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SizeConstraintSetFactory, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, SizeConstraintSetFactory> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SizeConstraintSetFactory, T1, T2, T3, T4, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3, T4>(this CombinedResult<SizeConstraintSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SizeConstraintSetFactory, T2, T3, T4, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3, T4>(this CombinedResult<T1, SizeConstraintSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SizeConstraintSetFactory, T3, T4, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, SizeConstraintSetFactory, T3, T4> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SizeConstraintSetFactory, T4, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SizeConstraintSetFactory, T4> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SizeConstraintSetFactory, InnerSizeConstraintSetSizeConstraintFactory> WithSizeConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SizeConstraintSetFactory> combinedResult, Action<Humidifier.WAF.SizeConstraintSetTypes.SizeConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSizeConstraints(combinedResult.T5, subFactoryAction));
}
