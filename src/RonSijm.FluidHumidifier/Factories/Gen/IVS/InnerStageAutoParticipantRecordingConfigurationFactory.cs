// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerStageAutoParticipantRecordingConfigurationFactory(Action<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration>
{

    protected override Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration Create()
    {
        var autoParticipantRecordingConfigurationResult = CreateAutoParticipantRecordingConfiguration();
        factoryAction?.Invoke(autoParticipantRecordingConfigurationResult);

        return autoParticipantRecordingConfigurationResult;
    }

    private Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration CreateAutoParticipantRecordingConfiguration()
    {
        var autoParticipantRecordingConfigurationResult = new Humidifier.IVS.StageTypes.AutoParticipantRecordingConfiguration();

        return autoParticipantRecordingConfigurationResult;
    }

} // End Of Class

public static class InnerStageAutoParticipantRecordingConfigurationFactoryExtensions
{
}
