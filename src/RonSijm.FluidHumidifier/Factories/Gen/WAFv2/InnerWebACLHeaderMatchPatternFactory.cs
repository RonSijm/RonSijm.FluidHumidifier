// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLHeaderMatchPatternFactory(Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern>
{

    protected override Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern Create()
    {
        var headerMatchPatternResult = CreateHeaderMatchPattern();
        factoryAction?.Invoke(headerMatchPatternResult);

        return headerMatchPatternResult;
    }

    private Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern CreateHeaderMatchPattern()
    {
        var headerMatchPatternResult = new Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern();

        return headerMatchPatternResult;
    }

} // End Of Class

public static class InnerWebACLHeaderMatchPatternFactoryExtensions
{
}
