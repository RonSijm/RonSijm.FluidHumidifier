// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerInputConversionFactory(Action<Humidifier.B2BI.TransformerTypes.InputConversion> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.InputConversion>
{

    internal InnerTransformerFormatOptionsFactory FormatOptionsFactory { get; set; }

    protected override Humidifier.B2BI.TransformerTypes.InputConversion Create()
    {
        var inputConversionResult = CreateInputConversion();
        factoryAction?.Invoke(inputConversionResult);

        return inputConversionResult;
    }

    private Humidifier.B2BI.TransformerTypes.InputConversion CreateInputConversion()
    {
        var inputConversionResult = new Humidifier.B2BI.TransformerTypes.InputConversion();

        return inputConversionResult;
    }
    public override void CreateChildren(Humidifier.B2BI.TransformerTypes.InputConversion result)
    {
        base.CreateChildren(result);

        result.FormatOptions ??= FormatOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTransformerInputConversionFactoryExtensions
{
    public static CombinedResult<InnerTransformerInputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions(this InnerTransformerInputConversionFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null)
    {
        parentFactory.FormatOptionsFactory = new InnerTransformerFormatOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FormatOptionsFactory);
    }

    public static CombinedResult<InnerTransformerInputConversionFactory, T1, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<InnerTransformerInputConversionFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerInputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<T1, InnerTransformerInputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTransformerInputConversionFactory, T1, T2, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<InnerTransformerInputConversionFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerInputConversionFactory, T2, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, InnerTransformerInputConversionFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerInputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, T2, InnerTransformerInputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTransformerInputConversionFactory, T1, T2, T3, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<InnerTransformerInputConversionFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerInputConversionFactory, T2, T3, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, InnerTransformerInputConversionFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerInputConversionFactory, T3, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerInputConversionFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerInputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerInputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTransformerInputConversionFactory, T1, T2, T3, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<InnerTransformerInputConversionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerInputConversionFactory, T2, T3, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerInputConversionFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerInputConversionFactory, T3, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerInputConversionFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerInputConversionFactory, T4, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerInputConversionFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerInputConversionFactory, InnerTransformerFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerInputConversionFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.FormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T5, subFactoryAction));
}
