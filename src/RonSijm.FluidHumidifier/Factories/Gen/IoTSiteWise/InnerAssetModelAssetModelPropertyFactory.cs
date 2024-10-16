// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelAssetModelPropertyFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty>
{

    internal InnerAssetModelPropertyTypeFactory TypeFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty Create()
    {
        var assetModelPropertyResult = CreateAssetModelProperty();
        factoryAction?.Invoke(assetModelPropertyResult);

        return assetModelPropertyResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty CreateAssetModelProperty()
    {
        var assetModelPropertyResult = new Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty();

        return assetModelPropertyResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AssetModelTypes.AssetModelProperty result)
    {
        base.CreateChildren(result);

        result.Type ??= TypeFactory?.Build();
    }

} // End Of Class

public static class InnerAssetModelAssetModelPropertyFactoryExtensions
{
    public static CombinedResult<InnerAssetModelAssetModelPropertyFactory, InnerAssetModelPropertyTypeFactory> WithType(this InnerAssetModelAssetModelPropertyFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null)
    {
        parentFactory.TypeFactory = new InnerAssetModelPropertyTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TypeFactory);
    }

    public static CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, InnerAssetModelPropertyTypeFactory> WithType<T1>(this CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, WithType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, InnerAssetModelPropertyTypeFactory> WithType<T1>(this CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, WithType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, T2, InnerAssetModelPropertyTypeFactory> WithType<T1, T2>(this CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, T2, InnerAssetModelPropertyTypeFactory> WithType<T1, T2>(this CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelAssetModelPropertyFactory, InnerAssetModelPropertyTypeFactory> WithType<T1, T2>(this CombinedResult<T1, T2, InnerAssetModelAssetModelPropertyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, T2, T3, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3>(this CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, T2, T3, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3>(this CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelAssetModelPropertyFactory, T3, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssetModelAssetModelPropertyFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelAssetModelPropertyFactory, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssetModelAssetModelPropertyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3, T4>(this CombinedResult<InnerAssetModelAssetModelPropertyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, T2, T3, T4, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssetModelAssetModelPropertyFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelAssetModelPropertyFactory, T3, T4, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssetModelAssetModelPropertyFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelAssetModelPropertyFactory, T4, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssetModelAssetModelPropertyFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssetModelAssetModelPropertyFactory, InnerAssetModelPropertyTypeFactory> WithType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssetModelAssetModelPropertyFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithType(combinedResult.T5, subFactoryAction));
}
