// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobDebugHookConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.DebugHookConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.DebugHookConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.DebugHookConfig Create()
    {
        var debugHookConfigResult = CreateDebugHookConfig();
        factoryAction?.Invoke(debugHookConfigResult);

        return debugHookConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.DebugHookConfig CreateDebugHookConfig()
    {
        var debugHookConfigResult = new Humidifier.SageMaker.TrainingJobTypes.DebugHookConfig();

        return debugHookConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobDebugHookConfigFactoryExtensions
{
}
