// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelS3StorageFactory(Action<Humidifier.MSK.ChannelTypes.S3Storage> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.S3Storage>
{

    protected override Humidifier.MSK.ChannelTypes.S3Storage Create()
    {
        var s3StorageResult = CreateS3Storage();
        factoryAction?.Invoke(s3StorageResult);

        return s3StorageResult;
    }

    private Humidifier.MSK.ChannelTypes.S3Storage CreateS3Storage()
    {
        var s3StorageResult = new Humidifier.MSK.ChannelTypes.S3Storage();

        return s3StorageResult;
    }

} // End Of Class

public static class InnerChannelS3StorageFactoryExtensions
{
}
