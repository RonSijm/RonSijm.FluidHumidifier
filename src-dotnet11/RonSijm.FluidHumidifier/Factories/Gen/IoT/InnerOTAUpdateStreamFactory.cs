// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateStreamFactory(Action<Humidifier.IoT.OTAUpdateTypes.Stream> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.Stream>
{

    protected override Humidifier.IoT.OTAUpdateTypes.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.Stream CreateStream()
    {
        var streamResult = new Humidifier.IoT.OTAUpdateTypes.Stream();

        return streamResult;
    }

} // End Of Class

public static class InnerOTAUpdateStreamFactoryExtensions
{
}
