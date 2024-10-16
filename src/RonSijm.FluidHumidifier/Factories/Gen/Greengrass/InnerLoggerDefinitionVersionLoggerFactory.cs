// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerLoggerDefinitionVersionLoggerFactory(Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger>
{

    protected override Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger Create()
    {
        var loggerResult = CreateLogger();
        factoryAction?.Invoke(loggerResult);

        return loggerResult;
    }

    private Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger CreateLogger()
    {
        var loggerResult = new Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger();

        return loggerResult;
    }

} // End Of Class

public static class InnerLoggerDefinitionVersionLoggerFactoryExtensions
{
}
