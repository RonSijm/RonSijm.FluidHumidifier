// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileDefaultEbsStorageSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings>
{

    protected override Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings Create()
    {
        var defaultEbsStorageSettingsResult = CreateDefaultEbsStorageSettings();
        factoryAction?.Invoke(defaultEbsStorageSettingsResult);

        return defaultEbsStorageSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings CreateDefaultEbsStorageSettings()
    {
        var defaultEbsStorageSettingsResult = new Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings();

        return defaultEbsStorageSettingsResult;
    }

} // End Of Class

public static class InnerUserProfileDefaultEbsStorageSettingsFactoryExtensions
{
}
