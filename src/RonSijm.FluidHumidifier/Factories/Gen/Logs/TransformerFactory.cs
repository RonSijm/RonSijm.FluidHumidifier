// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class TransformerFactory(string resourceName = null, Action<Humidifier.Logs.Transformer> factoryAction = null) : ResourceFactory<Humidifier.Logs.Transformer>(resourceName)
{

    internal List<InnerTransformerProcessorFactory> TransformerConfigFactories { get; set; } = [];

    protected override Humidifier.Logs.Transformer Create()
    {
        var transformerResult = CreateTransformer();
        factoryAction?.Invoke(transformerResult);

        return transformerResult;
    }

    private Humidifier.Logs.Transformer CreateTransformer()
    {
        var transformerResult = new Humidifier.Logs.Transformer
        {
            GivenName = InputResourceName,
        };

        return transformerResult;
    }
    public override void CreateChildren(Humidifier.Logs.Transformer result)
    {
        base.CreateChildren(result);

        result.TransformerConfig = TransformerConfigFactories.Any() ? TransformerConfigFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TransformerFactoryExtensions
{
    public static CombinedResult<TransformerFactory, InnerTransformerProcessorFactory> WithTransformerConfig(this TransformerFactory parentFactory, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null)
    {
        var factory = new InnerTransformerProcessorFactory(subFactoryAction);
        parentFactory.TransformerConfigFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TransformerFactory, T1, InnerTransformerProcessorFactory> WithTransformerConfig<T1>(this CombinedResult<TransformerFactory, T1> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransformerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, InnerTransformerProcessorFactory> WithTransformerConfig<T1>(this CombinedResult<T1, TransformerFactory> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransformerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TransformerFactory, T1, T2, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2>(this CombinedResult<TransformerFactory, T1, T2> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, T2, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2>(this CombinedResult<T1, TransformerFactory, T2> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransformerFactory, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2>(this CombinedResult<T1, T2, TransformerFactory> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TransformerFactory, T1, T2, T3, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3>(this CombinedResult<TransformerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, T2, T3, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3>(this CombinedResult<T1, TransformerFactory, T2, T3> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransformerFactory, T3, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3>(this CombinedResult<T1, T2, TransformerFactory, T3> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransformerFactory, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransformerFactory> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TransformerFactory, T1, T2, T3, T4, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3, T4>(this CombinedResult<TransformerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, T2, T3, T4, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3, T4>(this CombinedResult<T1, TransformerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransformerFactory, T3, T4, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransformerFactory, T3, T4> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransformerFactory, T4, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransformerFactory, T4> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TransformerFactory, InnerTransformerProcessorFactory> WithTransformerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransformerFactory> combinedResult, Action<Humidifier.Logs.TransformerTypes.Processor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformerConfig(combinedResult.T5, subFactoryAction));
}
