// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerSqlInjectionMatchSetFieldToMatchFactory(Action<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch>
{

    protected override Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAFRegional.SqlInjectionMatchSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerSqlInjectionMatchSetFieldToMatchFactoryExtensions
{
}
