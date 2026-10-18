// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Panorama;

public class InnerApplicationInstanceManifestPayloadFactory(Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> factoryAction = null) : SubResourceFactory<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload>
{

    protected override Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload Create()
    {
        var manifestPayloadResult = CreateManifestPayload();
        factoryAction?.Invoke(manifestPayloadResult);

        return manifestPayloadResult;
    }

    private Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload CreateManifestPayload()
    {
        var manifestPayloadResult = new Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload();

        return manifestPayloadResult;
    }

} // End Of Class

public static class InnerApplicationInstanceManifestPayloadFactoryExtensions
{
}
