// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerHarvestJobHarvestedManifestsFactory(Action<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests>
{

    protected override Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests Create()
    {
        var harvestedManifestsResult = CreateHarvestedManifests();
        factoryAction?.Invoke(harvestedManifestsResult);

        return harvestedManifestsResult;
    }

    private Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests CreateHarvestedManifests()
    {
        var harvestedManifestsResult = new Humidifier.MediaPackageV2.HarvestJobTypes.HarvestedManifests();

        return harvestedManifestsResult;
    }

} // End Of Class

public static class InnerHarvestJobHarvestedManifestsFactoryExtensions
{
}
