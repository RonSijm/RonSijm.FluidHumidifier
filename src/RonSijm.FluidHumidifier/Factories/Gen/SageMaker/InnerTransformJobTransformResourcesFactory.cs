// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobTransformResourcesFactory(Action<Humidifier.SageMaker.TransformJobTypes.TransformResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.TransformResources>
{

    protected override Humidifier.SageMaker.TransformJobTypes.TransformResources Create()
    {
        var transformResourcesResult = CreateTransformResources();
        factoryAction?.Invoke(transformResourcesResult);

        return transformResourcesResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.TransformResources CreateTransformResources()
    {
        var transformResourcesResult = new Humidifier.SageMaker.TransformJobTypes.TransformResources();

        return transformResourcesResult;
    }

} // End Of Class

public static class InnerTransformJobTransformResourcesFactoryExtensions
{
}
