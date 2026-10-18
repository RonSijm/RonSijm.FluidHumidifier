// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerSqlInjectionMatchSetFieldToMatchFactory(Action<Humidifier.WAF.SqlInjectionMatchSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAF.SqlInjectionMatchSetTypes.FieldToMatch>
{

    protected override Humidifier.WAF.SqlInjectionMatchSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAF.SqlInjectionMatchSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAF.SqlInjectionMatchSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerSqlInjectionMatchSetFieldToMatchFactoryExtensions
{
}
