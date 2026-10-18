// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerGeoMatchSetGeoMatchConstraintFactory(Action<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint>
{

    protected override Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint Create()
    {
        var geoMatchConstraintResult = CreateGeoMatchConstraint();
        factoryAction?.Invoke(geoMatchConstraintResult);

        return geoMatchConstraintResult;
    }

    private Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint CreateGeoMatchConstraint()
    {
        var geoMatchConstraintResult = new Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint();

        return geoMatchConstraintResult;
    }

} // End Of Class

public static class InnerGeoMatchSetGeoMatchConstraintFactoryExtensions
{
}
