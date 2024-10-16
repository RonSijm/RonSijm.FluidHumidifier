// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ImageVersionFactory(string resourceName = null, Action<Humidifier.SageMaker.ImageVersion> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ImageVersion>(resourceName)
{

    protected override Humidifier.SageMaker.ImageVersion Create()
    {
        var imageVersionResult = CreateImageVersion();
        factoryAction?.Invoke(imageVersionResult);

        return imageVersionResult;
    }

    private Humidifier.SageMaker.ImageVersion CreateImageVersion()
    {
        var imageVersionResult = new Humidifier.SageMaker.ImageVersion
        {
            GivenName = InputResourceName,
        };

        return imageVersionResult;
    }

} // End Of Class

public static class ImageVersionFactoryExtensions
{
}
