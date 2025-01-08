// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerOutputConversionFactory(Action<Humidifier.B2BI.TransformerTypes.OutputConversion> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.OutputConversion>
{

    internal InnerTransformerFormatOptionsFactory FormatOptionsFactory { get; set; }

    protected override Humidifier.B2BI.TransformerTypes.OutputConversion Create()
    {
        var outputConversionResult = CreateOutputConversion();
        factoryAction?.Invoke(outputConversionResult);

        return outputConversionResult;
    }

    private Humidifier.B2BI.TransformerTypes.OutputConversion CreateOutputConversion()
    {
        var outputConversionResult = new Humidifier.B2BI.TransformerTypes.OutputConversion();

        return outputConversionResult;
    }
    public override void CreateChildren(Humidifier.B2BI.TransformerTypes.OutputConversion result)
    {
        base.CreateChildren(result);

        result.FormatOptions ??= FormatOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTransformerOutputConversionFactoryExtensions
{
    public static CombinedResult<InnerTransformerOutputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions(this InnerTransformerOutputConversionFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null)
    {
        parentFactory.FormatOptionsFactory = new InnerTransformerFormatOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FormatOptionsFactory);
    }

    public static CombinedResult<InnerTransformerOutputConversionFactory, T1, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<InnerTransformerOutputConversionFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerOutputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<T1, InnerTransformerOutputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTransformerOutputConversionFactory, T1, T2, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<InnerTransformerOutputConversionFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerOutputConversionFactory, T2, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, InnerTransformerOutputConversionFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerOutputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, T2, InnerTransformerOutputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTransformerOutputConversionFactory, T1, T2, T3, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<InnerTransformerOutputConversionFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerOutputConversionFactory, T2, T3, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, InnerTransformerOutputConversionFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerOutputConversionFactory, T3, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerOutputConversionFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerOutputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerOutputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTransformerOutputConversionFactory, T1, T2, T3, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<InnerTransformerOutputConversionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerOutputConversionFactory, T2, T3, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerOutputConversionFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerOutputConversionFactory, T3, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerOutputConversionFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerOutputConversionFactory, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerOutputConversionFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerOutputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerOutputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T5, subFactoryAction));
}
