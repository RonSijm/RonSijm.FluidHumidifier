// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ImageFactory(string resourceName = null, Action<Humidifier.EC2.Image> factoryAction = null) : ResourceFactory<Humidifier.EC2.Image>(resourceName)
{

    protected override Humidifier.EC2.Image Create()
    {
        var imageResult = CreateImage();
        factoryAction?.Invoke(imageResult);

        return imageResult;
    }

    private Humidifier.EC2.Image CreateImage()
    {
        var imageResult = new Humidifier.EC2.Image
        {
            GivenName = InputResourceName,
        };

        return imageResult;
    }

} // End Of Class

public static class ImageFactoryExtensions
{
}
