// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobModelAccessConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig Create()
    {
        var modelAccessConfigResult = CreateModelAccessConfig();
        factoryAction?.Invoke(modelAccessConfigResult);

        return modelAccessConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig CreateModelAccessConfig()
    {
        var modelAccessConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig();

        return modelAccessConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobModelAccessConfigFactoryExtensions
{
}
