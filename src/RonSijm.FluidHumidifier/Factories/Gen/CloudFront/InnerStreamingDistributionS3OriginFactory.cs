// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerStreamingDistributionS3OriginFactory(Action<Humidifier.CloudFront.StreamingDistributionTypes.S3Origin> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.StreamingDistributionTypes.S3Origin>
{

    protected override Humidifier.CloudFront.StreamingDistributionTypes.S3Origin Create()
    {
        var s3OriginResult = CreateS3Origin();
        factoryAction?.Invoke(s3OriginResult);

        return s3OriginResult;
    }

    private Humidifier.CloudFront.StreamingDistributionTypes.S3Origin CreateS3Origin()
    {
        var s3OriginResult = new Humidifier.CloudFront.StreamingDistributionTypes.S3Origin();

        return s3OriginResult;
    }

} // End Of Class

public static class InnerStreamingDistributionS3OriginFactoryExtensions
{
}
