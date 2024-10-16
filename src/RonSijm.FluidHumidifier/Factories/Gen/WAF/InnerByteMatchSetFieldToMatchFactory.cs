// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerByteMatchSetFieldToMatchFactory(Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch>
{

    protected override Humidifier.WAF.ByteMatchSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAF.ByteMatchSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAF.ByteMatchSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerByteMatchSetFieldToMatchFactoryExtensions
{
}
