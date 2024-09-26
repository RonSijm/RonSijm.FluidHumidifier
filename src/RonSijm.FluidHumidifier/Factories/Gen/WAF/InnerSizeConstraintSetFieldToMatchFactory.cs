// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerSizeConstraintSetFieldToMatchFactory(Action<Humidifier.WAF.SizeConstraintSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAF.SizeConstraintSetTypes.FieldToMatch>
{

    protected override Humidifier.WAF.SizeConstraintSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAF.SizeConstraintSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAF.SizeConstraintSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerSizeConstraintSetFieldToMatchFactoryExtensions
{
}
