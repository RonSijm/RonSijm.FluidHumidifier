// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerSiteLocationFactory(Action<Humidifier.NetworkManager.SiteTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.SiteTypes.Location>
{

    protected override Humidifier.NetworkManager.SiteTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.NetworkManager.SiteTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.NetworkManager.SiteTypes.Location();

        return locationResult;
    }

} // End Of Class

public static class InnerSiteLocationFactoryExtensions
{
}
