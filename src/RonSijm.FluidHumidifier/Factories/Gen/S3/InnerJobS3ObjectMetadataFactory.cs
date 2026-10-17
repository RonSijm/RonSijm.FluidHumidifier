// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3ObjectMetadataFactory(Action<Humidifier.S3.JobTypes.S3ObjectMetadata> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3ObjectMetadata>
{

    protected override Humidifier.S3.JobTypes.S3ObjectMetadata Create()
    {
        var s3ObjectMetadataResult = CreateS3ObjectMetadata();
        factoryAction?.Invoke(s3ObjectMetadataResult);

        return s3ObjectMetadataResult;
    }

    private Humidifier.S3.JobTypes.S3ObjectMetadata CreateS3ObjectMetadata()
    {
        var s3ObjectMetadataResult = new Humidifier.S3.JobTypes.S3ObjectMetadata();

        return s3ObjectMetadataResult;
    }

} // End Of Class

public static class InnerJobS3ObjectMetadataFactoryExtensions
{
}
