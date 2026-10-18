// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLJsonMatchPatternFactory(Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern>
{

    protected override Humidifier.WAFv2.WebACLTypes.JsonMatchPattern Create()
    {
        var jsonMatchPatternResult = CreateJsonMatchPattern();
        factoryAction?.Invoke(jsonMatchPatternResult);

        return jsonMatchPatternResult;
    }

    private Humidifier.WAFv2.WebACLTypes.JsonMatchPattern CreateJsonMatchPattern()
    {
        var jsonMatchPatternResult = new Humidifier.WAFv2.WebACLTypes.JsonMatchPattern();

        return jsonMatchPatternResult;
    }

} // End Of Class

public static class InnerWebACLJsonMatchPatternFactoryExtensions
{
}
