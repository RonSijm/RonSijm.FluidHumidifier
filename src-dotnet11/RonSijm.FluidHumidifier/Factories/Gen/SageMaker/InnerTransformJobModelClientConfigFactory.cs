// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobModelClientConfigFactory(Action<Humidifier.SageMaker.TransformJobTypes.ModelClientConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.ModelClientConfig>
{

    protected override Humidifier.SageMaker.TransformJobTypes.ModelClientConfig Create()
    {
        var modelClientConfigResult = CreateModelClientConfig();
        factoryAction?.Invoke(modelClientConfigResult);

        return modelClientConfigResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.ModelClientConfig CreateModelClientConfig()
    {
        var modelClientConfigResult = new Humidifier.SageMaker.TransformJobTypes.ModelClientConfig();

        return modelClientConfigResult;
    }

} // End Of Class

public static class InnerTransformJobModelClientConfigFactoryExtensions
{
}
