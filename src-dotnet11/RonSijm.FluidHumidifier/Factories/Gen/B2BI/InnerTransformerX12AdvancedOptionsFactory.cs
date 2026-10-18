// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerX12AdvancedOptionsFactory(Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions>
{

    internal InnerTransformerX12ValidationOptionsFactory ValidationOptionsFactory { get; set; }

    internal InnerTransformerX12SplitOptionsFactory SplitOptionsFactory { get; set; }

    protected override Humidifier.B2BI.TransformerTypes.X12AdvancedOptions Create()
    {
        var x12AdvancedOptionsResult = CreateX12AdvancedOptions();
        factoryAction?.Invoke(x12AdvancedOptionsResult);

        return x12AdvancedOptionsResult;
    }

    private Humidifier.B2BI.TransformerTypes.X12AdvancedOptions CreateX12AdvancedOptions()
    {
        var x12AdvancedOptionsResult = new Humidifier.B2BI.TransformerTypes.X12AdvancedOptions();

        return x12AdvancedOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.TransformerTypes.X12AdvancedOptions result)
    {
        base.CreateChildren(result);

        result.ValidationOptions ??= ValidationOptionsFactory?.Build();
        result.SplitOptions ??= SplitOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTransformerX12AdvancedOptionsFactoryExtensions
{
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions(this InnerTransformerX12AdvancedOptionsFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null)
    {
        parentFactory.ValidationOptionsFactory = new InnerTransformerX12ValidationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidationOptionsFactory);
    }

    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12SplitOptionsFactory> WithSplitOptions(this InnerTransformerX12AdvancedOptionsFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null)
    {
        parentFactory.SplitOptionsFactory = new InnerTransformerX12SplitOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SplitOptionsFactory);
    }

    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2>(this CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3, T4, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3, T4, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3, T4, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory, T4, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12ValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSplitOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSplitOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2>(this CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3, T4, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3, T4>(this CombinedResult<InnerTransformerX12AdvancedOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3, T4, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerX12AdvancedOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3, T4, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerX12AdvancedOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory, T4, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerX12AdvancedOptionsFactory, InnerTransformerX12SplitOptionsFactory> WithSplitOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerX12AdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSplitOptions(combinedResult.T5, subFactoryAction).T2);
}
