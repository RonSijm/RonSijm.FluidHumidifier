// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketAccelerateConfigurationFactory(Action<Humidifier.S3.BucketTypes.AccelerateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.AccelerateConfiguration>
{

    protected override Humidifier.S3.BucketTypes.AccelerateConfiguration Create()
    {
        var accelerateConfigurationResult = CreateAccelerateConfiguration();
        factoryAction?.Invoke(accelerateConfigurationResult);

        return accelerateConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.AccelerateConfiguration CreateAccelerateConfiguration()
    {
        var accelerateConfigurationResult = new Humidifier.S3.BucketTypes.AccelerateConfiguration();

        return accelerateConfigurationResult;
    }

} // End Of Class

public static class InnerBucketAccelerateConfigurationFactoryExtensions
{
}
