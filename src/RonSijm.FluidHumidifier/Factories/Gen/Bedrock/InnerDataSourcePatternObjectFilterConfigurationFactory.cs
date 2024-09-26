// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourcePatternObjectFilterConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration Create()
    {
        var patternObjectFilterConfigurationResult = CreatePatternObjectFilterConfiguration();
        factoryAction?.Invoke(patternObjectFilterConfigurationResult);

        return patternObjectFilterConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration CreatePatternObjectFilterConfiguration()
    {
        var patternObjectFilterConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration();

        return patternObjectFilterConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourcePatternObjectFilterConfigurationFactoryExtensions
{
}
