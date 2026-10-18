// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentAutoRollbackConfigurationFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.AutoRollbackConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.AutoRollbackConfiguration>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.AutoRollbackConfiguration Create()
    {
        var autoRollbackConfigurationResult = CreateAutoRollbackConfiguration();
        factoryAction?.Invoke(autoRollbackConfigurationResult);

        return autoRollbackConfigurationResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.AutoRollbackConfiguration CreateAutoRollbackConfiguration()
    {
        var autoRollbackConfigurationResult = new Humidifier.SageMaker.InferenceComponentTypes.AutoRollbackConfiguration();

        return autoRollbackConfigurationResult;
    }

} // End Of Class

public static class InnerInferenceComponentAutoRollbackConfigurationFactoryExtensions
{
}
