// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerAdvancedOptionsFactory(Action<Humidifier.B2BI.TransformerTypes.AdvancedOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.AdvancedOptions>
{

    internal InnerTransformerX12AdvancedOptionsFactory X12Factory { get; set; }

    protected override Humidifier.B2BI.TransformerTypes.AdvancedOptions Create()
    {
        var advancedOptionsResult = CreateAdvancedOptions();
        factoryAction?.Invoke(advancedOptionsResult);

        return advancedOptionsResult;
    }

    private Humidifier.B2BI.TransformerTypes.AdvancedOptions CreateAdvancedOptions()
    {
        var advancedOptionsResult = new Humidifier.B2BI.TransformerTypes.AdvancedOptions();

        return advancedOptionsResult;
    }
    public override void CreateChildren(Humidifier.B2BI.TransformerTypes.AdvancedOptions result)
    {
        base.CreateChildren(result);

        result.X12 ??= X12Factory?.Build();
    }

} // End Of Class

public static class InnerTransformerAdvancedOptionsFactoryExtensions
{
    public static CombinedResult<InnerTransformerAdvancedOptionsFactory, InnerTransformerX12AdvancedOptionsFactory> WithX12(this InnerTransformerAdvancedOptionsFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null)
    {
        parentFactory.X12Factory = new InnerTransformerX12AdvancedOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.X12Factory);
    }

    public static CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1>(this CombinedResult<InnerTransformerAdvancedOptionsFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1>(this CombinedResult<T1, InnerTransformerAdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, T2, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2>(this CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, T2, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2>(this CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerAdvancedOptionsFactory, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2>(this CombinedResult<T1, T2, InnerTransformerAdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, T2, T3, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, T2, T3, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerAdvancedOptionsFactory, T3, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerAdvancedOptionsFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformerAdvancedOptionsFactory, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerAdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, T2, T3, T4, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<InnerTransformerAdvancedOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, T2, T3, T4, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerAdvancedOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformerAdvancedOptionsFactory, T3, T4, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerAdvancedOptionsFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformerAdvancedOptionsFactory, T4, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerAdvancedOptionsFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerAdvancedOptionsFactory, InnerTransformerX12AdvancedOptionsFactory> WithX12<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerAdvancedOptionsFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12AdvancedOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12(combinedResult.T5, subFactoryAction).T2);
}
