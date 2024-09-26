// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestCanInterfaceFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanInterface> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.CanInterface>
{

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.CanInterface Create()
    {
        var canInterfaceResult = CreateCanInterface();
        factoryAction?.Invoke(canInterfaceResult);

        return canInterfaceResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.CanInterface CreateCanInterface()
    {
        var canInterfaceResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.CanInterface();

        return canInterfaceResult;
    }

} // End Of Class

public static class InnerDecoderManifestCanInterfaceFactoryExtensions
{
}
