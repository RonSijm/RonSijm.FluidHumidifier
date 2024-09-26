// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerSizeConstraintSetFieldToMatchFactory(Action<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch>
{

    protected override Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAFRegional.SizeConstraintSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerSizeConstraintSetFieldToMatchFactoryExtensions
{
}
