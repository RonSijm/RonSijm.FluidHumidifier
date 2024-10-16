// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyPortalFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal>
{

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.Portal Create()
    {
        var portalResult = CreatePortal();
        factoryAction?.Invoke(portalResult);

        return portalResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.Portal CreatePortal()
    {
        var portalResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.Portal();

        return portalResult;
    }

} // End Of Class

public static class InnerAccessPolicyPortalFactoryExtensions
{
}
