// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileRStudioServerProAppSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.RStudioServerProAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.RStudioServerProAppSettings>
{

    protected override Humidifier.SageMaker.UserProfileTypes.RStudioServerProAppSettings Create()
    {
        var rStudioServerProAppSettingsResult = CreateRStudioServerProAppSettings();
        factoryAction?.Invoke(rStudioServerProAppSettingsResult);

        return rStudioServerProAppSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.RStudioServerProAppSettings CreateRStudioServerProAppSettings()
    {
        var rStudioServerProAppSettingsResult = new Humidifier.SageMaker.UserProfileTypes.RStudioServerProAppSettings();

        return rStudioServerProAppSettingsResult;
    }

} // End Of Class

public static class InnerUserProfileRStudioServerProAppSettingsFactoryExtensions
{
}
