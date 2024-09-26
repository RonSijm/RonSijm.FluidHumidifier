// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerMissionProfileStreamsKmsKeyFactory(Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey>
{

    protected override Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey Create()
    {
        var streamsKmsKeyResult = CreateStreamsKmsKey();
        factoryAction?.Invoke(streamsKmsKeyResult);

        return streamsKmsKeyResult;
    }

    private Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey CreateStreamsKmsKey()
    {
        var streamsKmsKeyResult = new Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey();

        return streamsKmsKeyResult;
    }

} // End Of Class

public static class InnerMissionProfileStreamsKmsKeyFactoryExtensions
{
}
