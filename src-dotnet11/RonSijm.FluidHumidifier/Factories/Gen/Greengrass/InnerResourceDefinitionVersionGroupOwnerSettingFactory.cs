// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionGroupOwnerSettingFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting>
{

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting Create()
    {
        var groupOwnerSettingResult = CreateGroupOwnerSetting();
        factoryAction?.Invoke(groupOwnerSettingResult);

        return groupOwnerSettingResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting CreateGroupOwnerSetting()
    {
        var groupOwnerSettingResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting();

        return groupOwnerSettingResult;
    }

} // End Of Class

public static class InnerResourceDefinitionVersionGroupOwnerSettingFactoryExtensions
{
}
