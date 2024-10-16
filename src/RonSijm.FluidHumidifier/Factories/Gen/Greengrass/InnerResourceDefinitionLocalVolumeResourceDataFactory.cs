// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionLocalVolumeResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData>
{

    internal InnerResourceDefinitionGroupOwnerSettingFactory GroupOwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData Create()
    {
        var localVolumeResourceDataResult = CreateLocalVolumeResourceData();
        factoryAction?.Invoke(localVolumeResourceDataResult);

        return localVolumeResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData CreateLocalVolumeResourceData()
    {
        var localVolumeResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData();

        return localVolumeResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData result)
    {
        base.CreateChildren(result);

        result.GroupOwnerSetting ??= GroupOwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionLocalVolumeResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting(this InnerResourceDefinitionLocalVolumeResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null)
    {
        parentFactory.GroupOwnerSettingFactory = new InnerResourceDefinitionGroupOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupOwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, T2, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, T2, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionLocalVolumeResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, T2, T3, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, T2, T3, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionLocalVolumeResourceDataFactory, T3, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionLocalVolumeResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalVolumeResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionLocalVolumeResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, T2, T3, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionLocalVolumeResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionLocalVolumeResourceDataFactory, T3, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionLocalVolumeResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalVolumeResourceDataFactory, T4, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionLocalVolumeResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionLocalVolumeResourceDataFactory, InnerResourceDefinitionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T5, subFactoryAction));
}
