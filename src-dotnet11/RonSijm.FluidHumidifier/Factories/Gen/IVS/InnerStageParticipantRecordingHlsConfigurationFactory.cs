// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerStageParticipantRecordingHlsConfigurationFactory(Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration>
{

    protected override Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration Create()
    {
        var participantRecordingHlsConfigurationResult = CreateParticipantRecordingHlsConfiguration();
        factoryAction?.Invoke(participantRecordingHlsConfigurationResult);

        return participantRecordingHlsConfigurationResult;
    }

    private Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration CreateParticipantRecordingHlsConfiguration()
    {
        var participantRecordingHlsConfigurationResult = new Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration();

        return participantRecordingHlsConfigurationResult;
    }

} // End Of Class

public static class InnerStageParticipantRecordingHlsConfigurationFactoryExtensions
{
}
