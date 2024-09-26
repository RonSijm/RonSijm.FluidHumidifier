// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerEdiTypeFactory(Action<Humidifier.B2BI.TransformerTypes.EdiType> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.EdiType>
{

    internal InnerTransformerX12DetailsFactory X12DetailsFactory { get; set; }

    protected override Humidifier.B2BI.TransformerTypes.EdiType Create()
    {
        var ediTypeResult = CreateEdiType();
        factoryAction?.Invoke(ediTypeResult);

        return ediTypeResult;
    }

    private Humidifier.B2BI.TransformerTypes.EdiType CreateEdiType()
    {
        var ediTypeResult = new Humidifier.B2BI.TransformerTypes.EdiType();

        return ediTypeResult;
    }
    public override void CreateChildren(Humidifier.B2BI.TransformerTypes.EdiType result)
    {
        base.CreateChildren(result);

        result.X12Details ??= X12DetailsFactory?.Build();
    }

} // End Of Class

public static class InnerTransformerEdiTypeFactoryExtensions
{
    public static CombinedResult<InnerTransformerEdiTypeFactory, InnerTransformerX12DetailsFactory> WithX12Details(this InnerTransformerEdiTypeFactory parentFactory, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null)
    {
        parentFactory.X12DetailsFactory = new InnerTransformerX12DetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.X12DetailsFactory);
    }

    public static CombinedResult<InnerTransformerEdiTypeFactory, T1, InnerTransformerX12DetailsFactory> WithX12Details<T1>(this CombinedResult<InnerTransformerEdiTypeFactory, T1> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerEdiTypeFactory, InnerTransformerX12DetailsFactory> WithX12Details<T1>(this CombinedResult<T1, InnerTransformerEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTransformerEdiTypeFactory, T1, T2, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2>(this CombinedResult<InnerTransformerEdiTypeFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerEdiTypeFactory, T2, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2>(this CombinedResult<T1, InnerTransformerEdiTypeFactory, T2> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerEdiTypeFactory, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2>(this CombinedResult<T1, T2, InnerTransformerEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTransformerEdiTypeFactory, T1, T2, T3, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<InnerTransformerEdiTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerEdiTypeFactory, T2, T3, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<T1, InnerTransformerEdiTypeFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerEdiTypeFactory, T3, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformerEdiTypeFactory, T3> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerEdiTypeFactory, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformerEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTransformerEdiTypeFactory, T1, T2, T3, T4, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<InnerTransformerEdiTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTransformerEdiTypeFactory, T2, T3, T4, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformerEdiTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTransformerEdiTypeFactory, T3, T4, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformerEdiTypeFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTransformerEdiTypeFactory, T4, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformerEdiTypeFactory, T4> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTransformerEdiTypeFactory, InnerTransformerX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformerEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.TransformerTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T5, subFactoryAction));
}
