// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerLoggingConfigurationLoggingFilterFactory(Action<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter>
{

    protected override Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter Create()
    {
        var loggingFilterResult = CreateLoggingFilter();
        factoryAction?.Invoke(loggingFilterResult);

        return loggingFilterResult;
    }

    private Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter CreateLoggingFilter()
    {
        var loggingFilterResult = new Humidifier.WAFv2.LoggingConfigurationTypes.LoggingFilter();

        return loggingFilterResult;
    }

} // End Of Class

public static class InnerLoggingConfigurationLoggingFilterFactoryExtensions
{
}
