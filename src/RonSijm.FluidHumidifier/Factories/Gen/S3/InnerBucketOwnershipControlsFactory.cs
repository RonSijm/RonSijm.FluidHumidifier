// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketOwnershipControlsFactory(Action<Humidifier.S3.BucketTypes.OwnershipControls> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.OwnershipControls>
{

    protected override Humidifier.S3.BucketTypes.OwnershipControls Create()
    {
        var ownershipControlsResult = CreateOwnershipControls();
        factoryAction?.Invoke(ownershipControlsResult);

        return ownershipControlsResult;
    }

    private Humidifier.S3.BucketTypes.OwnershipControls CreateOwnershipControls()
    {
        var ownershipControlsResult = new Humidifier.S3.BucketTypes.OwnershipControls();

        return ownershipControlsResult;
    }

} // End Of Class

public static class InnerBucketOwnershipControlsFactoryExtensions
{
}
