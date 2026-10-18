// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketRecordExpirationFactory(Action<Humidifier.S3.BucketTypes.RecordExpiration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.RecordExpiration>
{

    protected override Humidifier.S3.BucketTypes.RecordExpiration Create()
    {
        var recordExpirationResult = CreateRecordExpiration();
        factoryAction?.Invoke(recordExpirationResult);

        return recordExpirationResult;
    }

    private Humidifier.S3.BucketTypes.RecordExpiration CreateRecordExpiration()
    {
        var recordExpirationResult = new Humidifier.S3.BucketTypes.RecordExpiration();

        return recordExpirationResult;
    }

} // End Of Class

public static class InnerBucketRecordExpirationFactoryExtensions
{
}
