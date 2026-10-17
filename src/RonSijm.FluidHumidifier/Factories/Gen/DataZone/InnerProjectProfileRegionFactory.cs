// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectProfileRegionFactory(Action<Humidifier.DataZone.ProjectProfileTypes.Region> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectProfileTypes.Region>
{

    protected override Humidifier.DataZone.ProjectProfileTypes.Region Create()
    {
        var regionResult = CreateRegion();
        factoryAction?.Invoke(regionResult);

        return regionResult;
    }

    private Humidifier.DataZone.ProjectProfileTypes.Region CreateRegion()
    {
        var regionResult = new Humidifier.DataZone.ProjectProfileTypes.Region();

        return regionResult;
    }

} // End Of Class

public static class InnerProjectProfileRegionFactoryExtensions
{
}
