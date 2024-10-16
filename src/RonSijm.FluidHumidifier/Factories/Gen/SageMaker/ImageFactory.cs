// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ImageFactory(string resourceName = null, Action<Humidifier.SageMaker.Image> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Image>(resourceName)
{

    protected override Humidifier.SageMaker.Image Create()
    {
        var imageResult = CreateImage();
        factoryAction?.Invoke(imageResult);

        return imageResult;
    }

    private Humidifier.SageMaker.Image CreateImage()
    {
        var imageResult = new Humidifier.SageMaker.Image
        {
            GivenName = InputResourceName,
        };

        return imageResult;
    }

} // End Of Class

public static class ImageFactoryExtensions
{
}
