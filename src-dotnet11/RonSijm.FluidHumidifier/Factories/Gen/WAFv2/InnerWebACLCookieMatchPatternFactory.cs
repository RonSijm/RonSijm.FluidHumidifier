// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCookieMatchPatternFactory(Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern>
{

    protected override Humidifier.WAFv2.WebACLTypes.CookieMatchPattern Create()
    {
        var cookieMatchPatternResult = CreateCookieMatchPattern();
        factoryAction?.Invoke(cookieMatchPatternResult);

        return cookieMatchPatternResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CookieMatchPattern CreateCookieMatchPattern()
    {
        var cookieMatchPatternResult = new Humidifier.WAFv2.WebACLTypes.CookieMatchPattern();

        return cookieMatchPatternResult;
    }

} // End Of Class

public static class InnerWebACLCookieMatchPatternFactoryExtensions
{
}
