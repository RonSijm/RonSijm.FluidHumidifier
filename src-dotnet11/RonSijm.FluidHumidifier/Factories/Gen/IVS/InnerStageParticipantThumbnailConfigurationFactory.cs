// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerStageParticipantThumbnailConfigurationFactory(Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration>
{

    protected override Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration Create()
    {
        var participantThumbnailConfigurationResult = CreateParticipantThumbnailConfiguration();
        factoryAction?.Invoke(participantThumbnailConfigurationResult);

        return participantThumbnailConfigurationResult;
    }

    private Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration CreateParticipantThumbnailConfiguration()
    {
        var participantThumbnailConfigurationResult = new Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration();

        return participantThumbnailConfigurationResult;
    }

} // End Of Class

public static class InnerStageParticipantThumbnailConfigurationFactoryExtensions
{
}
