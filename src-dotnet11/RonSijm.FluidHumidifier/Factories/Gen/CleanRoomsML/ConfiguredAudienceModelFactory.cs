// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class ConfiguredAudienceModelFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.ConfiguredAudienceModel> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.ConfiguredAudienceModel>(resourceName)
{

    protected override Humidifier.CleanRoomsML.ConfiguredAudienceModel Create()
    {
        var configuredAudienceModelResult = CreateConfiguredAudienceModel();
        factoryAction?.Invoke(configuredAudienceModelResult);

        return configuredAudienceModelResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredAudienceModel CreateConfiguredAudienceModel()
    {
        var configuredAudienceModelResult = new Humidifier.CleanRoomsML.ConfiguredAudienceModel
        {
            GivenName = InputResourceName,
        };

        return configuredAudienceModelResult;
    }

} // End Of Class

public static class ConfiguredAudienceModelFactoryExtensions
{
}
