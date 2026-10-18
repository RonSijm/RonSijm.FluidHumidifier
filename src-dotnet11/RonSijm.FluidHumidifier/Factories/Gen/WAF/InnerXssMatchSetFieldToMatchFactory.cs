// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerXssMatchSetFieldToMatchFactory(Action<Humidifier.WAF.XssMatchSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAF.XssMatchSetTypes.FieldToMatch>
{

    protected override Humidifier.WAF.XssMatchSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAF.XssMatchSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAF.XssMatchSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerXssMatchSetFieldToMatchFactoryExtensions
{
}
