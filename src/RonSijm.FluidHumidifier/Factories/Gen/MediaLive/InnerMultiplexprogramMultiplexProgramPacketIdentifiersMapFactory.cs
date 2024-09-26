// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexprogramMultiplexProgramPacketIdentifiersMapFactory(Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap>
{

    protected override Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap Create()
    {
        var multiplexProgramPacketIdentifiersMapResult = CreateMultiplexProgramPacketIdentifiersMap();
        factoryAction?.Invoke(multiplexProgramPacketIdentifiersMapResult);

        return multiplexProgramPacketIdentifiersMapResult;
    }

    private Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap CreateMultiplexProgramPacketIdentifiersMap()
    {
        var multiplexProgramPacketIdentifiersMapResult = new Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramPacketIdentifiersMap();

        return multiplexProgramPacketIdentifiersMapResult;
    }

} // End Of Class

public static class InnerMultiplexprogramMultiplexProgramPacketIdentifiersMapFactoryExtensions
{
}
