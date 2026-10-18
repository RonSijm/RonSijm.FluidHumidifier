// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class LogAnomalyDetectionIntegrationFactory(string resourceName = null, Action<Humidifier.DevOpsGuru.LogAnomalyDetectionIntegration> factoryAction = null) : ResourceFactory<Humidifier.DevOpsGuru.LogAnomalyDetectionIntegration>(resourceName)
{

    protected override Humidifier.DevOpsGuru.LogAnomalyDetectionIntegration Create()
    {
        var logAnomalyDetectionIntegrationResult = CreateLogAnomalyDetectionIntegration();
        factoryAction?.Invoke(logAnomalyDetectionIntegrationResult);

        return logAnomalyDetectionIntegrationResult;
    }

    private Humidifier.DevOpsGuru.LogAnomalyDetectionIntegration CreateLogAnomalyDetectionIntegration()
    {
        var logAnomalyDetectionIntegrationResult = new Humidifier.DevOpsGuru.LogAnomalyDetectionIntegration
        {
            GivenName = InputResourceName,
        };

        return logAnomalyDetectionIntegrationResult;
    }

} // End Of Class

public static class LogAnomalyDetectionIntegrationFactoryExtensions
{
}
