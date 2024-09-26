// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionInferenceAcceleratorFactory(Action<Humidifier.ECS.TaskDefinitionTypes.InferenceAccelerator> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.InferenceAccelerator>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.InferenceAccelerator Create()
    {
        var inferenceAcceleratorResult = CreateInferenceAccelerator();
        factoryAction?.Invoke(inferenceAcceleratorResult);

        return inferenceAcceleratorResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.InferenceAccelerator CreateInferenceAccelerator()
    {
        var inferenceAcceleratorResult = new Humidifier.ECS.TaskDefinitionTypes.InferenceAccelerator();

        return inferenceAcceleratorResult;
    }

} // End Of Class

public static class InnerTaskDefinitionInferenceAcceleratorFactoryExtensions
{
}
