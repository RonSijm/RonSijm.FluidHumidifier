// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class LayerVersionFactory(string resourceName = null, Action<Humidifier.Lambda.LayerVersion> factoryAction = null) : ResourceFactory<Humidifier.Lambda.LayerVersion>(resourceName)
{

    internal InnerLayerVersionContentFactory ContentFactory { get; set; }

    protected override Humidifier.Lambda.LayerVersion Create()
    {
        var layerVersionResult = CreateLayerVersion();
        factoryAction?.Invoke(layerVersionResult);

        return layerVersionResult;
    }

    private Humidifier.Lambda.LayerVersion CreateLayerVersion()
    {
        var layerVersionResult = new Humidifier.Lambda.LayerVersion
        {
            GivenName = InputResourceName,
        };

        return layerVersionResult;
    }
    public override void CreateChildren(Humidifier.Lambda.LayerVersion result)
    {
        base.CreateChildren(result);

        result.Content ??= ContentFactory?.Build();
    }

} // End Of Class

public static class LayerVersionFactoryExtensions
{
    public static CombinedResult<LayerVersionFactory, InnerLayerVersionContentFactory> WithContent(this LayerVersionFactory parentFactory, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null)
    {
        parentFactory.ContentFactory = new InnerLayerVersionContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFactory);
    }

    public static CombinedResult<LayerVersionFactory, T1, InnerLayerVersionContentFactory> WithContent<T1>(this CombinedResult<LayerVersionFactory, T1> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LayerVersionFactory, InnerLayerVersionContentFactory> WithContent<T1>(this CombinedResult<T1, LayerVersionFactory> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LayerVersionFactory, T1, T2, InnerLayerVersionContentFactory> WithContent<T1, T2>(this CombinedResult<LayerVersionFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LayerVersionFactory, T2, InnerLayerVersionContentFactory> WithContent<T1, T2>(this CombinedResult<T1, LayerVersionFactory, T2> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LayerVersionFactory, InnerLayerVersionContentFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, LayerVersionFactory> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LayerVersionFactory, T1, T2, T3, InnerLayerVersionContentFactory> WithContent<T1, T2, T3>(this CombinedResult<LayerVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LayerVersionFactory, T2, T3, InnerLayerVersionContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, LayerVersionFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LayerVersionFactory, T3, InnerLayerVersionContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, LayerVersionFactory, T3> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LayerVersionFactory, InnerLayerVersionContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, LayerVersionFactory> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LayerVersionFactory, T1, T2, T3, T4, InnerLayerVersionContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<LayerVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LayerVersionFactory, T2, T3, T4, InnerLayerVersionContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, LayerVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LayerVersionFactory, T3, T4, InnerLayerVersionContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, LayerVersionFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LayerVersionFactory, T4, InnerLayerVersionContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LayerVersionFactory, T4> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LayerVersionFactory, InnerLayerVersionContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LayerVersionFactory> combinedResult, Action<Humidifier.Lambda.LayerVersionTypes.Content> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction));
}
