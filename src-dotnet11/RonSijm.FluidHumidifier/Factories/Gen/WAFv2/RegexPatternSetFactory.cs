// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class RegexPatternSetFactory(string resourceName = null, Action<Humidifier.WAFv2.RegexPatternSet> factoryAction = null) : ResourceFactory<Humidifier.WAFv2.RegexPatternSet>(resourceName)
{

    protected override Humidifier.WAFv2.RegexPatternSet Create()
    {
        var regexPatternSetResult = CreateRegexPatternSet();
        factoryAction?.Invoke(regexPatternSetResult);

        return regexPatternSetResult;
    }

    private Humidifier.WAFv2.RegexPatternSet CreateRegexPatternSet()
    {
        var regexPatternSetResult = new Humidifier.WAFv2.RegexPatternSet
        {
            GivenName = InputResourceName,
        };

        return regexPatternSetResult;
    }

} // End Of Class

public static class RegexPatternSetFactoryExtensions
{
}
