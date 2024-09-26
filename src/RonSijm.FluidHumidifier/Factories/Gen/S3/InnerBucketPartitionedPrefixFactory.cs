// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketPartitionedPrefixFactory(Action<Humidifier.S3.BucketTypes.PartitionedPrefix> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.PartitionedPrefix>
{

    protected override Humidifier.S3.BucketTypes.PartitionedPrefix Create()
    {
        var partitionedPrefixResult = CreatePartitionedPrefix();
        factoryAction?.Invoke(partitionedPrefixResult);

        return partitionedPrefixResult;
    }

    private Humidifier.S3.BucketTypes.PartitionedPrefix CreatePartitionedPrefix()
    {
        var partitionedPrefixResult = new Humidifier.S3.BucketTypes.PartitionedPrefix();

        return partitionedPrefixResult;
    }

} // End Of Class

public static class InnerBucketPartitionedPrefixFactoryExtensions
{
}
