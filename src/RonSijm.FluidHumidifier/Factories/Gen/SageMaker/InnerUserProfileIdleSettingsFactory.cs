// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileIdleSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.IdleSettings>
{

    protected override Humidifier.SageMaker.UserProfileTypes.IdleSettings Create()
    {
        var idleSettingsResult = CreateIdleSettings();
        factoryAction?.Invoke(idleSettingsResult);

        return idleSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.IdleSettings CreateIdleSettings()
    {
        var idleSettingsResult = new Humidifier.SageMaker.UserProfileTypes.IdleSettings();

        return idleSettingsResult;
    }

} // End Of Class

public static class InnerUserProfileIdleSettingsFactoryExtensions
{
}
