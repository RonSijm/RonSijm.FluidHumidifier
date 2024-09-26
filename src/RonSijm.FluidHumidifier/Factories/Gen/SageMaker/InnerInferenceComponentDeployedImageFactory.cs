// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentDeployedImageFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.DeployedImage Create()
    {
        var deployedImageResult = CreateDeployedImage();
        factoryAction?.Invoke(deployedImageResult);

        return deployedImageResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.DeployedImage CreateDeployedImage()
    {
        var deployedImageResult = new Humidifier.SageMaker.InferenceComponentTypes.DeployedImage();

        return deployedImageResult;
    }

} // End Of Class

public static class InnerInferenceComponentDeployedImageFactoryExtensions
{
}
