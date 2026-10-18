// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting>
{

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting Create()
    {
        var resourceDownloadOwnerSettingResult = CreateResourceDownloadOwnerSetting();
        factoryAction?.Invoke(resourceDownloadOwnerSettingResult);

        return resourceDownloadOwnerSettingResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting CreateResourceDownloadOwnerSetting()
    {
        var resourceDownloadOwnerSettingResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting();

        return resourceDownloadOwnerSettingResult;
    }

} // End Of Class

public static class InnerResourceDefinitionVersionResourceDownloadOwnerSettingFactoryExtensions
{
}
