// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerByteMatchSetFieldToMatchFactory(Action<Humidifier.WAFRegional.ByteMatchSetTypes.FieldToMatch> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.ByteMatchSetTypes.FieldToMatch>
{

    protected override Humidifier.WAFRegional.ByteMatchSetTypes.FieldToMatch Create()
    {
        var fieldToMatchResult = CreateFieldToMatch();
        factoryAction?.Invoke(fieldToMatchResult);

        return fieldToMatchResult;
    }

    private Humidifier.WAFRegional.ByteMatchSetTypes.FieldToMatch CreateFieldToMatch()
    {
        var fieldToMatchResult = new Humidifier.WAFRegional.ByteMatchSetTypes.FieldToMatch();

        return fieldToMatchResult;
    }

} // End Of Class

public static class InnerByteMatchSetFieldToMatchFactoryExtensions
{
}
