// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelModelAccessConfigFactory(Action<Humidifier.SageMaker.ModelTypes.ModelAccessConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.ModelAccessConfig>
{

    protected override Humidifier.SageMaker.ModelTypes.ModelAccessConfig Create()
    {
        var modelAccessConfigResult = CreateModelAccessConfig();
        factoryAction?.Invoke(modelAccessConfigResult);

        return modelAccessConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.ModelAccessConfig CreateModelAccessConfig()
    {
        var modelAccessConfigResult = new Humidifier.SageMaker.ModelTypes.ModelAccessConfig();

        return modelAccessConfigResult;
    }

} // End Of Class

public static class InnerModelModelAccessConfigFactoryExtensions
{
}
