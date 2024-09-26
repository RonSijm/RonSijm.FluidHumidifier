// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainStudioWebPortalSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings Create()
    {
        var studioWebPortalSettingsResult = CreateStudioWebPortalSettings();
        factoryAction?.Invoke(studioWebPortalSettingsResult);

        return studioWebPortalSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings CreateStudioWebPortalSettings()
    {
        var studioWebPortalSettingsResult = new Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings();

        return studioWebPortalSettingsResult;
    }

} // End Of Class

public static class InnerDomainStudioWebPortalSettingsFactoryExtensions
{
}
