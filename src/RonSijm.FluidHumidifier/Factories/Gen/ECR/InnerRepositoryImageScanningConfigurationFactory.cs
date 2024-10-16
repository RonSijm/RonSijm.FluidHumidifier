// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRepositoryImageScanningConfigurationFactory(Action<Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration>
{

    protected override Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration Create()
    {
        var imageScanningConfigurationResult = CreateImageScanningConfiguration();
        factoryAction?.Invoke(imageScanningConfigurationResult);

        return imageScanningConfigurationResult;
    }

    private Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration CreateImageScanningConfiguration()
    {
        var imageScanningConfigurationResult = new Humidifier.ECR.RepositoryTypes.ImageScanningConfiguration();

        return imageScanningConfigurationResult;
    }

} // End Of Class

public static class InnerRepositoryImageScanningConfigurationFactoryExtensions
{
}
