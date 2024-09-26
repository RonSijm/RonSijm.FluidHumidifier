// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class WorkerConfigurationFactory(string resourceName = null, Action<Humidifier.KafkaConnect.WorkerConfiguration> factoryAction = null) : ResourceFactory<Humidifier.KafkaConnect.WorkerConfiguration>(resourceName)
{

    protected override Humidifier.KafkaConnect.WorkerConfiguration Create()
    {
        var workerConfigurationResult = CreateWorkerConfiguration();
        factoryAction?.Invoke(workerConfigurationResult);

        return workerConfigurationResult;
    }

    private Humidifier.KafkaConnect.WorkerConfiguration CreateWorkerConfiguration()
    {
        var workerConfigurationResult = new Humidifier.KafkaConnect.WorkerConfiguration
        {
            GivenName = InputResourceName,
        };

        return workerConfigurationResult;
    }

} // End Of Class

public static class WorkerConfigurationFactoryExtensions
{
}
