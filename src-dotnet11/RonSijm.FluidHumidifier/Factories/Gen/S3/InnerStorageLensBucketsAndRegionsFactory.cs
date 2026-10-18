// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensBucketsAndRegionsFactory(Action<Humidifier.S3.StorageLensTypes.BucketsAndRegions> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.BucketsAndRegions>
{

    protected override Humidifier.S3.StorageLensTypes.BucketsAndRegions Create()
    {
        var bucketsAndRegionsResult = CreateBucketsAndRegions();
        factoryAction?.Invoke(bucketsAndRegionsResult);

        return bucketsAndRegionsResult;
    }

    private Humidifier.S3.StorageLensTypes.BucketsAndRegions CreateBucketsAndRegions()
    {
        var bucketsAndRegionsResult = new Humidifier.S3.StorageLensTypes.BucketsAndRegions();

        return bucketsAndRegionsResult;
    }

} // End Of Class

public static class InnerStorageLensBucketsAndRegionsFactoryExtensions
{
}
