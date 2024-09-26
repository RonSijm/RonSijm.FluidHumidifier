// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionLocalDeviceResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData>
{

    internal InnerResourceDefinitionVersionGroupOwnerSettingFactory GroupOwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData Create()
    {
        var localDeviceResourceDataResult = CreateLocalDeviceResourceData();
        factoryAction?.Invoke(localDeviceResourceDataResult);

        return localDeviceResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData CreateLocalDeviceResourceData()
    {
        var localDeviceResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData();

        return localDeviceResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData result)
    {
        base.CreateChildren(result);

        result.GroupOwnerSetting ??= GroupOwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionVersionLocalDeviceResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting(this InnerResourceDefinitionVersionLocalDeviceResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null)
    {
        parentFactory.GroupOwnerSettingFactory = new InnerResourceDefinitionVersionGroupOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupOwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, T2, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T2, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, T2, T3, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T2, T3, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T3, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T2, T3, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T3, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionLocalDeviceResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T5, subFactoryAction));
}
