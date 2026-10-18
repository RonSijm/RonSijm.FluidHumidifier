// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerXssMatchSetFieldToMatchFactory(Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch>
{

    protected override Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerXssMatchSetFieldToMatchFactoryExtensions
{
}
