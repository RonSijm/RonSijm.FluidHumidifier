// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class LogStreamFactory(string resourceName = null, Action<Humidifier.Logs.LogStream> factoryAction = null) : ResourceFactory<Humidifier.Logs.LogStream>(resourceName)
{

    protected override Humidifier.Logs.LogStream Create()
    {
        var logStreamResult = CreateLogStream();
        factoryAction?.Invoke(logStreamResult);

        return logStreamResult;
    }

    private Humidifier.Logs.LogStream CreateLogStream()
    {
        var logStreamResult = new Humidifier.Logs.LogStream
        {
            GivenName = InputResourceName,
        };

        return logStreamResult;
    }

} // End Of Class

public static class LogStreamFactoryExtensions
{
}
