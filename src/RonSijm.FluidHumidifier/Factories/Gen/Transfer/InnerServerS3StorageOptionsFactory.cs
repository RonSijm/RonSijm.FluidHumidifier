// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerS3StorageOptionsFactory(Action<Humidifier.Transfer.ServerTypes.S3StorageOptions> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.S3StorageOptions>
{

    protected override Humidifier.Transfer.ServerTypes.S3StorageOptions Create()
    {
        var s3StorageOptionsResult = CreateS3StorageOptions();
        factoryAction?.Invoke(s3StorageOptionsResult);

        return s3StorageOptionsResult;
    }

    private Humidifier.Transfer.ServerTypes.S3StorageOptions CreateS3StorageOptions()
    {
        var s3StorageOptionsResult = new Humidifier.Transfer.ServerTypes.S3StorageOptions();

        return s3StorageOptionsResult;
    }

} // End Of Class

public static class InnerServerS3StorageOptionsFactoryExtensions
{
}
