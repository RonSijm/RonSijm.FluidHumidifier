// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileSharingSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.SharingSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.SharingSettings>
{

    protected override Humidifier.SageMaker.UserProfileTypes.SharingSettings Create()
    {
        var sharingSettingsResult = CreateSharingSettings();
        factoryAction?.Invoke(sharingSettingsResult);

        return sharingSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.SharingSettings CreateSharingSettings()
    {
        var sharingSettingsResult = new Humidifier.SageMaker.UserProfileTypes.SharingSettings();

        return sharingSettingsResult;
    }

} // End Of Class

public static class InnerUserProfileSharingSettingsFactoryExtensions
{
}
