// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerFormatOptionsFactory(Action<Humidifier.B2BI.TransformerTypes.FormatOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.FormatOptions>
{

    internal InnerTransformerX12DetailsFactory X12Factory { get; set; }

    protected override Humidifier.B2BI.TransformerTypes.FormatOptions Create()
    {
        var formatOptionsResult = CreateFormatOptions();
        factoryAction?.Invoke(formatOptionsResult);

        return formatOptionsResult;
    }

    private Humidifier.B2BI.TransformerTypes.FormatOptions CreateFormatOptions()
    {
        var formatOptionsResult = new Humidifier.B2BI.TransformerTypes.FormatOptions();

        return formatOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.TransformerTypes.FormatOptions result)
    {
        base.CreateChildren(result);

        result.X12 ??= X12Factory?.Build();
    }

} // End Of Class

public static class InnerTransformerFormatOptionsFactoryExtensions
{
    public static CombinedResult<InnerTransformerFormatOptionsFactory, InnerTransformerX12DetailsFactory> WithX12(this InnerTransformerFormatOptionsFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null)
    {
        parentFactory.X12Factory = new InnerTransformerX12DetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.X12Factory);
    }

    public static CombinedResult<InnerTransformerFormatOptionsFactory, T1, InnerTransformerX12DetailsFactory> WithX12<T1>(this CombinedResult<InnerTransformerFormatOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerFormatOptionsFactory, InnerTransformerX12DetailsFactory> WithX12<T1>(this CombinedResult<T1, InnerTransformerFormatOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTransformerFormatOptionsFactory, T1, T2, InnerTransformerX12DetailsFactory> WithX12<T1, T2>(this CombinedResult<InnerTransformerFormatOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerFormatOptionsFactory, T2, InnerTransformerX12DetailsFactory> WithX12<T1, T2>(this CombinedResult<T1, InnerTransformerFormatOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerFormatOptionsFactory, InnerTransformerX12DetailsFactory> WithX12<T1, T2>(this CombinedResult<T1, T2, InnerTransformerFormatOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTransformerFormatOptionsFactory, T1, T2, T3, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3>(this CombinedResult<InnerTransformerFormatOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerFormatOptionsFactory, T2, T3, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, InnerTransformerFormatOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerFormatOptionsFactory, T3, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerFormatOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerFormatOptionsFactory, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerFormatOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTransformerFormatOptionsFactory, T1, T2, T3, T4, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<InnerTransformerFormatOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerFormatOptionsFactory, T2, T3, T4, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerFormatOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerFormatOptionsFactory, T3, T4, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerFormatOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerFormatOptionsFactory, T4, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerFormatOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerFormatOptionsFactory, InnerTransformerX12DetailsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerFormatOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T5, subFactoryAction));
}
