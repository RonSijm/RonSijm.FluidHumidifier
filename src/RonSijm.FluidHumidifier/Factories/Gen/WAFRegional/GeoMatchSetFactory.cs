// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class GeoMatchSetFactory(string resourceName = null, Action<Humidifier.WAFRegional.GeoMatchSet> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.GeoMatchSet>(resourceName)
{

    internal List<InnerGeoMatchSetGeoMatchConstraintFactory> GeoMatchConstraintsFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.GeoMatchSet Create()
    {
        var geoMatchSetResult = CreateGeoMatchSet();
        factoryAction?.Invoke(geoMatchSetResult);

        return geoMatchSetResult;
    }

    private Humidifier.WAFRegional.GeoMatchSet CreateGeoMatchSet()
    {
        var geoMatchSetResult = new Humidifier.WAFRegional.GeoMatchSet
        {
            GivenName = InputResourceName,
        };

        return geoMatchSetResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.GeoMatchSet result)
    {
        base.CreateChildren(result);

        result.GeoMatchConstraints = GeoMatchConstraintsFactories.Any() ? GeoMatchConstraintsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GeoMatchSetFactoryExtensions
{
    public static CombinedResult<GeoMatchSetFactory, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints(this GeoMatchSetFactory parentFactory, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null)
    {
        var factory = new InnerGeoMatchSetGeoMatchConstraintFactory(subFactoryAction);
        parentFactory.GeoMatchConstraintsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GeoMatchSetFactory, T1, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1>(this CombinedResult<GeoMatchSetFactory, T1> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GeoMatchSetFactory, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1>(this CombinedResult<T1, GeoMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GeoMatchSetFactory, T1, T2, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2>(this CombinedResult<GeoMatchSetFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GeoMatchSetFactory, T2, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2>(this CombinedResult<T1, GeoMatchSetFactory, T2> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GeoMatchSetFactory, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2>(this CombinedResult<T1, T2, GeoMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GeoMatchSetFactory, T1, T2, T3, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3>(this CombinedResult<GeoMatchSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GeoMatchSetFactory, T2, T3, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3>(this CombinedResult<T1, GeoMatchSetFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GeoMatchSetFactory, T3, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3>(this CombinedResult<T1, T2, GeoMatchSetFactory, T3> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GeoMatchSetFactory, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, GeoMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GeoMatchSetFactory, T1, T2, T3, T4, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3, T4>(this CombinedResult<GeoMatchSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GeoMatchSetFactory, T2, T3, T4, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3, T4>(this CombinedResult<T1, GeoMatchSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GeoMatchSetFactory, T3, T4, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, GeoMatchSetFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GeoMatchSetFactory, T4, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GeoMatchSetFactory, T4> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GeoMatchSetFactory, InnerGeoMatchSetGeoMatchConstraintFactory> WithGeoMatchConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GeoMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGeoMatchConstraints(combinedResult.T5, subFactoryAction));
}
