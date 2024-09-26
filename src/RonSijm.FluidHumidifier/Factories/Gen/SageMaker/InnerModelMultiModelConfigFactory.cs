// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelMultiModelConfigFactory(Action<Humidifier.SageMaker.ModelTypes.MultiModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.MultiModelConfig>
{

    protected override Humidifier.SageMaker.ModelTypes.MultiModelConfig Create()
    {
        var multiModelConfigResult = CreateMultiModelConfig();
        factoryAction?.Invoke(multiModelConfigResult);

        return multiModelConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.MultiModelConfig CreateMultiModelConfig()
    {
        var multiModelConfigResult = new Humidifier.SageMaker.ModelTypes.MultiModelConfig();

        return multiModelConfigResult;
    }

} // End Of Class

public static class InnerModelMultiModelConfigFactoryExtensions
{
}
