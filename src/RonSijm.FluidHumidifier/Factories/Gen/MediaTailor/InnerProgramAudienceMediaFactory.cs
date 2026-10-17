// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramAudienceMediaFactory(Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.AudienceMedia>
{

    protected override Humidifier.MediaTailor.ProgramTypes.AudienceMedia Create()
    {
        var audienceMediaResult = CreateAudienceMedia();
        factoryAction?.Invoke(audienceMediaResult);

        return audienceMediaResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.AudienceMedia CreateAudienceMedia()
    {
        var audienceMediaResult = new Humidifier.MediaTailor.ProgramTypes.AudienceMedia();

        return audienceMediaResult;
    }

} // End Of Class

public static class InnerProgramAudienceMediaFactoryExtensions
{
}
