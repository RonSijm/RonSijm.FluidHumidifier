// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class AudienceGenerationJobFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.AudienceGenerationJob> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.AudienceGenerationJob>(resourceName)
{

    protected override Humidifier.CleanRoomsML.AudienceGenerationJob Create()
    {
        var audienceGenerationJobResult = CreateAudienceGenerationJob();
        factoryAction?.Invoke(audienceGenerationJobResult);

        return audienceGenerationJobResult;
    }

    private Humidifier.CleanRoomsML.AudienceGenerationJob CreateAudienceGenerationJob()
    {
        var audienceGenerationJobResult = new Humidifier.CleanRoomsML.AudienceGenerationJob
        {
            GivenName = InputResourceName,
        };

        return audienceGenerationJobResult;
    }

} // End Of Class

public static class AudienceGenerationJobFactoryExtensions
{
}
