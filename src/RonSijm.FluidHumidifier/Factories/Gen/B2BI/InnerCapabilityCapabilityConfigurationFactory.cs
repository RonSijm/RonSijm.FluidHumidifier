// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerCapabilityCapabilityConfigurationFactory(Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration>
{

    internal InnerCapabilityEdiConfigurationFactory EdiFactory { get; set; }

    protected override Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration Create()
    {
        var capabilityConfigurationResult = CreateCapabilityConfiguration();
        factoryAction?.Invoke(capabilityConfigurationResult);

        return capabilityConfigurationResult;
    }

    private Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration CreateCapabilityConfiguration()
    {
        var capabilityConfigurationResult = new Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration();

        return capabilityConfigurationResult;
    }
    public override void CreateChildren(Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration result)
    {
        base.CreateChildren(result);

        result.Edi ??= EdiFactory?.Build();
    }

} // End Of Class

public static class InnerCapabilityCapabilityConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityEdiConfigurationFactory> WithEdi(this InnerCapabilityCapabilityConfigurationFactory parentFactory, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null)
    {
        parentFactory.EdiFactory = new InnerCapabilityEdiConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EdiFactory);
    }

    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, InnerCapabilityEdiConfigurationFactory> WithEdi<T1>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityEdiConfigurationFactory> WithEdi<T1>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, T4, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3, T4>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, T4, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, T4, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, T4, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityEdiConfigurationFactory> WithEdi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.EdiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEdi(combinedResult.T5, subFactoryAction));
}
