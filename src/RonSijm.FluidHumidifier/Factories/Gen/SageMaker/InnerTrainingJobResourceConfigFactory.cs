// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobResourceConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.ResourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.ResourceConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.ResourceConfig Create()
    {
        var resourceConfigResult = CreateResourceConfig();
        factoryAction?.Invoke(resourceConfigResult);

        return resourceConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.ResourceConfig CreateResourceConfig()
    {
        var resourceConfigResult = new Humidifier.SageMaker.TrainingJobTypes.ResourceConfig();

        return resourceConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobResourceConfigFactoryExtensions
{
}
