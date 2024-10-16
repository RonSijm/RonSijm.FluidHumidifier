// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerUnusedAccessConfigurationFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration>
{

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration Create()
    {
        var unusedAccessConfigurationResult = CreateUnusedAccessConfiguration();
        factoryAction?.Invoke(unusedAccessConfigurationResult);

        return unusedAccessConfigurationResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration CreateUnusedAccessConfiguration()
    {
        var unusedAccessConfigurationResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration();

        return unusedAccessConfigurationResult;
    }

} // End Of Class

public static class InnerAnalyzerUnusedAccessConfigurationFactoryExtensions
{
}
