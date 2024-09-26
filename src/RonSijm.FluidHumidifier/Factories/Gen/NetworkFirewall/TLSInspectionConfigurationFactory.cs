// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class TLSInspectionConfigurationFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.TLSInspectionConfiguration> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.TLSInspectionConfiguration>(resourceName)
{

    internal InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory TLSInspectionConfiguration_Factory { get; set; }

    protected override Humidifier.NetworkFirewall.TLSInspectionConfiguration Create()
    {
        var tLSInspectionConfigurationResult = CreateTLSInspectionConfiguration();
        factoryAction?.Invoke(tLSInspectionConfigurationResult);

        return tLSInspectionConfigurationResult;
    }

    private Humidifier.NetworkFirewall.TLSInspectionConfiguration CreateTLSInspectionConfiguration()
    {
        var tLSInspectionConfigurationResult = new Humidifier.NetworkFirewall.TLSInspectionConfiguration
        {
            GivenName = InputResourceName,
        };

        return tLSInspectionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.TLSInspectionConfiguration result)
    {
        base.CreateChildren(result);

        result.TLSInspectionConfiguration_ ??= TLSInspectionConfiguration_Factory?.Build();
    }

} // End Of Class

public static class TLSInspectionConfigurationFactoryExtensions
{
    public static CombinedResult<TLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_(this TLSInspectionConfigurationFactory parentFactory, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null)
    {
        parentFactory.TLSInspectionConfiguration_Factory = new InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TLSInspectionConfiguration_Factory);
    }

    public static CombinedResult<TLSInspectionConfigurationFactory, T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1>(this CombinedResult<TLSInspectionConfigurationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1>(this CombinedResult<T1, TLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TLSInspectionConfigurationFactory, T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2>(this CombinedResult<TLSInspectionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TLSInspectionConfigurationFactory, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2>(this CombinedResult<T1, TLSInspectionConfigurationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2>(this CombinedResult<T1, T2, TLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TLSInspectionConfigurationFactory, T1, T2, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3>(this CombinedResult<TLSInspectionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TLSInspectionConfigurationFactory, T2, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3>(this CombinedResult<T1, TLSInspectionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TLSInspectionConfigurationFactory, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3>(this CombinedResult<T1, T2, TLSInspectionConfigurationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3>(this CombinedResult<T1, T2, T3, TLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TLSInspectionConfigurationFactory, T1, T2, T3, T4, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3, T4>(this CombinedResult<TLSInspectionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TLSInspectionConfigurationFactory, T2, T3, T4, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, TLSInspectionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TLSInspectionConfigurationFactory, T3, T4, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, TLSInspectionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TLSInspectionConfigurationFactory, T4, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TLSInspectionConfigurationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> WithTLSInspectionConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSInspectionConfiguration_(combinedResult.T5, subFactoryAction));
}
