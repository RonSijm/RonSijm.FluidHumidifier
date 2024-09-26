// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class PortalFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.Portal> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.Portal>(resourceName)
{

    protected override Humidifier.WorkSpacesWeb.Portal Create()
    {
        var portalResult = CreatePortal();
        factoryAction?.Invoke(portalResult);

        return portalResult;
    }

    private Humidifier.WorkSpacesWeb.Portal CreatePortal()
    {
        var portalResult = new Humidifier.WorkSpacesWeb.Portal
        {
            GivenName = InputResourceName,
        };

        return portalResult;
    }

} // End Of Class

public static class PortalFactoryExtensions
{
}
