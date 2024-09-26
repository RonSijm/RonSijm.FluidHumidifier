// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorWorkerConfigurationFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration Create()
    {
        var workerConfigurationResult = CreateWorkerConfiguration();
        factoryAction?.Invoke(workerConfigurationResult);

        return workerConfigurationResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration CreateWorkerConfiguration()
    {
        var workerConfigurationResult = new Humidifier.KafkaConnect.ConnectorTypes.WorkerConfiguration();

        return workerConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorWorkerConfigurationFactoryExtensions
{
}
