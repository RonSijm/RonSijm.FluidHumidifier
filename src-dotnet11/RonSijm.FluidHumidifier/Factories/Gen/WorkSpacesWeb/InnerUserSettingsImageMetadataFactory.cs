// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerUserSettingsImageMetadataFactory(Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata>
{

    protected override Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata Create()
    {
        var imageMetadataResult = CreateImageMetadata();
        factoryAction?.Invoke(imageMetadataResult);

        return imageMetadataResult;
    }

    private Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata CreateImageMetadata()
    {
        var imageMetadataResult = new Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata();

        return imageMetadataResult;
    }

} // End Of Class

public static class InnerUserSettingsImageMetadataFactoryExtensions
{
}
