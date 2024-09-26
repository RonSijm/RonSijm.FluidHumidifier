// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class LoggingFactory(string resourceName = null, Action<Humidifier.IoT.Logging> factoryAction = null) : ResourceFactory<Humidifier.IoT.Logging>(resourceName)
{

    protected override Humidifier.IoT.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.IoT.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.IoT.Logging
        {
            GivenName = InputResourceName,
        };

        return loggingResult;
    }

} // End Of Class

public static class LoggingFactoryExtensions
{
}
