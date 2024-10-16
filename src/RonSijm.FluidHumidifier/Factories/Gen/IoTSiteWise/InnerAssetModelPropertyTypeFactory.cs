// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelPropertyTypeFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.PropertyType>
{

    internal InnerAssetModelAttributeFactory AttributeFactory { get; set; }

    internal InnerAssetModelMetricFactory MetricFactory { get; set; }

    internal InnerAssetModelTransformFactory TransformFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AssetModelTypes.PropertyType Create()
    {
        var propertyTypeResult = CreatePropertyType();
        factoryAction?.Invoke(propertyTypeResult);

        return propertyTypeResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.PropertyType CreatePropertyType()
    {
        var propertyTypeResult = new Humidifier.IoTSiteWise.AssetModelTypes.PropertyType();

        return propertyTypeResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AssetModelTypes.PropertyType result)
    {
        base.CreateChildren(result);

        result.Attribute ??= AttributeFactory?.Build();
        result.Metric ??= MetricFactory?.Build();
        result.Transform ??= TransformFactory?.Build();
    }

} // End Of Class

public static class InnerAssetModelPropertyTypeFactoryExtensions
{
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, InnerAssetModelAttributeFactory> WithAttribute(this InnerAssetModelPropertyTypeFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null)
    {
        parentFactory.AttributeFactory = new InnerAssetModelAttributeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AttributeFactory);
    }

    public static CombinedResult<InnerAssetModelPropertyTypeFactory, InnerAssetModelMetricFactory> WithMetric(this InnerAssetModelPropertyTypeFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null)
    {
        parentFactory.MetricFactory = new InnerAssetModelMetricFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricFactory);
    }

    public static CombinedResult<InnerAssetModelPropertyTypeFactory, InnerAssetModelTransformFactory> WithTransform(this InnerAssetModelPropertyTypeFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null)
    {
        parentFactory.TransformFactory = new InnerAssetModelTransformFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TransformFactory);
    }

    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, InnerAssetModelAttributeFactory> WithAttribute<T1>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttribute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, InnerAssetModelAttributeFactory> WithAttribute<T1>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttribute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, InnerAssetModelAttributeFactory> WithAttribute<T1, T2>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, InnerAssetModelAttributeFactory> WithAttribute<T1, T2>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, InnerAssetModelAttributeFactory> WithAttribute<T1, T2>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, T4, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3, T4>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, T4, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, T4, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, T4, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory, InnerAssetModelAttributeFactory> WithAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttribute(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, InnerAssetModelMetricFactory> WithMetric<T1>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, InnerAssetModelMetricFactory> WithMetric<T1>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, InnerAssetModelMetricFactory> WithMetric<T1, T2>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, InnerAssetModelMetricFactory> WithMetric<T1, T2>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, InnerAssetModelMetricFactory> WithMetric<T1, T2>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, T4, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, T4, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, T4, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, T4, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory, InnerAssetModelMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, InnerAssetModelTransformFactory> WithTransform<T1>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, InnerAssetModelTransformFactory> WithTransform<T1>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, InnerAssetModelTransformFactory> WithTransform<T1, T2>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, InnerAssetModelTransformFactory> WithTransform<T1, T2>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, InnerAssetModelTransformFactory> WithTransform<T1, T2>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, T4, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3, T4>(this CombinedResult<InnerAssetModelPropertyTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, T4, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssetModelPropertyTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, T4, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssetModelPropertyTypeFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, T4, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssetModelPropertyTypeFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory, InnerAssetModelTransformFactory> WithTransform<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssetModelPropertyTypeFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransform(combinedResult.T5, subFactoryAction));
}
