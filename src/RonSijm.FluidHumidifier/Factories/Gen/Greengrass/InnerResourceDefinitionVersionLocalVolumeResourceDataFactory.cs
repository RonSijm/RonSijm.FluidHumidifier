// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionLocalVolumeResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData>
{

    internal InnerResourceDefinitionVersionGroupOwnerSettingFactory GroupOwnerSettingFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData Create()
    {
        var localVolumeResourceDataResult = CreateLocalVolumeResourceData();
        factoryAction?.Invoke(localVolumeResourceDataResult);

        return localVolumeResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData CreateLocalVolumeResourceData()
    {
        var localVolumeResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData();

        return localVolumeResourceDataResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData result)
    {
        base.CreateChildren(result);

        result.GroupOwnerSetting ??= GroupOwnerSettingFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionVersionLocalVolumeResourceDataFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting(this InnerResourceDefinitionVersionLocalVolumeResourceDataFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null)
    {
        parentFactory.GroupOwnerSettingFactory = new InnerResourceDefinitionVersionGroupOwnerSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupOwnerSettingFactory);
    }

    public static CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, T2, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T2, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, T2, T3, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T2, T3, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T3, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, T2, T3, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T2, T3, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T3, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T4, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory, InnerResourceDefinitionVersionGroupOwnerSettingFactory> WithGroupOwnerSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionLocalVolumeResourceDataFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupOwnerSetting(combinedResult.T5, subFactoryAction));
}
