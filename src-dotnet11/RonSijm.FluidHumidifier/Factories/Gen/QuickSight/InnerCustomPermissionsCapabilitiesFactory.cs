// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerCustomPermissionsCapabilitiesFactory(Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities>
{

    protected override Humidifier.QuickSight.CustomPermissionsTypes.Capabilities Create()
    {
        var capabilitiesResult = CreateCapabilities();
        factoryAction?.Invoke(capabilitiesResult);

        return capabilitiesResult;
    }

    private Humidifier.QuickSight.CustomPermissionsTypes.Capabilities CreateCapabilities()
    {
        var capabilitiesResult = new Humidifier.QuickSight.CustomPermissionsTypes.Capabilities();

        return capabilitiesResult;
    }

} // End Of Class

public static class InnerCustomPermissionsCapabilitiesFactoryExtensions
{
}
