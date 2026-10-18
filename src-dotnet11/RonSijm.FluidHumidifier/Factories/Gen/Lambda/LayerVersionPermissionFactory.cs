// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class LayerVersionPermissionFactory(string resourceName = null, Action<Humidifier.Lambda.LayerVersionPermission> factoryAction = null) : ResourceFactory<Humidifier.Lambda.LayerVersionPermission>(resourceName)
{

    protected override Humidifier.Lambda.LayerVersionPermission Create()
    {
        var layerVersionPermissionResult = CreateLayerVersionPermission();
        factoryAction?.Invoke(layerVersionPermissionResult);

        return layerVersionPermissionResult;
    }

    private Humidifier.Lambda.LayerVersionPermission CreateLayerVersionPermission()
    {
        var layerVersionPermissionResult = new Humidifier.Lambda.LayerVersionPermission
        {
            GivenName = InputResourceName,
        };

        return layerVersionPermissionResult;
    }

} // End Of Class

public static class LayerVersionPermissionFactoryExtensions
{
}
