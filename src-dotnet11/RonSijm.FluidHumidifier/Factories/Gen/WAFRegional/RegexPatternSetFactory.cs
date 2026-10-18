// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class RegexPatternSetFactory(string resourceName = null, Action<Humidifier.WAFRegional.RegexPatternSet> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.RegexPatternSet>(resourceName)
{

    protected override Humidifier.WAFRegional.RegexPatternSet Create()
    {
        var regexPatternSetResult = CreateRegexPatternSet();
        factoryAction?.Invoke(regexPatternSetResult);

        return regexPatternSetResult;
    }

    private Humidifier.WAFRegional.RegexPatternSet CreateRegexPatternSet()
    {
        var regexPatternSetResult = new Humidifier.WAFRegional.RegexPatternSet
        {
            GivenName = InputResourceName,
        };

        return regexPatternSetResult;
    }

} // End Of Class

public static class RegexPatternSetFactoryExtensions
{
}
