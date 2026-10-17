// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class AudienceModelFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.AudienceModel> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.AudienceModel>(resourceName)
{

    protected override Humidifier.CleanRoomsML.AudienceModel Create()
    {
        var audienceModelResult = CreateAudienceModel();
        factoryAction?.Invoke(audienceModelResult);

        return audienceModelResult;
    }

    private Humidifier.CleanRoomsML.AudienceModel CreateAudienceModel()
    {
        var audienceModelResult = new Humidifier.CleanRoomsML.AudienceModel
        {
            GivenName = InputResourceName,
        };

        return audienceModelResult;
    }

} // End Of Class

public static class AudienceModelFactoryExtensions
{
}
