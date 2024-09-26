// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileStudioWebPortalSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.StudioWebPortalSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.StudioWebPortalSettings>
{

    protected override Humidifier.SageMaker.UserProfileTypes.StudioWebPortalSettings Create()
    {
        var studioWebPortalSettingsResult = CreateStudioWebPortalSettings();
        factoryAction?.Invoke(studioWebPortalSettingsResult);

        return studioWebPortalSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.StudioWebPortalSettings CreateStudioWebPortalSettings()
    {
        var studioWebPortalSettingsResult = new Humidifier.SageMaker.UserProfileTypes.StudioWebPortalSettings();

        return studioWebPortalSettingsResult;
    }

} // End Of Class

public static class InnerUserProfileStudioWebPortalSettingsFactoryExtensions
{
}
