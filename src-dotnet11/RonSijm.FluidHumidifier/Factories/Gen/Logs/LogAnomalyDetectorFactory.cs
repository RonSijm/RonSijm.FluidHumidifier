// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class LogAnomalyDetectorFactory(string resourceName = null, Action<Humidifier.Logs.LogAnomalyDetector> factoryAction = null) : ResourceFactory<Humidifier.Logs.LogAnomalyDetector>(resourceName)
{

    protected override Humidifier.Logs.LogAnomalyDetector Create()
    {
        var logAnomalyDetectorResult = CreateLogAnomalyDetector();
        factoryAction?.Invoke(logAnomalyDetectorResult);

        return logAnomalyDetectorResult;
    }

    private Humidifier.Logs.LogAnomalyDetector CreateLogAnomalyDetector()
    {
        var logAnomalyDetectorResult = new Humidifier.Logs.LogAnomalyDetector
        {
            GivenName = InputResourceName,
        };

        return logAnomalyDetectorResult;
    }

} // End Of Class

public static class LogAnomalyDetectorFactoryExtensions
{
}
