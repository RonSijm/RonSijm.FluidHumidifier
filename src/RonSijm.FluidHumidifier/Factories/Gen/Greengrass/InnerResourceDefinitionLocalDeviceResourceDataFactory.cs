// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionLocalDeviceResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData>
{

    internal InnerResourceDefinitionGroupOwnerSettingFactory GroupOwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData Create()
    {
        var localDeviceResourceDataResult = CreateLocalDeviceResourceData();
        factoryAction?.Invoke(localDeviceResourceDataResult);

        return localDeviceResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData CreateLocalDeviceResourceData()
    {
        var localDeviceResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData();

        return localDeviceResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData result)
    {
        base.CreateChildren(result);

        result.GroupOwnerSetting ??= GroupOwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionLocalDeviceResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting(this InnerResourceDefinitionLocalDeviceResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null)
    {
        parentFactory.GroupOwnerSettingFactory = new InnerResourceDefinitionGroupOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupOwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, T2, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, T2, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionLocalDeviceResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, T2, T3, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, T2, T3, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionLocalDeviceResourceDataFactory, T3, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionLocalDeviceResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalDeviceResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionLocalDeviceResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, T2, T3, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionLocalDeviceResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionLocalDeviceResourceDataFactory, T3, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionLocalDeviceResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalDeviceResourceDataFactory, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalDeviceResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionLocalDeviceResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T5, subFactoryAction));
}
