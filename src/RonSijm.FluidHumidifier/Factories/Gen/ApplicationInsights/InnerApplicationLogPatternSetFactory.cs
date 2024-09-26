// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationLogPatternSetFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet Create()
    {
        var logPatternSetResult = CreateLogPatternSet();
        factoryAction?.Invoke(logPatternSetResult);

        return logPatternSetResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet CreateLogPatternSet()
    {
        var logPatternSetResult = new Humidifier.ApplicationInsights.ApplicationTypes.LogPatternSet();

        return logPatternSetResult;
    }

} // End Of Class

public static class InnerApplicationLogPatternSetFactoryExtensions
{
}
