// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobRemoteDebugConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.RemoteDebugConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.RemoteDebugConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.RemoteDebugConfig Create()
    {
        var remoteDebugConfigResult = CreateRemoteDebugConfig();
        factoryAction?.Invoke(remoteDebugConfigResult);

        return remoteDebugConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.RemoteDebugConfig CreateRemoteDebugConfig()
    {
        var remoteDebugConfigResult = new Humidifier.SageMaker.TrainingJobTypes.RemoteDebugConfig();

        return remoteDebugConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobRemoteDebugConfigFactoryExtensions
{
}
