// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionResourceDownloadOwnerSettingFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting>
{

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting Create()
    {
        var resourceDownloadOwnerSettingResult = CreateResourceDownloadOwnerSetting();
        factoryAction?.Invoke(resourceDownloadOwnerSettingResult);

        return resourceDownloadOwnerSettingResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting CreateResourceDownloadOwnerSetting()
    {
        var resourceDownloadOwnerSettingResult = new Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting();

        return resourceDownloadOwnerSettingResult;
    }

} // End Of Class

public static class InnerResourceDefinitionResourceDownloadOwnerSettingFactoryExtensions
{
}
