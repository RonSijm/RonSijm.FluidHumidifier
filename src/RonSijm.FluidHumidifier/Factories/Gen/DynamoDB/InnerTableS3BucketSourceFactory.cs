// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableS3BucketSourceFactory(Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.S3BucketSource>
{

    protected override Humidifier.DynamoDB.TableTypes.S3BucketSource Create()
    {
        var s3BucketSourceResult = CreateS3BucketSource();
        factoryAction?.Invoke(s3BucketSourceResult);

        return s3BucketSourceResult;
    }

    private Humidifier.DynamoDB.TableTypes.S3BucketSource CreateS3BucketSource()
    {
        var s3BucketSourceResult = new Humidifier.DynamoDB.TableTypes.S3BucketSource();

        return s3BucketSourceResult;
    }

} // End Of Class

public static class InnerTableS3BucketSourceFactoryExtensions
{
}
