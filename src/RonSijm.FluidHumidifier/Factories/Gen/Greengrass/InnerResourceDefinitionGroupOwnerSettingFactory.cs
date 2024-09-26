// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionGroupOwnerSettingFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting>
{

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting Create()
    {
        var groupOwnerSettingResult = CreateGroupOwnerSetting();
        factoryAction?.Invoke(groupOwnerSettingResult);

        return groupOwnerSettingResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting CreateGroupOwnerSetting()
    {
        var groupOwnerSettingResult = new Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting();

        return groupOwnerSettingResult;
    }

} // End Of Class

public static class InnerResourceDefinitionGroupOwnerSettingFactoryExtensions
{
}
