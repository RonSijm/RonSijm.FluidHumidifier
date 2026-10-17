// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestCustomDecodingInterfaceFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingInterface> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingInterface>
{

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingInterface Create()
    {
        var customDecodingInterfaceResult = CreateCustomDecodingInterface();
        factoryAction?.Invoke(customDecodingInterfaceResult);

        return customDecodingInterfaceResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingInterface CreateCustomDecodingInterface()
    {
        var customDecodingInterfaceResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingInterface();

        return customDecodingInterfaceResult;
    }

} // End Of Class

public static class InnerDecoderManifestCustomDecodingInterfaceFactoryExtensions
{
}
