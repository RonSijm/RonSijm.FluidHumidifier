// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerMultiRegionAccessPointRegionFactory(Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> factoryAction = null) : SubResourceFactory<Humidifier.S3.MultiRegionAccessPointTypes.Region>
{

    protected override Humidifier.S3.MultiRegionAccessPointTypes.Region Create()
    {
        var regionResult = CreateRegion();
        factoryAction?.Invoke(regionResult);

        return regionResult;
    }

    private Humidifier.S3.MultiRegionAccessPointTypes.Region CreateRegion()
    {
        var regionResult = new Humidifier.S3.MultiRegionAccessPointTypes.Region();

        return regionResult;
    }

} // End Of Class

public static class InnerMultiRegionAccessPointRegionFactoryExtensions
{
}
