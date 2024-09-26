// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class TransformerFactory(string resourceName = null, Action<Humidifier.B2BI.Transformer> factoryAction = null) : ResourceFactory<Humidifier.B2BI.Transformer>(resourceName)
{

    internal InnerTransformerEdiTypeFactory EdiTypeFactory { get; set; }

    protected override Humidifier.B2BI.Transformer Create()
    {
        var transformerResult = CreateTransformer();
        factoryAction?.Invoke(transformerResult);

        return transformerResult;
    }

    private Humidifier.B2BI.Transformer CreateTransformer()
    {
        var transformerResult = new Humidifier.B2BI.Transformer
        {
            GivenName = InputResourceName,
        };

        return transformerResult;
    }
    public override void CreateChildren(Humidifier.B2BI.Transformer result)
    {
        base.CreateChildren(result);

        result.EdiType ??= EdiTypeFactory?.Build();
    }

} // End Of Class

public static class TransformerFactoryExtensions
{
    public static CombinedResult<TransformerFactory, InnerTransformerEdiTypeFactory> WithEdiType(this TransformerFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null)
    {
        parentFactory.EdiTypeFactory = new InnerTransformerEdiTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EdiTypeFactory);
    }

    public static CombinedResult<TransformerFactory, T1, InnerTransformerEdiTypeFactory> WithEdiType<T1>(this CombinedResult<TransformerFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, WithEdiType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, InnerTransformerEdiTypeFactory> WithEdiType<T1>(this CombinedResult<T1, TransformerFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, WithEdiType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TransformerFactory, T1, T2, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2>(this CombinedResult<TransformerFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, T2, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2>(this CombinedResult<T1, TransformerFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransformerFactory, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2>(this CombinedResult<T1, T2, TransformerFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TransformerFactory, T1, T2, T3, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3>(this CombinedResult<TransformerFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, T2, T3, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3>(this CombinedResult<T1, TransformerFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransformerFactory, T3, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3>(this CombinedResult<T1, T2, TransformerFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransformerFactory, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransformerFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TransformerFactory, T1, T2, T3, T4, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3, T4>(this CombinedResult<TransformerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransformerFactory, T2, T3, T4, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3, T4>(this CombinedResult<T1, TransformerFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransformerFactory, T3, T4, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransformerFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransformerFactory, T4, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransformerFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TransformerFactory, InnerTransformerEdiTypeFactory> WithEdiType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransformerFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.EdiType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdiType(combinedResult.T5, subFactoryAction));
}
