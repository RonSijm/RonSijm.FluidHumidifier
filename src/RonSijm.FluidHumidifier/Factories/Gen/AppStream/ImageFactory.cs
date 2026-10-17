// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class ImageFactory(string resourceName = null, Action<Humidifier.AppStream.Image> factoryAction = null) : ResourceFactory<Humidifier.AppStream.Image>(resourceName)
{

    protected override Humidifier.AppStream.Image Create()
    {
        var imageResult = CreateImage();
        factoryAction?.Invoke(imageResult);

        return imageResult;
    }

    private Humidifier.AppStream.Image CreateImage()
    {
        var imageResult = new Humidifier.AppStream.Image
        {
            GivenName = InputResourceName,
        };

        return imageResult;
    }

} // End Of Class

public static class ImageFactoryExtensions
{
}
