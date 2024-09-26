// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerCapabilityEdiTypeFactory(Action<Humidifier.B2BI.CapabilityTypes.EdiType> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.CapabilityTypes.EdiType>
{

    internal InnerCapabilityX12DetailsFactory X12DetailsFactory { get; set; }

    protected override Humidifier.B2BI.CapabilityTypes.EdiType Create()
    {
        var ediTypeResult = CreateEdiType();
        factoryAction?.Invoke(ediTypeResult);

        return ediTypeResult;
    }

    private Humidifier.B2BI.CapabilityTypes.EdiType CreateEdiType()
    {
        var ediTypeResult = new Humidifier.B2BI.CapabilityTypes.EdiType();

        return ediTypeResult;
    }
    public override void CreateChildren(Humidifier.B2BI.CapabilityTypes.EdiType result)
    {
        base.CreateChildren(result);

        result.X12Details ??= X12DetailsFactory?.Build();
    }

} // End Of Class

public static class InnerCapabilityEdiTypeFactoryExtensions
{
    public static CombinedResult<InnerCapabilityEdiTypeFactory, InnerCapabilityX12DetailsFactory> WithX12Details(this InnerCapabilityEdiTypeFactory parentFactory, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null)
    {
        parentFactory.X12DetailsFactory = new InnerCapabilityX12DetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.X12DetailsFactory);
    }

    public static CombinedResult<InnerCapabilityEdiTypeFactory, T1, InnerCapabilityX12DetailsFactory> WithX12Details<T1>(this CombinedResult<InnerCapabilityEdiTypeFactory, T1> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityEdiTypeFactory, InnerCapabilityX12DetailsFactory> WithX12Details<T1>(this CombinedResult<T1, InnerCapabilityEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCapabilityEdiTypeFactory, T1, T2, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2>(this CombinedResult<InnerCapabilityEdiTypeFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityEdiTypeFactory, T2, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2>(this CombinedResult<T1, InnerCapabilityEdiTypeFactory, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapabilityEdiTypeFactory, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2>(this CombinedResult<T1, T2, InnerCapabilityEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCapabilityEdiTypeFactory, T1, T2, T3, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<InnerCapabilityEdiTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityEdiTypeFactory, T2, T3, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<T1, InnerCapabilityEdiTypeFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapabilityEdiTypeFactory, T3, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapabilityEdiTypeFactory, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCapabilityEdiTypeFactory, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapabilityEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCapabilityEdiTypeFactory, T1, T2, T3, T4, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<InnerCapabilityEdiTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityEdiTypeFactory, T2, T3, T4, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapabilityEdiTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapabilityEdiTypeFactory, T3, T4, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapabilityEdiTypeFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCapabilityEdiTypeFactory, T4, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapabilityEdiTypeFactory, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCapabilityEdiTypeFactory, InnerCapabilityX12DetailsFactory> WithX12Details<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapabilityEdiTypeFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.X12Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithX12Details(combinedResult.T5, subFactoryAction));
}
