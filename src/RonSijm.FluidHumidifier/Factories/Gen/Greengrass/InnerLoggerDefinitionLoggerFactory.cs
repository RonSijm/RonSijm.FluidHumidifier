// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerLoggerDefinitionLoggerFactory(Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.LoggerDefinitionTypes.Logger>
{

    protected override Humidifier.Greengrass.LoggerDefinitionTypes.Logger Create()
    {
        var loggerResult = CreateLogger();
        factoryAction?.Invoke(loggerResult);

        return loggerResult;
    }

    private Humidifier.Greengrass.LoggerDefinitionTypes.Logger CreateLogger()
    {
        var loggerResult = new Humidifier.Greengrass.LoggerDefinitionTypes.Logger();

        return loggerResult;
    }

} // End Of Class

public static class InnerLoggerDefinitionLoggerFactoryExtensions
{
}
