// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MedicalImaging;

public class ImageSetFactory(string resourceName = null, Action<Humidifier.MedicalImaging.ImageSet> factoryAction = null) : ResourceFactory<Humidifier.MedicalImaging.ImageSet>(resourceName)
{

    protected override Humidifier.MedicalImaging.ImageSet Create()
    {
        var imageSetResult = CreateImageSet();
        factoryAction?.Invoke(imageSetResult);

        return imageSetResult;
    }

    private Humidifier.MedicalImaging.ImageSet CreateImageSet()
    {
        var imageSetResult = new Humidifier.MedicalImaging.ImageSet
        {
            GivenName = InputResourceName,
        };

        return imageSetResult;
    }

} // End Of Class

public static class ImageSetFactoryExtensions
{
}
