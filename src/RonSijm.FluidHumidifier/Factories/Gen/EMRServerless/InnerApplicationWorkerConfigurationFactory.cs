// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationWorkerConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration Create()
    {
        var workerConfigurationResult = CreateWorkerConfiguration();
        factoryAction?.Invoke(workerConfigurationResult);

        return workerConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration CreateWorkerConfiguration()
    {
        var workerConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration();

        return workerConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationWorkerConfigurationFactoryExtensions
{
}
