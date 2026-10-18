// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileEmrSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.EmrSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.EmrSettings>
{

    protected override Humidifier.SageMaker.UserProfileTypes.EmrSettings Create()
    {
        var emrSettingsResult = CreateEmrSettings();
        factoryAction?.Invoke(emrSettingsResult);

        return emrSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.EmrSettings CreateEmrSettings()
    {
        var emrSettingsResult = new Humidifier.SageMaker.UserProfileTypes.EmrSettings();

        return emrSettingsResult;
    }

} // End Of Class

public static class InnerUserProfileEmrSettingsFactoryExtensions
{
}
