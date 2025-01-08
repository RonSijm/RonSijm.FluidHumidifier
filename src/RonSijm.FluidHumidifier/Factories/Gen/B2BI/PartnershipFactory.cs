// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class PartnershipFactory(string resourceName = null, Action<Humidifier.B2BI.Partnership> factoryAction = null) : ResourceFactory<Humidifier.B2BI.Partnership>(resourceName)
{

    internal InnerPartnershipCapabilityOptionsFactory CapabilityOptionsFactory { get; set; }

    protected override Humidifier.B2BI.Partnership Create()
    {
        var partnershipResult = CreatePartnership();
        factoryAction?.Invoke(partnershipResult);

        return partnershipResult;
    }

    private Humidifier.B2BI.Partnership CreatePartnership()
    {
        var partnershipResult = new Humidifier.B2BI.Partnership
        {
            GivenName = InputResourceName,
        };

        return partnershipResult;
    }
    public override void CreateChildren(Humidifier.B2BI.Partnership result)
    {
        base.CreateChildren(result);

        result.CapabilityOptions ??= CapabilityOptionsFactory?.Build();
    }

} // End Of Class

public static class PartnershipFactoryExtensions
{
    public static CombinedResult<PartnershipFactory, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions(this PartnershipFactory parentFactory, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null)
    {
        parentFactory.CapabilityOptionsFactory = new InnerPartnershipCapabilityOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapabilityOptionsFactory);
    }

    public static CombinedResult<PartnershipFactory, T1, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1>(this CombinedResult<PartnershipFactory, T1> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnershipFactory, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1>(this CombinedResult<T1, PartnershipFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PartnershipFactory, T1, T2, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2>(this CombinedResult<PartnershipFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnershipFactory, T2, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2>(this CombinedResult<T1, PartnershipFactory, T2> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnershipFactory, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2>(this CombinedResult<T1, T2, PartnershipFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PartnershipFactory, T1, T2, T3, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3>(this CombinedResult<PartnershipFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnershipFactory, T2, T3, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3>(this CombinedResult<T1, PartnershipFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnershipFactory, T3, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3>(this CombinedResult<T1, T2, PartnershipFactory, T3> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartnershipFactory, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, PartnershipFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PartnershipFactory, T1, T2, T3, T4, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3, T4>(this CombinedResult<PartnershipFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnershipFactory, T2, T3, T4, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3, T4>(this CombinedResult<T1, PartnershipFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnershipFactory, T3, T4, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, PartnershipFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartnershipFactory, T4, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PartnershipFactory, T4> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PartnershipFactory, InnerPartnershipCapabilityOptionsFactory> WithCapabilityOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PartnershipFactory> combinedResult, Action<Humidifier.B2BI.PartnershipTypes.CapabilityOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilityOptions(combinedResult.T5, subFactoryAction));
}
