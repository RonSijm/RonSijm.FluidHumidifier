// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Panorama;

public class InnerApplicationInstanceManifestOverridesPayloadFactory(Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> factoryAction = null) : SubResourceFactory<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload>
{

    protected override Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload Create()
    {
        var manifestOverridesPayloadResult = CreateManifestOverridesPayload();
        factoryAction?.Invoke(manifestOverridesPayloadResult);

        return manifestOverridesPayloadResult;
    }

    private Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload CreateManifestOverridesPayload()
    {
        var manifestOverridesPayloadResult = new Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload();

        return manifestOverridesPayloadResult;
    }

} // End Of Class

public static class InnerApplicationInstanceManifestOverridesPayloadFactoryExtensions
{
}
