// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestObdInterfaceFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdInterface> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdInterface>
{

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.ObdInterface Create()
    {
        var obdInterfaceResult = CreateObdInterface();
        factoryAction?.Invoke(obdInterfaceResult);

        return obdInterfaceResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.ObdInterface CreateObdInterface()
    {
        var obdInterfaceResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.ObdInterface();

        return obdInterfaceResult;
    }

} // End Of Class

public static class InnerDecoderManifestObdInterfaceFactoryExtensions
{
}
